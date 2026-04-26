using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_gestion_Stock_Ventas.Classes
{
    public abstract class Producto
    {
        public abstract string codigo { get; set; }
        public abstract string nombre { get; set; }
        public abstract string precio { get; set; }
        public abstract int stock { get; set; }

        public abstract int calcularCuotas(int cuotas);

    }
}
