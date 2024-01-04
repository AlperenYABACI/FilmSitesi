using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmSitesi.Entities
{
	[Table("Yorumlar")]
	public class Yorumlar
	{
		[Key]
		public int CommentId { get; set; }

		public int FilmId { get; set; }

		[ForeignKey("UserId")]
		public Guid UserId { get; set; }

		[StringLength(150)]
		public string Icerik { get; set; }

		public DateTime CreatedAt { get; set; }

		// User sınıfını ekleyerek ilişkiyi oluşturuyoruz
		public User User { get; set; }
	}
}
