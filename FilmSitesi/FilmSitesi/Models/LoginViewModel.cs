using System.ComponentModel.DataAnnotations;

namespace FilmSitesi.Models
{
	public class LoginViewModel
	{
		[Required(ErrorMessage ="Kullanıcı Adı Girilmesi Zorunludur!")]
		[StringLength(30, ErrorMessage ="Kullanıcı Adı 30 Karakterden Fazla Olamaz!")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Şifre Girilmesi Zorunludur!")]
		[MinLength(6 , ErrorMessage = "Şifre En Az 6 Karakter Olabilir!")]
		[MaxLength(16 , ErrorMessage = "Şifre En Fazla 16 Karakter Olabilir!")]
		public string Password { get; set; }
	}
}
