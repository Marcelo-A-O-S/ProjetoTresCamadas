using System.ComponentModel.DataAnnotations;


namespace ProjetosTresCamadas.Data.Entidades
{
    public class Fornecedor
    {
        [Key]
        public int Id { get; set; }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public int Numeracao { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }
    }
}
