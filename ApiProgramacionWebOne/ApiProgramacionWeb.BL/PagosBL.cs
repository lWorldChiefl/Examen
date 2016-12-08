using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using ApiProgramacionWeb.DAL;
using System.Data.Common;

namespace ApiProgramacionWeb.BL
{
    class PagosBL
    {
        /*
         * 
         * Crear las referencias correspondientes
         * Crear en esta clase todos los Metodos que devuelvan los datos al Controller Pagos
         * Utilizar la clase - ConexionSqlServer - de la DAL o DataAccessLayer para obtener la conexion a BD
         * Para los metodos GetById - Get utilizar Stored Procedures 
         * Con STORED PROCEURE Genarar un Update solo considerando que el Ciente Esta Activo y Que tiene 5 o mas pagos realizados. Caso contrario no actualizar.
         * 
         * */

        private DataTable dt = null;
        private SqlCommand cmd = null;
        private SqlConnection con = null;
        private SqlDataReader dr = null;

        public List<Pago> GetListaDePagos()
        {
            /*          Instancias de objeto             */
            con = new SqlConnection(ConexionSqlServer.ConexionSql());
            dt = new DataTable();
            cmd = new SqlCommand("SELECT * FROM Pagos",con);
            List<Pago> _lstPagos = new List<Pago>();
            
            /// Implementar lo necesaario para conexiones SQL
            con.Open();
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dt.Load(dr);

            foreach (var row in dt.Rows)
            {
                _lstPagos.Add((Pago)row);
            }

            return _lstPagos;
        }
    }
}
