using Microsoft.EntityFrameworkCore;
using ProjetosTresCamadas.Data.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosTresCamadas.Data.GenericRepository
{
    public abstract class GenericRepository<T> : IDisposable, IGenericRepository<T> where T : class
    {
        AppDbContext dbContext = new AppDbContext();

        public void Adicionar(T entity)
        {
            using (var db = new AppDbContext())
            {
                db.Set<T>().Add(entity);
                db.Set<T>().Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
                
            
        }

        public async Task<T> BuscarPor(Expression<Func<T, bool>> predicate)
        {
            using (var db = new AppDbContext())
            {
                IQueryable<T> busca = db.Set<T>().Where(predicate);
                return busca.Where(predicate).FirstOrDefault();
            }
                
        }

        public void Dispose()
        {
            using (var db = new AppDbContext())
            {
                db.Dispose();
            }
                
        }

        public void Editar(T entity)
        {
            using (var db = new AppDbContext())
            {
                db.Set<T>().Update(entity);
                db.Set<T>().Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
                
        }

        public void Excluir(T entity)
        {
            using (var db = new AppDbContext())
            {
                db.Set<T>().Remove(entity);
                db.Set<T>().Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
                
        }

        public async Task<IList<T>> ObterTodos()
        {
            using(var db = new AppDbContext())
            {
                var busca = (IList<T>)db.Set<T>().ToList();
                return busca;
            }
             
        }

        public void Salvar()
        {
            using (var db = new AppDbContext())
            {
                db.SaveChanges();
            } 
        }
    }
}
