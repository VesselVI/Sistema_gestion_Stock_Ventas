using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_gestion_Stock_Ventas.Classes
{
    internal class Lavarropas : Producto
    {
        public int carga_kg { get; set; }
        public string tipoDeLavarropas { get; set; }

        public override int calcularCuotas(int cuotas)
        {
            throw new NotImplementedException();
        }
    }
}
