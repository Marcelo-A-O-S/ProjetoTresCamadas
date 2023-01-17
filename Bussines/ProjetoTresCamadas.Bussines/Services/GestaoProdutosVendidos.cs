
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
    public class GestaoProdutosVendidos
    {
        private readonly GestaoProdutoVendidoRepository gestaoProdutoVendido = new();

        public GestaoProdutosVendidos()
        {

        }
        public GestaoProdutosVendidos(GestaoProdutoVendidoRepository gestaoProdutoVendido)
        {
            this.gestaoProdutoVendido = gestaoProdutoVendido;
        }
        public string SalvarProdutoVendido(ProdutoVendido produtoVendido)
        {
            var Erro = "A produto vendido foi registrado com successo!";
            try
            {
                if(produtoVendido.Id == 0)
                {
                    gestaoProdutoVendido.Adicionar(produtoVendido);
                }
                else
                {
                    gestaoProdutoVendido.Editar(produtoVendido);
                    Erro = "Produto vendido editado com sucesso";
                }
            }catch(Exception e)
            {
                Erro = e.Message;
            }
            return Erro;
        }
        public string ExcluirProdutoVendido(ProdutoVendido produtoVendido)
        {
            var Erro = "O registro do produto vendido foi excluido com sucesso!";
            try
            {
                gestaoProdutoVendido.Excluir(produtoVendido);
            }
            catch (Exception e)
            {
                Erro = e.Message;
            }
            return Erro;
        }
        public async Task<ProdutoVendido> BuscarProdutoVendidoPor(Expression<Func<ProdutoVendido, bool>> predicado)
        {
            return await gestaoProdutoVendido.BuscarPor(predicado);
        }
        public async Task<IList<ProdutoVendido>> ObterProdutosVendidos()
        {
            return await gestaoProdutoVendido.ObterTodos();
        }
    }
}
