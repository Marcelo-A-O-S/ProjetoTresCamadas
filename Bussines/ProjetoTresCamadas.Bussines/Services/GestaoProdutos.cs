using System.Linq.Expressions;
using ProjetosTresCamadas.Data.Reposity;
using ProjetoTresCamadas.DTO.Entidades;

namespace ProjetoTresCamadas.Bussines.Services
{
    public class GestaoProdutos
    {
        public readonly GestaoProdutosRepository gestaoProdutosRepository = new();

        public GestaoProdutos()
        {

        }
        public GestaoProdutos(GestaoProdutosRepository gestaoProdutosRepository)
        {
            this.gestaoProdutosRepository = gestaoProdutosRepository;
        }
        public string SalvarProduto(Produto produto)
        {
            var Erro = "Produto salvo com sucesso!";
            try
            {
                if(produto.Id == 0)
                {
                    gestaoProdutosRepository.Adicionar(produto);
                }
                else
                {
                    gestaoProdutosRepository.Editar(produto);
                    Erro = "Produto Editado com sucesso!";
                }
                
            }
            catch(Exception e)
            {
                Erro = e.Message;
            }
            return Erro;
        }
        public string ExcluirProduto(Produto produto)
        {
            var Erro = "Produto excluido com sucesso";
            try
            {
                gestaoProdutosRepository.Excluir(produto);
            }catch(Exception e)
            {
                Erro = e.Message;
            }
            return Erro;
        }
        public async Task<IList<Produto>> ObterProdutos()
        {
            return await gestaoProdutosRepository.ObterTodos();
        }
        public async Task<Produto> BuscarProdutoPor(Expression<Func<Produto, bool>> predicado)
        {
            return await gestaoProdutosRepository.BuscarPor(predicado);
        }
        
    }
}
