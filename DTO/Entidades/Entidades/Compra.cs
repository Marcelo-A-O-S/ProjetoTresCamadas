using ProjetoTresCamadas.DTO.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entidades
{
    public class Compra
    {
        [Key]
        public int Id { get; set; }
        public string TipoDePagamento { get; set; }
        public List<Produto> Produtos { get; set; }
        public int QuantidadeComprados { get; set; }
        public DateTime DataDaCompra { get; set; } = DateTime.Now;
        public bool PagamentoRealizado { get; set; } = false;
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorTotal { get; set; }
        [ForeignKey("Fornecedor")]
        public int FornecedorId { get; set; }
        public string NomeFantasiaFornecedor { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        [ForeignKey("Funcionario")]
        public int FuncionarioId { get; set; }
        public string NomeFuncionario { get; set; }
        public virtual Funcionario funcionario { get; set; }
    }
}
