using System;
using System.Collections.Generic;
using System.Text;

/* Emplearemos básicamente los siguientes conceptos:
 * Clases
 * Instanciar clases
 * Llamadas a métodos de la clase y de otras.
 * Métodos
 * Uso de While
 * Uso de Switch
 * Uso de IF - ELSE  
 * Modularización (optimización de código)
 * Herencia
 */
namespace Ejercicio_Bloque_1
{
    class MenuFuncMatematicas:Menu
    {
        // Declaramos variables 
        private double a, b, c;
        InsertarValor InsertarValor = new InsertarValor();

        // Definimos el menú con las opciones a elegir
        public void Menu()
        {
            bool VerMenu = true;
            while (VerMenu)
            {
                Console.Clear();
                Console.WriteLine("*** Bienvenido al módulo de funciones matemáticas. Elija la opción que desee hacer ***");
                Console.WriteLine("   Opción 1: Sumar 2 valores");
                Console.WriteLine("   Opción 2: Sumar 3 valores");
                Console.WriteLine("   Opción 3: Multiplicar 2 valores");
                Console.WriteLine("   Opción 4: Multiplicar 3 valores");
                Console.WriteLine("   Opción 5: Dividir 2 valores");
                Console.WriteLine("   Opción 6: Calcular el módulo de la división de 2 valores");
                Console.WriteLine("   Opción 7: Calcular el cuadrado de un número");
                Console.WriteLine("   Opción 8: Calcular la raiz cuadrada de un número");
                Console.WriteLine("   Opción 9: Sumar todos los valores de un array");
                Console.WriteLine("   ... Pulse 0 para salir al menú principal:");
                Console.WriteLine("");
                Console.WriteLine("Opcion: ");

                // Leemos la opción que vamos a introducir
                //int opcion = int.Parse(Console.ReadLine());
                int opcion = InsertarValor.InsertarValorEntero();
                
                // Instanciamos las clases con 1, 2 y 3 valores
                FuncMatematicas Matematica1 = new FuncMatematicas(a);
                FuncMatematicas Matematica2 = new FuncMatematicas(a, b);
                FuncMatematicas Matematica3 = new FuncMatematicas(a, b, c);

                switch (opcion)
                {
                    case 0:
                        break;
                    case 1:
                        IntroducirValores2();
                        Console.WriteLine($"El resultado de la operación {a} + {b} = " + Matematica2.Suma(a, b));
                        break;

                    case 2:
                        IntroducirValores3();
                        Console.WriteLine($"El resultado de la operacion {a} + {b} + {c} = " + Matematica3.Suma(a, b, c));
                        break;

                    case 3:
                        IntroducirValores2();
                        Console.WriteLine($"El resultado de la operación {a} * {b} = " + Matematica2.Multiplicacion(a, b));
                        break;

                    case 4:
                        IntroducirValores3();
                        Console.WriteLine($"El resultado de la operación {a} * {b} * {c} = " + Matematica3.Multiplicacion(a, b, c));
                        break;

                    case 5:
                        IntroducirValores2();
                        Console.WriteLine($"El resultado de la operacion {a} / {b} = " + Matematica2.Division(a, b));
                        break;

                    case 6:
                        IntroducirValores2();
                        Console.WriteLine($"El resultado del módulo (resto) de la operación {a} / {b} es: " + Matematica2.Modulo(a, b));
                        break;

                    case 7:
                        IntroducirValores1();
                        Console.WriteLine($"El resultado de elevar al cuadrado el valor {a} es: " + Matematica1.ElevarCuadrado(a));
                        break;

                    case 8:
                        IntroducirValores1();
                        Console.WriteLine($"El resultado de hacer la Raiz Cuadrada del valor {a} es: " + Matematica1.RaizCuadrada(a));
                        break;

                    case 9:
                        FuncMatematicas Matematica0 = new FuncMatematicas();
                        FuncArray funcArray = new FuncArray();
                        int z = funcArray.NumeroElementosArray();
                        int[] vector = new int[z];
                        vector = funcArray.InsertarArraySimple(z);                        
                        Console.WriteLine($"El resultado de Sumar todos los valores del Array es: " + Matematica0.SumaArray(vector));
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


        // Damos de alta las clases que nos proporcionan los valores de las variables

        private void IntroducirValores1()
        {
            Console.WriteLine("   Introduzca el valor:");
            //a = double.Parse(Console.ReadLine());
            a = InsertarValor.InsertarValorDecimal();
        }

        private void IntroducirValores2()
        {
            Console.WriteLine("   Introduzca el primer valor (a):");
            //a = double.Parse(Console.ReadLine());
            a = InsertarValor.InsertarValorDecimal();
            Console.WriteLine("   Introduzca el segundo valor (b):");
            //b = double.Parse(Console.ReadLine());            
            b = InsertarValor.InsertarValorDecimal();
        }

        private void IntroducirValores3()
        {
            Console.WriteLine("   Introduzca el primer valor (a):");
            //a = double.Parse(Console.ReadLine());
            a = InsertarValor.InsertarValorDecimal();
            Console.WriteLine("   Introduzca el segundo valor (b):");
            //b = double.Parse(Console.ReadLine());
            b = InsertarValor.InsertarValorDecimal();
            Console.WriteLine("   Introduzca el tercer valor (c):");
            //c = double.Parse(Console.ReadLine());
            c = InsertarValor.InsertarValorDecimal();
        }
    }
}
