using Microsoft.AspNetCore.Mvc;
using Mod5_CRUD.Data;
using Mod5_CRUD.Models;

namespace Mod5_CRUD.Controllers {
	public class AlugueresController : Controller {
		private readonly ApplicationDbContext _context;

		public AlugueresController(ApplicationDbContext context) {
			_context = context;
		}

		public IActionResult Index(string pesquisa, int pagina = 1) {
			int itensPorPagina = 5;

			var query = _context.Alugueres.AsQueryable();

			if (!string.IsNullOrWhiteSpace(pesquisa)) {
				query = query.Where(a =>
					a.Cliente.Contains(pesquisa) ||
					a.Vendedor.Contains(pesquisa) ||
					a.Veiculo.Contains(pesquisa));
			}

			int totalRegistos = query.Count();
			int totalPaginas = (int)Math.Ceiling((double)totalRegistos / itensPorPagina);

			if (pagina < 1) {
				pagina = 1;
			}
			if (pagina > totalPaginas && totalPaginas > 0) {
				pagina = totalPaginas;
			}

			var alugueres = query
				.OrderBy(a => a.Id)
				.Skip((pagina - 1) * itensPorPagina)
				.Take(itensPorPagina)
				.ToList();

			ViewBag.PaginaAtual = pagina;
			ViewBag.TotalPaginas = totalPaginas;
			ViewBag.Pesquisa = pesquisa;

			return View(alugueres);
		}

		[HttpGet]
		public IActionResult Cadastrar() {
			return View();
		}

		[HttpPost]
		public IActionResult Cadastrar(AlugueresModel alugueresModel) {
			if (ModelState.IsValid) {
				try {
					_context.Alugueres.Add(alugueresModel);
					_context.SaveChanges();
					TempData["Mensagem"] = "Aluguer veiculo cadastrado com sucesso!";
					TempData["TipoMensagem"] = "success";
					return RedirectToAction("Index");
				}
				catch {
					TempData["Mensagem"] = "Erro ao cadastrar aluguer veiculo.";
					TempData["TipoMensagem"] = "danger";
					return View(alugueresModel);
				}
			}
			TempData["Mensagem"] = "Erro ao cadastrar aluguer veiculo. Verifique os dados.";
			TempData["TipoMensagem"] = "danger";
			return View(alugueresModel);
		}

		[HttpGet]
		public IActionResult Editar(int id) {
			var aluguer = _context.Alugueres.FirstOrDefault(a => a.Id == id);
			if (aluguer == null) {
				return NotFound();
			}
			return View(aluguer);
		}

		[HttpPost]
		public IActionResult Editar(AlugueresModel alugueresModel) {
			if (ModelState.IsValid) {
				try {
					_context.Alugueres.Update(alugueresModel);
					_context.SaveChanges();
					TempData["Mensagem"] = "Aluguer veiculo editado com sucesso!";
					TempData["TipoMensagem"] = "success";
					return RedirectToAction("Index");
				}
				catch {
					TempData["Mensagem"] = "Erro ao editar aluguer veiculo.";
					TempData["TipoMensagem"] = "danger";
					return View(alugueresModel);
				}
			}
			TempData["Mensagem"] = "Erro ao editar aluguer veiculo. Verifique os dados.";
			TempData["TipoMensagem"] = "danger";
			return View(alugueresModel);
		}

		[HttpGet]
		public IActionResult Excluir(int id) {
			var aluguer = _context.Alugueres.FirstOrDefault(a => a.Id == id);
			if (aluguer == null) {
				return NotFound();
			}
			return View(aluguer);
		}

		[HttpPost, ActionName("Excluir")]
		public IActionResult ExcluirConfirmado(int id) {
			try {
				var aluguer = _context.Alugueres.FirstOrDefault(a => a.Id == id);
				if (aluguer != null) {
					_context.Alugueres.Remove(aluguer);
					_context.SaveChanges();
					TempData["Mensagem"] = "Aluguer veiculo excluído com sucesso!";
					TempData["TipoMensagem"] = "success";
				}
				else {
					TempData["Mensagem"] = "Erro ao excluir aluguer veiculo. Registo não encontrado.";
					TempData["TipoMensagem"] = "danger";
				}
			}
			catch {
				TempData["Mensagem"] = "Erro ao excluir aluguer veiculo.";
				TempData["TipoMensagem"] = "danger";
			}
			return RedirectToAction("Index");
		}
	}
}