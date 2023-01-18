using DTO.Entidades;
using ProjetoTresCamadas.Bussines.Reposity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTresCamadas.Bussines.Services
{
    public class GestaoProdutoComprado
    {
        private readonly GestaoProdutoCompradoRepository gestaoProdutoComprado = new();
        public GestaoProdutoComprado()
        {

        }
        public GestaoProdutoComprado(GestaoProdutoCompradoRepository gestaoProdutoComprado)
        {
            this.gestaoProdutoComprado = gestaoProdutoComprado;
        }
        public string SalvarProdutoComprado(ProdutoComprado produtoComprado)
        {
            var Erro = "O produto comprado foi salvo com sucesso!";
            try
            {
                if(produtoComprado.Id == 0)
                {
                    gestaoProdutoComprado.Adicionar(produtoComprado);
                }
                else
                {
                    gestaoProdutoComprado.Editar(produtoComprado);
                }
            }catch(Exception erro)
            {
                Erro = erro.Message;
            }
            return Erro;
        }
        public string ExcluirProdutoComprado(ProdutoComprado produtoComprado)
        {
            var Erro = "O produto comprado foi salvo com sucesso!";
            try
            {
                gestaoProdutoComprado.Excluir(produtoComprado);
            }
            catch (Exception erro)
            {
                Erro = erro.Message;
            }
            return Erro;
        }
        public async Task<ProdutoComprado> BuscarProdutoCompradoPor(Expression<Func<ProdutoComprado, bool>> predicado)
        {
            return await gestaoProdutoComprado.BuscarPor(predicado);
        }
        public async Task<IList<ProdutoComprado>> ObterProdutosComprados()
        {
            return await gestaoProdutoComprado.ObterTodos();
        }
    }
}
