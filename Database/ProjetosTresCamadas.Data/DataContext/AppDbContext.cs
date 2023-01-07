using Microsoft.EntityFrameworkCore;
using ProjetosTresCamadas.Data.Entidades;


namespace ProjetosTresCamadas.Data.DataContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SistemaFinanceiro;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
