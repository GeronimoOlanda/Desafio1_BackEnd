using System.ComponentModel.DataAnnotations;

namespace gerenciamentoTarefas.API.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }
    }
}
