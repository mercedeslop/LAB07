using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ProductoNegocio
    {
        private ProductoDatos productoDatos = new ProductoDatos();

        public List<Producto> ListarPorNombre(string nombre)
        {
            
            return productoDatos.Listar()
                                .Where(p => p.Name.Contains(nombre, StringComparison.OrdinalIgnoreCase))
                                .ToList();
        }
    }
}
