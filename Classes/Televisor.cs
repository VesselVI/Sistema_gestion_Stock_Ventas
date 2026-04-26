using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_gestion_Stock_Ventas.Classes
{
    internal class Televisor : Producto
    {
        internal string precio;
        internal int stock;

        public int pulgadas { get; set; }
        public string tipoDePantalla { get; set; }

        public override int calcularCuotas(int cuotas)
        {
            throw new NotImplementedException();
        }

    }
}
