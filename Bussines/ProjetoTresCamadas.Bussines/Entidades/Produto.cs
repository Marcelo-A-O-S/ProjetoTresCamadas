using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTresCamadas.Bussines.Entidades
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
