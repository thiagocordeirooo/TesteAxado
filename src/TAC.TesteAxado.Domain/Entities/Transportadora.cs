using System;

namespace TAC.TesteAxado.Domain.Entities
{
    public class Transportadora
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Observacao { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}