using System.Drawing;

namespace lojas_soul.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        public string Endereco { get; set; }
        public string Email { get; set; }

        public string Telefone { get; set; }
        ICollection<Produto> ProdutoList { get; set; } = new List<Produto>();
        public Fornecedor()
        {
            // Construtor vazio
        }

        public Fornecedor(int id, string nome, string cnpj, string endereco, string email, string telefone)
        {
            Id = id;
            Nome = nome;
            Cnpj = cnpj;
            Endereco = endereco;
            Email = email;
            Telefone = telefone;
        }
    }
}

