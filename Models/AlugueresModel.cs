using System.ComponentModel.DataAnnotations;

namespace Mod5_CRUD.Models {
	public class AlugueresModel {
		public int Id { get; set; }

		[Required(ErrorMessage = "Digite o nome do Cliente!")]
		public string Cliente { get; set; }

		[Required(ErrorMessage = "Digite o nome do Vendedor!")]
		public string Vendedor { get; set; }

		[Required(ErrorMessage = "Digite a marca do Veiculo!")]
		public string Veiculo { get; set; }

		public DateTime DataAluguer { get; set; } = DateTime.Now;
	}
}