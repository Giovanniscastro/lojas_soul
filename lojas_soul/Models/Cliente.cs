using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Xml.Linq;

namespace lojas_soul.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [StringLength(11)]
        public string Cpf { get; set; }
        [Display(Name = "Data Nascimento")]
        public DateTime Data_nasc { get; set; }
        [StringLength(11)]
        public string Telefone { get; set; }
        public string Email { get; set; }
        ICollection<Cliente> ClienteList { get; set; } = new List<Cliente>();

        public Cliente()
        {
            // Construtor vazio
        }

        public Cliente(int id, string nome, string cpf, DateTime data_nasc, string telefone, string email)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Data_nasc = data_nasc;
            Telefone = telefone;
            Email = email;
        }
    }
}

