using MP.Agenda.API.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MP.Agenda.API.Models
{
    [Table("Medicos")]
    public class Medico : BaseEntity
    {
        [Required]
        [StringLength(150)]
        public string Nome { get; set; }
        [Required]
        public DateTime Nascimento { get; set; }
        public string UrlImagem { get; set; }
        public Endereco Endereco { get; set; }
    }
    [Table("Enderecos")]
    public class Endereco : BaseEntity
    {
        public int Cep { get; set; }
        public string Rua { get; set; }
        public int Numeroe { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
