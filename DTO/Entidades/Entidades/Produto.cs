using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjetoTresCamadas.DTO.Entidades
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public virtual Categoria categoria { get; set; }
    }
}
