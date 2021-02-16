using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Bloque_1
{
    class MenuFuncBucles:Menu
    {
        public void Menu()
        {
            bool VerMenu = true;
            InsertarValor insertarValor = new InsertarValor();
            while (VerMenu)
            {
                Console.Clear();
                Console.WriteLine("*** Bienvenido al módulo de funciones de Bucles. Elija la opción que desee hacer ***");
                Console.WriteLine("   Opción 1: Funcionamiento de bucle While");
                Console.WriteLine("   Opción 2: Funcionamiento de bucle Do - While");
                Console.WriteLine("   Opción 3: Funcionamiento de bucle For");                
                Console.WriteLine("   ... Pulse 0 para salir al menú principal:");
                Console.WriteLine("");
                Console.WriteLine("Opcion: ");

                // Leemos la opción que vamos a introducir
                //int opcion = int.Parse(Console.ReadLine());                
                int opcion = insertarValor.InsertarValorEntero();

                // Instanciamos la clase con los 6 valores                
                FuncBucles Bucles = new FuncBucles();

                switch (opcion)
                {
                    case 0:
                        break;

                    case 1:
                        Bucles.BucleWhile();                                                
                        break;

                    case 2:
                        Bucles.BucleDoWhile();
                        break;

                    case 3:
                        Bucles.BucleFor();
                        break;

                    default:
                        Console.WriteLine("El valor introducido no está dentro del menú");
                        opcion = 1000;
                        break;

                }

                Console.WriteLine("");
                if (opcion != 0) VerMenu = OtraOperacion();    // OtraOperacion es heredada, lo que nos ahorra de meter el código nuevamente o tener que instanciarla.
                else
                {
                    VerMenu = false;
                    Console.Clear();
                }
            }
            MenuGeneral();           // Menu es heredada, lo que nos ahorra de meter el código o tener que instanciarla.
        }
    }
}
