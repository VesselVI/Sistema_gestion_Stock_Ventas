using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_gestion_Stock_Ventas.Classes
{
    abstract class Heladera: Producto
    {
        public string capacidadLitros { get; set; }
        public string tipoDeHeladera { get; set; }

        public override int calcularCuotas(int cuotas)
        {
            throw new NotImplementedException();
        }
    }
}
