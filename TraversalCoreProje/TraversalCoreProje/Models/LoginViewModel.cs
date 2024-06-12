using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı giriniz.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen parola giriniz.")]

        public string Password { get; set; }
    }
}
