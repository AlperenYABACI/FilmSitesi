using FilmSitesi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FilmSitesi.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
		[AllowAnonymous]
		public IActionResult Izlenen()
        {
            return View();
        }

		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}

		[AllowAnonymous]
		public IActionResult YuksekPuan()
		{
			return View();
		}

		[AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
         public IActionResult AccessDenied()
         {
            return View();
         }

		[AllowAnonymous]
		public IActionResult Info()
		{
			return View();
		}

		[AllowAnonymous]
		public IActionResult Iletisim()
		{
			return View();
		}

		[AllowAnonymous]
		public IActionResult FilmSayfa()
        {
            return View();
        }

		[AllowAnonymous]
		public IActionResult Kategori()
		{
			return View();
		}

		[AllowAnonymous]
		public IActionResult Ara()
		{
			return View();
		}

		[AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}