using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_gestion_Stock_Ventas.Classes
{
    internal class Sucursal
    {
        public string nombreSucursal { get; set; }
        public List<Producto> productos { get; set; } = new List<Producto>();

        public decimal venderProducto(Producto producto, int cantidad)
        {
            if (producto.stock >= cantidad)
            {
                decimal totalVenta = decimal.Parse(producto.precio) * cantidad;
                producto.stock = (producto.stock - cantidad);

                return totalVenta;
            }
            else
            {
                throw new InvalidOperationException("No hay stock suficiente.");
            }
        }

    }
}
