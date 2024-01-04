using FilmSitesi.Entities;
using FilmSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace FilmSitesi.Controllers
{
	public class CommentController : Controller
	{
		private readonly DatabaseContext _context;

		public CommentController(DatabaseContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var yorumlar = _context.Yorumlar.ToList();
			return View(yorumlar);
		}

		public IActionResult GetByMovieId(int movieId)
		{
			var yorumlar = _context.Yorumlar.Where(y => y.FilmId == movieId).ToList();
			return View(yorumlar);
		}

		[HttpPost]
		public IActionResult Add(YorumViewModel yorumViewModel)
		{
			if (ModelState.IsValid)
			{
				var yeniYorum = new Yorumlar
				{
					FilmId = yorumViewModel.FilmId,
					Icerik = yorumViewModel.Icerik,
					// Diğer gerekli özellikleri ayarla
				};

				_context.Yorumlar.Add(yeniYorum);
				_context.SaveChanges();

				return RedirectToAction("Index");
			}

			// ModelState.IsValid false ise, formu tekrar göster
			return View();
		}
	}
}
