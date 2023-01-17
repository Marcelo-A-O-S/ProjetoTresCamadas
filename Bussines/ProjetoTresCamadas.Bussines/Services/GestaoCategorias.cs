

using System.Linq.Expressions;
using ProjetosTresCamadas.Data.Reposity;
using ProjetoTresCamadas.DTO.Entidades;

namespace ProjetoTresCamadas.Bussines.Services
{
    public class GestaoCategorias
    {
        private readonly GestaoCategoriasRepository gestaoCategorias = new();

        public GestaoCategorias()
        {

        }
        public GestaoCategorias(GestaoCategoriasRepository gestaoCategorias)
        {
            this.gestaoCategorias = gestaoCategorias;
        }
        public string SalvarCategoria(Categoria categoria)
        {
            var Erro = "Categoria salva com sucesso!";
            try
            {
                if(categoria.Id == 0)
                {
                    gestaoCategorias.Adicionar(categoria);
                    
                }
                else
                {
                    gestaoCategorias.Editar(categoria);
                    Erro = "Categoria editada com sucesso!";
                }
            }catch(Exception e)
            {
                Erro = e.Message;
            }
            return Erro;
        }
        public string ExcluirCategoria(Categoria categoria)
        {
            var Erro = "Categoria excluida com sucesso!";
            try
            {
                gestaoCategorias.Excluir(categoria);
            }catch(Exception e)
            {
                Erro = e.Message;
            }
            return Erro;
        }
        public async Task<IList<Categoria>> ObterCategorias()
        {
            var categorias = gestaoCategorias.ObterTodos().Result.ToList();
            return categorias;
        }
        public async Task<Categoria> BuscarCategoriaPor(Expression<Func<Categoria, bool>> predicado)
        {
            return await gestaoCategorias.BuscarPor(predicado);
        }
    }
}
