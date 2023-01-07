using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ProjetosTresCamadas.Data.Entidades
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }

        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }

        public Categoria categoria { get; set; }
    }
}
