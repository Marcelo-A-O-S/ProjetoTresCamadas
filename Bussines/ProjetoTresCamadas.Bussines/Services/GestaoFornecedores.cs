using ProjetosTresCamadas.Data.Reposity;
using ProjetosTresCamadas.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ProjetoTresCamadas.Bussines.Services
{
    public class GestaoFornecedores
    {
        private readonly GestaoFornecedoresRepository fornecedoresRepository = new();
        public GestaoFornecedores()
        {
           
        }
        public GestaoFornecedores(GestaoFornecedoresRepository fornecedoresRepository)
        {
            this.fornecedoresRepository = fornecedoresRepository;
        }
        public string SalvarFornecedor(Fornecedor fornecedor)
        {
            var Erro = "Fornecedor salvo com Sucesso!";
            try
            {
                if(fornecedor.Id == 0)
                {
                    fornecedoresRepository.Adicionar(fornecedor);
                }
                else
                {
                    fornecedoresRepository.Editar(fornecedor);
                    Erro = "A edicão do fornecedor no banco de dados foi feita com Sucesso!";
                }
            }
            catch (Exception e)
            {
                Erro = e.Message;
            }
            return Erro;
        }
        public string RemoverFornecedor(Fornecedor fornecedor)
        {
            var Erro = "Fornecedor removido com sucesso do banco de dados!";
            try
            {
                fornecedoresRepository.Excluir(fornecedor);
                fornecedoresRepository.Salvar();
            }
            catch (Exception e)
            {
                Erro = e.Message;
            }
            return Erro;
        }
        public Fornecedor ObterFornecedorPor(Expression<Func<Fornecedor, bool>> predicado)
        {
            return fornecedoresRepository.BuscarPor(predicado).FirstOrDefault();
        }
        public async Task<IList<Fornecedor>> ObterFornecedores()
        {
            return await fornecedoresRepository.ObterTodos();
        }
    }
    
}
