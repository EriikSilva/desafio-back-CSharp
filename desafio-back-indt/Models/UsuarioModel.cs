using desafio_back_indt.Enums;
using System.ComponentModel.DataAnnotations;

namespace desafio_back_indt.Models
{
    public class UsuarioModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public NivelAcessoEnum Nivel_Acesso { get; set; }
        public DateTime DataDeCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataDeAtualizacao { get; set; } = DateTime.Now.ToLocalTime();
    }
}
