namespace lojas_soul.Models
{
    public class DadosPag
    {
        public int Id { get; set; }
        public Tipo Type { get; set; }
        public double Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public DadosPag()
        {
            // Construtor vazio
        }

        public DadosPag(int id, Tipo type, double valor, DateTime dataPagamento)
        {
            Id = id;
            Type = type;
            Valor = valor;
            DataPagamento = dataPagamento;
        }
    }

    public enum Tipo : int
    {

        Pix = 0,
        Boleto = 1,
        Debito = 2,
        Credito = 3
    }

}
