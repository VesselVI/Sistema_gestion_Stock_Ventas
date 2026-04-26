using Sistema_gestion_Stock_Ventas.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_gestion_Stock_Ventas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sucursal sucursalNorte = new Sucursal() { nombreSucursal = "Norte" };
            Sucursal sucursalCentro = new Sucursal() { nombreSucursal = "Centro" };

            sucursalCentro.productos.Add(new Televisor() { pulgadas = 55, tipoDePantalla = "LED", precio = "50000", stock = 10 });

            bool exit = false;
            string option;
            while(!exit) {
            
                Console.WriteLine("Seleccione Sucursal:");
                Console.WriteLine();
                Console.WriteLine("1 - Norte");
                Console.WriteLine("2 - Centro");
                
                int opcionSucursal = int.Parse(Console.ReadLine());
                if (opcionSucursal == 0) break;


                exit = true;

            }
            
            
        }
    }
}
