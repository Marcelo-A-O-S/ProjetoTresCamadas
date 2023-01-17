using DTO.Enums;
using ProjetoTresCamadas.DTO.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entidades
{
    public class Venda
    {
        [Key]
        public int Id { get; set; }
        public string TipoDePagamento { get; set; } 
        public List<ProdutoVendido> Produtos { get; set; }
        public int QuantidadeVendidos { get; set; }
        public DateTime DataDaVenda { get; set; } = DateTime.Now;
        public bool PagamentoRealizado { get; set; } = false;
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorTotal { get; set; }
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public string NomeCliente { get; set; }
        public virtual Cliente cliente { get; set; }
        [ForeignKey("Funcionario")]
        public int FuncionarioId { get; set; }
        public string NomeFuncionario { get; set; }
        public virtual Funcionario funcionario { get; set; }
    }
}
