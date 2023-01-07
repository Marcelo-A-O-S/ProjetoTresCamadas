using System.ComponentModel.DataAnnotations;

namespace ProjetosTresCamadas.Data.Entidades
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string TipoCategoria { get; set; }
        public List<Produto> ProdutosCategoria { get; set; }
    }
}