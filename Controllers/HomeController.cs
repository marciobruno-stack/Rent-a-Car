using Microsoft.AspNetCore.Mvc;
using Mod5_CRUD.Models;
using System.Diagnostics;

namespace Mod5_CRUD.Controllers {
	public class HomeController : Controller {
		public IActionResult Index() {
			return View();
		}

		public IActionResult Privacy() {
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error() {
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
