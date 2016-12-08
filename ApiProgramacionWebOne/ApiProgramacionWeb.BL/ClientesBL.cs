/*
 * Corregir y/o agregar referencias y Using's
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiProgramacionWeb;
using ApiProgramacionWeb.DAL;
using ApiProgramacionWeb.BL.Repository;
using System.Data.Entity;

namespace ApiProgramacionWeb.BL
{
    public class ClientesBL : Repository<Cliente>
    {

        public IEnumerable<Cliente> Get()
        {
            return Context.Set<Cliente>().ToList();
        }

        public void Post(Cliente entity)
        {
            Context.Set<Cliente>().Add(entity);
        }

        public void Update(Cliente TEntity)
        {
            Context.Entry(TEntity).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void Delete(Cliente entity)
        {
            Context.Set<Cliente>().Remove(entity);
            Context.SaveChanges();
        }

    }
}
