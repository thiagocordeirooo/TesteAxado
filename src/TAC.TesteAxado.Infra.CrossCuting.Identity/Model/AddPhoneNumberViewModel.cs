using System.ComponentModel.DataAnnotations;

namespace TAC.TesteAxado.Infra.CrossCuting.Identity.Model
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}