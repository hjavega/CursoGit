using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Bloque_1
{
    class InsertarValor
    {
        private int i;
        private double x;
     /*   public InsertarValor(int i)
        {
            this.i = i;
        }

        public InsertarValor(double x)
        {
            this.x = x;
        }
     */

        // Esta funcion la vamos a utilizar para que todos los valores de tipo "int" se inserten correctamente, controlando las excepciones
        public int InsertarValorEntero()
        {
            int opcion = 0;
            bool bucleTry = true;
            while (bucleTry)
            {
                try
                {
                    opcion = int.Parse(Console.ReadLine());
                    bucleTry = false;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("El formato introducido no es correcto");
                    Console.WriteLine(ex);
                    Console.WriteLine("");
                    Console.WriteLine("Vuelva a insertar un nuevo valor");
                    bucleTry = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine("Vuelva a insertar un nuevo valor");
                    bucleTry = true;
                }

            }
            return opcion;
        }

        // Esta funcion la vamos a utilizar para que todos los valores de tipo "double" se inserten correctamente, controlando las excepciones
        public double InsertarValorDecimal()
        {
            double opcion = 0.0;
            bool bucleTry = true;
            while (bucleTry)
            {
                try
                {
                    opcion = double.Parse(Console.ReadLine());
                    bucleTry = false;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("El formato introducido no es correcto");
                    Console.WriteLine(ex);
                    Console.WriteLine("");
                    Console.WriteLine("Vuelva a insertar un nuevo valor");
                    bucleTry = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine("Vuelva a insertar un nuevo valor");
                    bucleTry = true;
                }
            }
            return opcion;

        }
    }
}
