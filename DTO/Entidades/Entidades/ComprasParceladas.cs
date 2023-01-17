using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entidades
{
    public class CompraParcelada
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

        [ForeignKey("Compra")]
        public int CompraId { get; set; }
        public virtual Compra compra { get; set; }
    }
}
