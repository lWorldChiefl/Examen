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

        public Repository()
        {
            Context = new TiendaEntities();
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
            Context.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            Context.SaveChanges();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
           Context.Set<TEntity>().RemoveRange(entities);
           Context.SaveChanges();
        }

        public void Updaterepository(TEntity TEntity)
        {
            Context.Entry(TEntity).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public bool TryGetId(int Id, out string comment)
        {
            throw new NotImplementedException();
        }
    }
}