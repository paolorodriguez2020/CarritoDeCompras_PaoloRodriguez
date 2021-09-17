using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Menu
    {    
        
        private int option = 0; 
        
        public void mostrarMenu(CarritoDeCompras carrito)
        {
            do {

                carrito.aplicandoDescuento();

                Console.WriteLine("");
                Console.WriteLine("MENU PRINCIPAL: ");
                Console.WriteLine("1- Añador camisas al carro de compras. ");
                Console.WriteLine("2- Eliminar Camisas del carro de compras. ");
                Console.WriteLine("3- Salir.");


                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("'     '- Cantidad de camisas en el carro de compras: " + carrito.Cantidad);
                Console.WriteLine("'     '- Precio unitario: " + carrito.PrecioUnitarioCamisa);
                Console.WriteLine("'     '- Precio total sin descuento: $" + carrito.Total);
                Console.WriteLine("'     '- Descuento del: " + (carrito.Descuento*100+"%"));
                Console.WriteLine("'     '- Precio final con descuento: $" + carrito.PrecioFinal);
                Console.WriteLine("Ingrese segun corresponda: ");


                option = int.Parse(Console.ReadLine());
                Console.Clear();


                switch (option)
                {

                    case 1:
                        Console.WriteLine("Introduzca la cantidad de camisas a añadir: ");

                        carrito.AñadirCamisas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Se agregaron " + carrito.AñadirCamisas + " camisas");


                        carrito.Cantidad = carrito.Cantidad + carrito.AñadirCamisas;
                        carrito.Total = carrito.PrecioUnitarioCamisa * carrito.Cantidad;

                        break;

                    case 2:

                        if (carrito.Cantidad > 0)
                        {

                            Console.WriteLine("Introduzca la cantidad de camisas a eliminar:");


                            try
                            {

                                int eliminar = int.Parse(Console.ReadLine());
                                if (eliminar <= carrito.Cantidad && eliminar > 0)
                                {

                                    carrito.Cantidad = carrito.Cantidad - eliminar;
                                    carrito.Total = carrito.Total - (eliminar * carrito.PrecioUnitarioCamisa);
                                }
                                else
                                {

                                    Console.WriteLine("Eror : Fuera de rango.");
                                }
                            }


                            catch (Exception)
                            {


                                Console.WriteLine("* * * Error: Debe ingresar un numero positivo .");


                            }

                        }


                        else
                        {
                            Console.WriteLine("______________________________________");
                            Console.WriteLine("No hay ninguna camisa para eliminar.");
                            Console.WriteLine("______________________________________");
                            Console.WriteLine();
                        }

                        break;

                    case 3:

                        Console.WriteLine("¿Desea Salir? S/N");
                        Console.WriteLine("S = Salir");
                        Console.WriteLine("N = Volver");

                        try
                        {
                            char confirmar = Convert.ToChar(Console.ReadLine()[0]);
                            confirmar = char.ToUpper(confirmar);

                            if (confirmar == 'S')
                            {
                                Console.WriteLine("Saliendo....");
                                Environment.Exit(0); //mas gaimer 
                                //option=3 ;         //menos gaimer

                            }

                            else if (confirmar == 'N')
                            {
                                option = 0;
                            }

                            else
                            {
                                Console.WriteLine("Opcion incorrecta");
                                option = 0;

                            }
                        }

                        catch (NullReferenceException)
                        {
                            Console.WriteLine("Debe ingresar S/N ");
                        }
                        
                        break;


                }

            }while(option != 3) ;

        }
    }   
}
