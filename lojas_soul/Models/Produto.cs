namespace lojas_soul.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public double Valor { get; set; }

        public int Quantidade { get; set; }

        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public List<Venda> Vendas { get; } = new List<Venda>();
        public Produto()
        {
            // Construtor vazio
        }

        public Produto(int id, string nome, string descricao, double valor, int quantidade, int fornecedorId)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Quantidade = quantidade;
            FornecedorId = fornecedorId; 
        }
    }
}

