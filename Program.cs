using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
             
            Menu menu = new Menu();
            CarritoDeCompras carrito = new CarritoDeCompras(1000); 
            Console.WriteLine("SHOPPING ONLINE DE CAMISAS - Ventas minoristas y mayoristas .");
            Console.WriteLine("_____________________________________________________________");
            menu.mostrarMenu(carrito);
           
        }
    }
}
