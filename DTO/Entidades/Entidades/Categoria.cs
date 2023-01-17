using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTresCamadas.DTO.Entidades
{
    public class Categoria 
    {
        [Key]
        public int Id { get; set; }
        public string TipoCategoria { get; set; }
        
        public List<Produto> ProdutosCategoria { get; set; }
    }
}
