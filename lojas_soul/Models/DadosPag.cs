using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace lojas_soul.Models
{
    public class DadosPag
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tipo")]
        public Tipo Type { get; set; }
        [Required]
        [Range(1,999.99)]
        public double Valor { get; set; }
        [Display(Name = "Data Pagamento")]
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
