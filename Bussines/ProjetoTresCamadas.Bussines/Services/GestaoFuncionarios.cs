using ProjetosTresCamadas.Data.Entidades;
using ProjetosTresCamadas.Data.Reposity;
using System.Linq.Expressions;

namespace ProjetoTresCamadas.Bussines.Services
{
    public class GestaoFuncionarios
    {
        private readonly GestaoFuncionarioRepository GestaoFuncionarioRepository = new();
        public GestaoFuncionarios()
        {
            
        }
        public GestaoFuncionarios(GestaoFuncionarioRepository gestaoFuncionarioRepository)
        {
            GestaoFuncionarioRepository = gestaoFuncionarioRepository;
        }

        public string SalvarFuncionario(Funcionario funcionario)
        {
            var Erro = "Funcionário salvo com Sucesso";
            try
            {
                if(funcionario.Id == 0)
                {
                    GestaoFuncionarioRepository.Adicionar(funcionario);
                }
                else
                {
                    GestaoFuncionarioRepository.Editar(funcionario);
                }
            }
            catch (Exception e)
            {
                Erro = e.Message;
            }
            return Erro;
        }
        public string RemoverFuncionario(Funcionario funcionario)
        {
            var Erro = "Funcionário removido com Sucesso";
            try
            {
                GestaoFuncionarioRepository.Excluir(funcionario);
                GestaoFuncionarioRepository.Salvar();
            }
            catch (Exception e)
            {
                Erro = e.Message;
            }
            return Erro;
        }
        public async Task<IList<Funcionario>> ObterFuncionarios()
        {
            return await GestaoFuncionarioRepository.ObterTodos();
        }
        public Funcionario BuscarFuncionarioPor(Expression<Func<Funcionario, bool>> predicado)
        {
            return GestaoFuncionarioRepository.BuscarPor(predicado).FirstOrDefault();
        }
    }
}
