using System.ComponentModel.DataAnnotations;

namespace FilmSitesi.Models
{
	public class RegisterViewModel
	{
		[Required(ErrorMessage = "Kullanıcı Adı Girilmesi Zorunludur!")]
		[StringLength(30, ErrorMessage = "Kullanıcı Adı 30 Karakterden Fazla Olamaz!")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Şifre Girilmesi Zorunludur!")]
		[MinLength(6, ErrorMessage = "Şifre En Az 6 Karakter Olabilir!")]
		[MaxLength(16, ErrorMessage = "Şifre En Fazla 16 Karakter Olabilir!")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Şifrenin Tekrar Girilmesi Zorunldur!")]
		[MinLength(6)]
		[MaxLength(16)]
		[Compare(nameof(Password) , ErrorMessage = "Şifreler Aynı Değil!")]
		public string RePassword { get; set; }
	}
}
