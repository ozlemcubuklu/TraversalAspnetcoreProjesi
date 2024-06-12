using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
	public class RegisterViewModel
	{
        [Required(ErrorMessage ="Lütfen bir isim giriniz.")]
        public string Name { get; set; }
		[Required(ErrorMessage = "Lütfen bir soyisim giriniz.")]
		public string SurName { get; set; }
		[Required(ErrorMessage = "Lütfen bir kullanıcı adı giriniz.")]
		public string UserName { get; set; }
		[Required(ErrorMessage = "Lütfen bir email giriniz.")]
		[EmailAddress(ErrorMessage = "Lütfen geçerli bir email giriniz.")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Lütfen bir şifre giriniz.")]
		
		public string Password { get; set; }
		
		[Compare("Password",ErrorMessage ="Parolalar eşit değil.")]
		public string ConfirmPassword { get; set; }
    }
}
