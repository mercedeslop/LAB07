using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        private static string cadena = "Server=LAB411-015\\SQLEXPRESS; Database=InvoiceDB; User Id=jennyfer; Password=123456; TrustServerCertificate=true";
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
