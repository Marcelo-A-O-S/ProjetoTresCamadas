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
    public class GestaoCompra
    {
        private readonly GestaoComprasRepository gestaoComprasRepository = new();

        public GestaoCompra()
        {

        }
        public GestaoCompra(GestaoComprasRepository gestaoComprasRepository)
        {
            this.gestaoComprasRepository = gestaoComprasRepository;
        }
        public string SalvarCompra(Compra compra)
        {
            var Erro = "Compra salva com sucesso!";
            try
            {
                if(compra.Id == 0)
                {
                    gestaoComprasRepository.Adicionar(compra);
                }
                else
                {
                    gestaoComprasRepository.Editar(compra);
                }
            }catch(Exception erro)
            {
                Erro = erro.Message;
            }
            return Erro;
        }
        public string ExcluirCompra(Compra compra)
        {
            var Erro = "Compra removida com sucesso!";
            try
            {
                gestaoComprasRepository.Excluir(compra);
            }catch(Exception erro)
            {
                Erro = erro.Message;
            }
            return Erro;
        }
        public Compra BuscarCompraPor(Expression<Func<Compra, bool>> predicado)
        {
            return gestaoComprasRepository.BuscarPor(predicado).Result;
        }
        public async Task<IList<Compra>> ObterCompras()
        {
            return await gestaoComprasRepository.ObterTodos();
        }
    }
}
