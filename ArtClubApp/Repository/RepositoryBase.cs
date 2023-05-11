using ArtClubApp.Data;
using ArtClubApp.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ArtClubApp.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ArtClubContext dbContext { get; set; }
        public RepositoryBase(ArtClubContext _dbContext)
        {
            this.dbContext = _dbContext;
        }
        public IQueryable<T> FindAll()
        {
            return this.dbContext.Set<T>().AsNoTracking();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.dbContext.Set<T>().Where(expression).AsNoTracking();
        }
        public void Create(T entity)
        {
            this.dbContext.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            this.dbContext.Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            this.dbContext.Set<T>().Remove(entity);
        }
    }
}
