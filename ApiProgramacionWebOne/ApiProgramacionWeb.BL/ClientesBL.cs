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

namespace ApiProgramacionWeb.BL
{
    public class ClientesBL : Repository<Cliente>
    {
        public ClientesBL(TiendaEntities context)
            : base(context)
        {
        }
   
        public bool GetCliente()
        {
            GetListRepository();
            return true;
        }

        public bool PostCliente(Cliente _cliente)
        {
            // Utilizar el repository para guardar el cliente.
            AddRepository(_cliente);
            return true;
        }
    }
}
