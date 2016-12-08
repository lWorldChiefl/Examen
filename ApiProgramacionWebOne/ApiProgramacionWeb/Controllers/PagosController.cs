using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiProgramacionWeb.Controllers
{
    public class PagosController : ApiController
    {
        /*
       * 
       * ConexionSqlServer Class
       * 
       * Crear operaciones para las operaciones de API se conecten con la BD
       *    - Post - GetById - Get - UpDate - Delete - SaveChanges
       * Para los metodos GetById - Get utilizar Stored Procedures
       * 
       * Otros Metodos:
       * Generar un Get que devuelva todos los clientes. el criterio sera regresar Activo o Inactivo segun se seleccione.
       * Generar un Get que devuelva todos los clientes. el criterio sera regresar segun la fecha de pago seleccionada
       * Con STORED PROCEURE Genarar un Update solo considerando que el Ciente Esta Activo y Que tiene 5 o mas pagos realizados. Caso contrario no actualizar.
       *    el campo a actualizar sera TipoPago = Pagado, en el Pago 5
       * 
       * 
       * */
    }
}
