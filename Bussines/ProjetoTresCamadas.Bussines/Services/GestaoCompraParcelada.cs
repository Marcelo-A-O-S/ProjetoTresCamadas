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
    public class GestaoCompraParcelada
    {
        private readonly GestaoComprasParceladaRepository comprasParceladaRepository = new();

        public GestaoCompraParcelada()
        {

        }
        public GestaoCompraParcelada(GestaoComprasParceladaRepository comprasParceladaRepository)
        {
            this.comprasParceladaRepository = comprasParceladaRepository;
        }
        public string SalvarCompraParcelada(CompraParcelada compraParcelada)
        {
            var Erro = "Compra parcelada feita com sucesso!";
            try
            {
                if(compraParcelada.Id == 0)
                {
                    comprasParceladaRepository.Adicionar(compraParcelada);
                }
                else
                {
                    comprasParceladaRepository.Editar(compraParcelada);
                }
            }catch(Exception erro)
            {
                Erro = erro.Message;
            }

            return Erro;
        }
        public string ExcluirCompraParcelada(CompraParcelada compraParcelada)
        {
            var Erro = "Compra parcelada removida com sucesso!";
                try
                {
                    comprasParceladaRepository.Excluir(compraParcelada);
                }catch(Exception erro)
                {
                    Erro = erro.Message;
                }
            return Erro;
        }
        public CompraParcelada BuscarCompraParceladaPor(Expression<Func<CompraParcelada, bool>> predicado)
        {
            return comprasParceladaRepository.BuscarPor(predicado).Result;
        }
    }
}
