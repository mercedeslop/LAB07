using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class ProductoDatos
    {
        private string connectionString = "Server=LAB411-015\\SQLEXPRESS;Database=InvoiceDB;User Id=jennyfer;Password=123456; TrustServerCertificate=true";

        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_listar_productos", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Producto
                    {
                        ProductId = Convert.ToInt32(dr["product_id"]),
                        Name = dr["name"].ToString(),
                        Price = Convert.ToDecimal(dr["price"]),
                        Stock = Convert.ToInt32(dr["stock"]),
                        
                    });
                }
            }
            return lista;
        }

    }
}
