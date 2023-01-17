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
    public class GestaoVendasParceladas
    {
        private readonly GestaoVendaParceladaRepository gestaoVendaParcelada = new();

        public GestaoVendasParceladas()
        {

        }
        public GestaoVendasParceladas(GestaoVendaParceladaRepository gestaoVendaParcelada)
        {
            this.gestaoVendaParcelada = gestaoVendaParcelada;
        }
        public string SalvarVendaParcelada(VendaParcelada vendaParcelada)
        {
            var Erro = "Venda parcelada com sucesso!";
            try
            {
                if(vendaParcelada.Id == 0)
                {
                    gestaoVendaParcelada.Adicionar(vendaParcelada);
                }
                else
                {
                    gestaoVendaParcelada.Editar(vendaParcelada);
                    Erro = "Parcelas editadas com sucesso!";
                }
            }
            catch (Exception e)
            {
                Erro = e.Message; 
            }
            return Erro;
        }
        public string ExcluirVendaParcelada(VendaParcelada vendaParcelada)
        {
            var Erro = "VendaParcelada excluida com sucesso!";
            try
            {
                gestaoVendaParcelada.Excluir(vendaParcelada);
            }
            catch (Exception e)
            {
                Erro = e.Message;
            }
            return Erro;
        }
        public async Task<VendaParcelada> BuscarVendaParcelada(Expression<Func<VendaParcelada, bool>> vendaParcelada)
        {
            return await gestaoVendaParcelada.BuscarPor(vendaParcelada);
        }
        public async Task<IList<VendaParcelada>> ObterVendasParceladas()
        {
            return gestaoVendaParcelada.ObterTodos().Result.ToList();
        }
    }
}
