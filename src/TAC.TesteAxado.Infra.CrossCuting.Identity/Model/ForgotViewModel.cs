using System.ComponentModel.DataAnnotations;

namespace TAC.TesteAxado.Infra.CrossCuting.Identity.Model
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}