using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiProgramacionWeb.BL;
using ApiProgramacionWeb.DAL;

namespace ApiProgramacionWeb.Controllers
{
    public class ClientesController : ApiController
    {
        private bool ok = false;
        TiendaEntities db = new TiendaEntities();
        ClientesBL _clientesBL = new ClientesBL();
        
        /*
         * ENTITY FRAMEWORK
         * 
         * Corregir y/o agregar referencias y Using's
         * Crear TODAS las operaciones basicas para el Api Clientes
         *  - Post - GetById - Get - UpDate - SaveChanges
         * Utilizar el Repository de la BL o Logica de Negocio, SOLO PARA ENTITY FRAMEWORK
         * 
         * Otros Metodos:
         * Generar un Get que devuelva todos los clientes. el criterio sera regresar Clientes con estado Activo o Inactivo segun el criterio enviado.
         * Generar un Get que devuelva todos los clientes. el criterio sera regresar segun la fecha de pago del mes Actual como criterio enviado.
         * Genarar un Update solo considerando que el Ciente Esta Activo y Que tiene 5 o mas pagos realizados. Caso contrario no actualizar.
         *   el campo a actualizar sera TipoPago = Pagado, en el Pago 5
         * 
         * */

        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var List = _clientesBL.Get();
                return Ok(List);
            }
            catch (Exception)
            {
                return BadRequest(); 
            }           
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var List = _clientesBL.Get();
                return Ok(List);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IHttpActionResult Post(Cliente _cliente)
        {
            try
            {
                _clientesBL.Post(_cliente);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(Cliente _cliente)
        {
            try
            {
                _clientesBL.Delete(_cliente);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IHttpActionResult Update(Cliente _cliente)
        {
            try
            {
                _clientesBL.Update(_cliente);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
