using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_gestion_Stock_Ventas.Classes
{
    public abstract class Producto
    {
        public  string codigo { get; set; }
        public  string nombre { get; set; }
        public  string precio { get; set; }
        public int stock { get; set; }

        public abstract int calcularCuotas(int cuotas);

        

        public override int calculcarCuotas(int cuotas)
        {
            decimal precioDecimal = decimal.Parse(this.precio);
            decimal precioConInteres = precioDecimal * (1 + (0.1m * cuotas));
            return 0;
        }

    }
}
