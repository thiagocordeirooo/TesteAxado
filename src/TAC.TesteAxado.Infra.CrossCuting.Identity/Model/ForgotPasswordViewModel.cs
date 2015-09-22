using System.ComponentModel.DataAnnotations;

namespace TAC.TesteAxado.Infra.CrossCuting.Identity.Model
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
