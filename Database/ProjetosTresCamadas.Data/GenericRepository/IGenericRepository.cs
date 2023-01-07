using System.Linq.Expressions;


namespace ProjetosTresCamadas.Data.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IList<T>> ObterTodos();
        IQueryable<T> BuscarPor(Expression<Func<T, bool>> predicate);
        void Adicionar(T entity);
        void Excluir(T entity);
        void Editar(T entity);
        void Salvar();
        void Dispose();
    }

}
