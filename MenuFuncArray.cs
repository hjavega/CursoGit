/*Programa realizado por Horacio J. Jávega Gualda para pruebas*/

using System;
using System.Collections.Generic;
using System.Text;
/* Insertar un array de valores básicos y numero de elementos solicitado por consola
 * Mostrar un array de valores básicos
 * sumar los valores de un array de valores básicos
 * Insertar un array de 2 valores de campos de clase (por ejemplo: Nombre y Edad). Simulación de acceso a tabla de base de datos.
 * Mostrar un array de valores de campos de clase
 * Insertar un array de multiples valores de campos de clase
 * Simulación de lectura de una Base de Datos
 * Recorrer array con bucles For
 * Recorrer array con bucle foreach
 */
namespace Ejercicio_Bloque_1
{
    class MenuFuncArray:Menu
    {
        // Declaramos variables 
        

        // Definimos el menú con las opciones a elegir
        public void Menu()
        {
            bool VerMenu = true;
            InsertarValor insertarValor = new InsertarValor();
            while (VerMenu)
            {
                Console.Clear();
                Console.WriteLine("*** Bienvenido al módulo de Vectores y Matrices (Arrays). Elija la opción que desee hacer ***");
                Console.WriteLine("   Opción 1: Insertar un array con valores básicos y número de elementos solicitado por consola, luego mostrar sus valores y la suma total de todos sus valores");
                Console.WriteLine("   Opción 2: Insertar un array de 2 valores de campos de clase (Nombre y Edad). Simulación de acceso a tabla de base de datos.");
                Console.WriteLine("   Opción 3: Insertar un array de 5 valores de campos de clase (Nombre, Apellidos, dirección y DNI). Simulación de acceso a tabla de base de datos.");
                Console.WriteLine("   ... Pulse 0 para salir al menú principal:");
                Console.WriteLine("");
                Console.WriteLine("Opcion: ");

                // Leemos la opción que vamos a introducir
                //int opcion = int.Parse(Console.ReadLine());                
                int opcion = insertarValor.InsertarValorEntero();

                // Instanciamos las clases con 1, 2 y 3 valores
                FuncArray Vector = new FuncArray();
                
                switch (opcion)
                {
                    case 0:
                        break;
                    case 1:                        
                        Vector.InsertarArraySimple();                                               
                        break;

                    case 2:
                        Vector.InsertarArrayDataBase2Valores();                       
                        break;

                    case 3:
                        Vector.InsertarArrayDataBase();
                       
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
