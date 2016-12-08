using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ApiProgramacionWeb.DAL
{
    public static class ConexionSqlServer
    {
        /*
         * Crear un metodo de conexion utilizando el Webconfig y las librerias de ConfigurationManger.
         * El Metodo sera statico y regresara la conexion a la BL o Logica de Negocio
         * 
         * */

        public static string ConexionSql()
        {
            var cadenaString = ConfigurationManager.ConnectionStrings["TiendaEntities"].ConnectionString;
            return cadenaString;
        }
    }
}
