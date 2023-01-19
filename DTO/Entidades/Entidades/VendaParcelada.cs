using ProjetoTresCamadas.DTO.Entidades;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DTO.Entidades
{
    public class VendaParcelada
    {
        [Key]
        public int Id { get; set; }
        public int QuantidadeParcelas { get; set; }
        public int ParcelasRestantes { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorDaParcela { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorRestante { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorTotal { get; set; }
        public int MesInicial { get; set; } = DateTime.Now.Month;
        public int MesFinal { get; set; }
        public DateTime DataPagamentoInicial { get; set; }

        [ForeignKey("Venda")]
        public int VendaId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorPago { get; set; }
        public virtual Venda venda { get; set; }
        


    }
}
