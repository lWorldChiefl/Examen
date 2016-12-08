using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiProgramacionWeb.BL.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {

        TEntity GetByIDRepository(int id);
        IEnumerable<TEntity> GetListRepository();
        IEnumerable<TEntity> FindRepository(Expression<Func<TEntity, bool>> predicate);

        void AddRepository(TEntity entity);

        void Updaterepository(TEntity TEntity);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

     
        
    }
}
