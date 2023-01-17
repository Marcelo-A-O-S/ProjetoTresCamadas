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
    public class GestaoVendas
    {
        private readonly GestaoVendasRepository gestaoVendas = new();

        public GestaoVendas()
        {

        }
        public GestaoVendas(GestaoVendasRepository gestaoVendas)
        {
            this.gestaoVendas = gestaoVendas;
        }
        public string SalvarVenda(Venda venda)
        {
            var Erro = "Venda realizada com Sucesso!";
            try
            {
                if(venda.Id == 0)
                {
                    gestaoVendas.Adicionar(venda);
                }
                else
                {
                    gestaoVendas.Editar(venda);
                }

            }catch(Exception e)
            {
                Erro = e.Message;
            }
            return Erro;
        }
        public string ExcluirVenda(Venda venda)
        {
            var Erro = "Venda removida com sucesso";
            try
            {
                gestaoVendas.Excluir(venda);
            }catch(Exception e)
            {
                Erro = e.Message;
            }
            return Erro;
        }
        public async Task<IList<Venda>> ObterVendas()
        {
            return await gestaoVendas.ObterTodos();
        }
        public async Task<Venda> BuscarVendaPor(Expression<Func<Venda, bool>> predicado)
        {
            return await gestaoVendas.BuscarPor(predicado);
        }
    }
}
