
using System.ComponentModel.DataAnnotations;


namespace ProjetosTresCamadas.Data.Entidades
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public int Numeracao { get; set; }
        public string Cidade { get; set; }
    }
}
