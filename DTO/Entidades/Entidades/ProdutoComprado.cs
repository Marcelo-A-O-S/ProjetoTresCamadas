using ProjetoTresCamadas.DTO.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entidades
{
    public class ProdutoComprado
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorProduto { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorTotalProduto { get; set; }
        public int QuantidadeProdutos { get; set; }
        [ForeignKey("Fornecedor")]
        public int FornecedorId { get; set; }
        public string NomeFornecedor { get; set; }
        public Fornecedor fornecedor { get; set; }
        [ForeignKey("Compra")]
        public int? CompraId { get; set; }
        public Compra compra { get; set; }
        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public Categoria categoria { get; set; }
    }
}
