namespace lojas_soul.Models
{
    public class DadosPag
    {
        public int Id { get; set; }
        public Tipo Type { get; set; }
        public double Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public Venda Venda { get; set; }

    }

    public enum Tipo : int
    {

        Pix = 0,
        Boleto = 1,
        Debito = 2,
        Credito = 3
    }

}
