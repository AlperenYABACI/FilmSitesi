using FilmSitesi.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace FilmSitesi.Models
{
	public class YorumViewModel
	{
		public int CommentId { get; set; }

		public int FilmId { get; set; }

		public Guid UserId { get; set; }

		[Required(ErrorMessage = "Icerik alanı boş bırakılamaz.")]
		public string Icerik { get; set; }

		public DateTime CreatedAt { get; set; }

		public virtual User User { get; set; }
	}
}
