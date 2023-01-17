

using ProjetosTresCamadas.Data.Reposity;
using ProjetoTresCamadas.DTO.Entidades;
using System.Linq.Expressions;

namespace ProjetoTresCamadas.Bussines.Services
{
    public class GestaoClientes :IDisposable 
    {
        private readonly GestaoClienteRepository Cliente = new GestaoClienteRepository();

        public GestaoClientes()
        {
        }
        public GestaoClientes(GestaoClienteRepository cliente)
        {

            Cliente = cliente;
        }
        public string SalvarCliente(Cliente cliente)
        {
            var erro = "Cliente salvo no banco de dados com Sucesso";
            try
            {
                if(cliente.Id == 0)
                {
                    Cliente.Adicionar(cliente);
                }
                else
                {
                    Cliente.Editar(cliente);
                    erro = "A edicão do cliente no banco de dados foi feita com sucesso!";
                }
                
                Cliente.Salvar();
                Cliente.Dispose();
            }
            catch (Exception e)
            {
                erro = e.Message;
            }
            return erro;
        }
        public string RemoverCliente(Cliente cliente)
        {
            var erro = "Cliente removido do banco de dados com sucesso!";
            try
            {
                Cliente.Excluir(cliente);
            }
            catch (Exception e)
            {
                erro = e.Message;
            }
            return erro;
        }
        public async Task<IList<Cliente>> ObterClientes()
        {
                var clientes = await Cliente.ObterTodos();
                return clientes;
        }
        public async Task<Cliente> BuscarCliente(Expression<Func<Cliente, bool>> predicado)
        {
            return await Cliente.BuscarPor(predicado);
        }

        public void Dispose()
        {
            Cliente.Dispose();
        }
    }
}
