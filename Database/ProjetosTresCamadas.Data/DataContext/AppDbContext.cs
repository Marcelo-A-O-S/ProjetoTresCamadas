using DTO.Entidades;
using Microsoft.EntityFrameworkCore;
using ProjetoTresCamadas.DTO.Entidades;

namespace ProjetosTresCamadas.Data.DataContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProdutoVendido> ProdutosVendidos { get; set; }
        public DbSet<VendaParcelada> VendaParceladas { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<CompraParcelada> ComprasParcelada { get; set; }
        public DbSet<ProdutoComprado> ProdutosComprados { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GestaoDeComercio;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
