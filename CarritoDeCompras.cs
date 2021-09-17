using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class CarritoDeCompras
    {
        private int cantidad;
        private int añadirCamisas;
        private double total;
        private double descuento;
        private double precioFinal;
        private readonly double precioUnitarioCamisa;

        public CarritoDeCompras(double precioUnitarioCamisa)
        {
            cantidad = 0;
            añadirCamisas = 0;
            total = 0;
            descuento = 0;
            precioFinal = 0;
            this.precioUnitarioCamisa = precioUnitarioCamisa;

        }

        public void aplicandoDescuento()
        {
            if(cantidad>=3 && cantidad <= 5)
            {
                descuento = 0.1; 
            }

            else if (cantidad > 5)
            {
                descuento = 0.2;
            }

            else
            {
                descuento = 0; 
            }

            precioFinal = total - (total * descuento);


        }




        public int Cantidad {
            get
            {
                return cantidad;

            }

            set
            {
                cantidad = value;
            }
        }


        public double Total
        {
            get
            {
                return total;

            }

            set
            {
                total = value;
            }
        }

        public double Descuento
        {
            get
            {
                return descuento;

            }

            set
            {
                descuento = value;
            }
        }

        public double PrecioFinal
        {
            get
            {
                return precioFinal;

            }

            set
            {
                precioFinal = value;
            }
        }


        public double PrecioUnitarioCamisa
        {
            get
            {
                return precioUnitarioCamisa;
            }


        }


        public int AñadirCamisas{

            get
            {
                return añadirCamisas; 

            }

            set
            {
                añadirCamisas = value;
            }
        }









    }
}
