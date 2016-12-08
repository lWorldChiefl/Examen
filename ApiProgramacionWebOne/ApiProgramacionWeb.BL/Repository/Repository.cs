/*
 * 
 * CORREGIR LAS REFERENCIAS * 
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Data;
/* -------------- */
using ApiProgramacionWeb.DAL;
using System.Data.Entity;

namespace ApiProgramacionWeb.BL.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly TiendaEntities Context;

        public Repository(TiendaEntities context)
        {
            Context = context;
        }

        public TEntity GetByIDRepository(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetListRepository()
        {
            return Context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> FindRepository(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public void AddRepository(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
           // Context.Set<TEntity>().RemoveRange(entities);
        }

        public void Updaterepository(TEntity TEntity)
        {
            Context.Entry(TEntity).State = EntityState.Modified;
        }

        public bool TryGetId(int Id, out string comment)
        {
            throw new NotImplementedException();
        }
    }
}