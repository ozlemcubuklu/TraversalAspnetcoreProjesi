using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Zorunlu alan.")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Zorunlu alan.")]
        [Compare("Password", ErrorMessage = "Parolalar eşit değil.")]
        public string ConfirmPassword { get; set; }
    }
}
