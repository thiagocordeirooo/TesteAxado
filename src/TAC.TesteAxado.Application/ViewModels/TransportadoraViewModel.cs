using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TAC.TesteAxado.Application.ViewModels
{
    public class TransportadoraViewModel
    {
        public TransportadoraViewModel()
        {
            Id = Guid.NewGuid();
            Ativo = true;
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        public string Nome { get; set; }

        [MaxLength(400, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("Observação")]
        public string Observacao { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Data de Cadastro")]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }
    }
}