using System.ComponentModel.DataAnnotations;

namespace TAC.TesteAxado.Infra.CrossCuting.Identity.Model
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage= "Preencha o campo Email")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail v�lido")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo Senha")]
        [StringLength(100, ErrorMessage = "O {0} deve ter {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha")]
        [Compare("Password", ErrorMessage = "A confirma��o da senha est� incorrta, verifique.")]
        public string ConfirmPassword { get; set; }
    }
}