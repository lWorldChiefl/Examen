﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

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

        public List<Pagos> GetListaDePagos()
        {
            dt = new DataTable();
            cmd = SqlCommand();
            List<Pagos> _lstPagos = new List<Pagos>();

            /// Implementar lo necesaario para conexiones SQL

            foreach (row r in dt.Rows)
            {


                _lstPagos.Add(???);
            }

            return _lstPagos;
        }
    }
}