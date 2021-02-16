using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Ejercicio_Bloque_1
{
    public class Menu
    {
        public void MenuGeneral()
        {
            Console.WriteLine("****MENÚ GENERAL****");
            Console.WriteLine("Por favor seleccione un valor del 1 al 5:");

            Console.WriteLine("   Opción 1: Funciones matemáticas básicas");
            Console.WriteLine("   Opción 2: Funciones trigonométricas");
            Console.WriteLine("   Opción 3: Funciones sobre el Circulo ");
            Console.WriteLine("   Opción 4: Funciones de bucles");
            Console.WriteLine("   Opción 5: Uso de arrays");
            Console.WriteLine("   ... Pulse 0 para salir del programa");
            Console.WriteLine("");
            Console.WriteLine("Opcion: ");

            InsertarValor insertarValor = new InsertarValor();
            int opcion = insertarValor.InsertarValorEntero();
            /*bool bucleTry = true;
           
            while (bucleTry)
            {
                try
                {
                    opcion = int.Parse(Console.ReadLine());
                    if (opcion > 5)
                    {
                        Console.WriteLine("El valor introducido no corresponde con ninguna de las opciones. Vuelva a insertar un valor");
                        bucleTry = true;
                    }
                    else bucleTry = false;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("El formato introducido no es correcto");
                    Console.WriteLine(ex);
                    Console.WriteLine("Vuelva a insertar un nuevo valor");
                    bucleTry = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);                    
                    Console.WriteLine("Vuelva a insertar un nuevo valor");
                    bucleTry = true;
                }
                
            }
            */
            switch (opcion)
            {
                case 0:
                    break;

                case 1:
                    MenuFuncMatematicas matematicas = new MenuFuncMatematicas();
                    matematicas.Menu();
                    break;

                case 2:
                    MenuFuncTrigonometricas trigonometricas = new MenuFuncTrigonometricas();
                    trigonometricas.Menu();
                    break;

                case 3:
                    MenuFuncCirculo circulo = new MenuFuncCirculo();
                    circulo.Menu();
                    break;

                case 4:
                    MenuFuncBucles bucles = new MenuFuncBucles();
                    bucles.Menu();
                    break;

                case 5:
                    MenuFuncArray arrays = new MenuFuncArray();
                    arrays.Menu();
                    break;

                default:                    
                    Console.WriteLine("El valor introducido no está dentro del menú");
                    MenuGeneral();                    
                    //throw new ArgumentOutOfRangeException();
                    break;
            }
        }

        public bool OtraOperacion()
        {
            Console.WriteLine("¿Desea realizar otra operación? (Pulse 'S' para realizar una nueva operación o 'N' para salir al menú principal");
            string Otra = Console.ReadLine();
            if (Otra == "S" || Otra == "s")
            {
                Console.Clear();
                return true;
            }

            else if (Otra == "N" || Otra == "n")
            {
                Console.Clear();                
                return false;
            }

            else
            {
                Console.WriteLine("No ha introducido uno de los valores esperados, pulse cualquier tecla para volver al menú:");
                Console.ReadLine();
                Console.Clear();
                return true;
            }

        }

    }
}
