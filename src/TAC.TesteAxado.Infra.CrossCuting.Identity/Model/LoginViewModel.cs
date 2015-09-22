using System.ComponentModel.DataAnnotations;

namespace TAC.TesteAxado.Infra.CrossCuting.Identity.Model
{
    public class LoginViewModel
    {
        [Required(ErrorMessage="Preencha o campo Email")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo Senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Lembrar meu usuário")]
        public bool RememberMe { get; set; }
    }
}