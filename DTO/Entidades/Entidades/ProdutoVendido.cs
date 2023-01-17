using ProjetoTresCamadas.DTO.Entidades;

using System.ComponentModel.DataAnnotations.Schema;


namespace DTO.Entidades
{
    public class ProdutoVendido
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorProduto { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorTotalProduto { get; set; }
        public int QuantidadeProdutos { get; set; }
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public string NomeCliente { get; set; }
        public Cliente cliente { get; set; }
        [ForeignKey("Vendas")]
        public int VendaId { get; set; }
        public Venda venda { get; set; }
        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public Categoria categoria { get; set; }
        

    }
}
