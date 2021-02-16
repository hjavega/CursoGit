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
    class MenuFuncTrigonometricas:Menu
    {
        // Declaramos variables 
        private double a, b, c, A, B, C;
        InsertarValor InsertarValor = new InsertarValor();

        // Definimos el menú con las opciones a elegir
        public void Menu()
        {
            bool VerMenu = true;
            while (VerMenu)
            {
                Console.Clear();
                Console.WriteLine("*** Bienvenido al módulo de funciones Trigonométricas. Elija la opción que desee hacer ***");
                Console.WriteLine("   Opción 1: Resolución de triángulos conociendo un lado y dos ángulos:  1. Se conoce un lado y sus dos ángulos adyacentes");
                Console.WriteLine("   Opción 2: Resolución de triángulos conociendo un lado y dos ángulos: 2. Se conoce un lado, uno de los dos ángulos adyacentes y otro ángulo, el opuesto");
                Console.WriteLine("   Opción 3: Resolución de triangulos conociendo dos lados y un angulo: 1. Se conocen dos lados y el ángulo que forman éstos");
                Console.WriteLine("   Opción 4: Resolución de triangulos conociendo dos lados y un angulo: 2. Se conocen dos lados y un ángulo diferente al que forman éstos");
                Console.WriteLine("   Opción 5: Resolución de triángulos conociendo los tres lados");
                Console.WriteLine("   Opción 6: Resolución de Triangulo Rectangulo conociendo los dos lados que forman el ángulo recto");
                Console.WriteLine("   ... Pulse 0 para salir al menú principal:");
                Console.WriteLine("");
                Console.WriteLine("Opcion: ");

                // Leemos la opción que vamos a introducir
                //int opcion = int.Parse(Console.ReadLine());
                int opcion = InsertarValor.InsertarValorEntero();

                // Instanciamos la clase con los 6 valores                
                FuncTrigonometricas Trigonometrica = new FuncTrigonometricas(a, b, c, A, B, C);
                                
                switch (opcion)
                {
                    case 0:
                        break;

                    case 1:
                        // Lado1AngulosAdyacentes2(double a, double B, double C)
                        IntroducirValoresLado1AngulosAdyacentes2();
                        Console.WriteLine($"El resultado del cálculo del triangulo con lado (a) igual a {a} y Angulos Adyacentes (B) igual a {B} y (C) igual a {C} es: ");
                        Trigonometrica.Lado1AngulosAdyacentes2(a, B, C);
                        break;

                    case 2:
                        // Lado1AnguloAdyacentes1AnguloOpuesto1(double a, double C, double A)
                        IntroducirValoresLado1AnguloAdyacentes1AnguloOpuesto1();
                        Console.WriteLine($"El resultado del cálculo del triangulo con lado (a) igual a {a}, Angulo Adyacente (C) igual a {C} y Angulo Opuesto (A) igual a {A} es: ");
                        Trigonometrica.Lado1AnguloAdyacentes1AnguloOpuesto1(a, C, A);
                        break;

                    case 3:
                        // Lados2AnguloFormanLados1(double a, double b, double C)
                        IntroducirValoresLados2AnguloFormanLados1();
                        Console.WriteLine($"El resultado del cálculo del triangulo con lado (a) igual a {a}, lado (b) igual a {b} y el ángulo que forman estos lados (C) igual a {C} es: ");
                        Trigonometrica.Lados2AnguloFormanLados1(a, b, C);
                        break;

                    case 4:
                        //Lados2AnguloDistintoForman1(double b, double c, double C)
                        IntroducirValoresLados2AnguloDistintoForman1();
                        Console.WriteLine($"El resultado del cálculo del triangulo con lado (b) igual a {b}, lado (c) igual a {c} y el ángulo distinto (C) al que forman estos lados es igual a {C} es: ");
                        Trigonometrica.Lados2AnguloDistintoForman1(b, c, C);
                        break;

                    case 5:
                        // Lados3(double a, double b, double c)
                        IntroducirValoresLados3();
                        Console.WriteLine($"El resultado del cálculo del triangulo con lado (a) igual a {a}, lado (b) igual a {b} y lado (c) igual a {c} es: ");
                        Trigonometrica.Lados3(a, b, c);
                        break;

                    case 6:
                        // trianguloRectangulo(double a, double b)
                        IntroducirValoresTrianguloRectangulo();
                        Console.WriteLine($"El resultado del cálculo del triangulo rectángulo con lado (a) igual a {a} y lado (b) igual a {b} es: ");
                        Trigonometrica.trianguloRectangulo(a, b);
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

        // Lado1AngulosAdyacentes2(double a, double B, double C)
        private void IntroducirValoresLado1AngulosAdyacentes2()
        {
            A = 0;
            c = 0;
            b = 0;
            Console.WriteLine("   Introduzca el valor de un lado (a):");
            //a = double.Parse(Console.ReadLine());
            a = InsertarValor.InsertarValorDecimal();
            Console.WriteLine("   Introduzca el valor de uno de sus lados Adyacentes (B): ");
            //B = double.Parse(Console.ReadLine());
            B = InsertarValor.InsertarValorDecimal();
            Console.WriteLine("   Introduzca el valor del otro lado Adyacente (C): ");
            //C = double.Parse(Console.ReadLine());
            C = InsertarValor.InsertarValorDecimal();
        }

        // Lado1AnguloAdyacentes1AnguloOpuesto1(double a, double C, double A)
        private void IntroducirValoresLado1AnguloAdyacentes1AnguloOpuesto1()
        {            
            B = 0;
            b = 0;
            c = 0;
            Console.WriteLine("   Introduzca el valor de un lado (a):");
            //a = double.Parse(Console.ReadLine());
            a = InsertarValor.InsertarValorDecimal();
            Console.WriteLine("   Introduzca el valor de uno de sus lados Adyacentes (C): ");
            //C = double.Parse(Console.ReadLine());
            C = InsertarValor.InsertarValorDecimal();
            Console.WriteLine("   Introduzca el valor del angulo Opuesto (A): ");
            //A = double.Parse(Console.ReadLine());
            A = InsertarValor.InsertarValorDecimal();
        }

        // Lados2AnguloFormanLados1(double a, double b, double C)
        private void IntroducirValoresLados2AnguloFormanLados1()
        {
            B = 0;
            A = 0;
            c = 0;
            Console.WriteLine("   Introduzca el valor de un lado (a):");
            // a = double.Parse(Console.ReadLine());
            a = InsertarValor.InsertarValorDecimal();
            Console.WriteLine("   Introduzca el valor de otro lado (b): ");
            //b = double.Parse(Console.ReadLine());
            b = InsertarValor.InsertarValorDecimal();
            Console.WriteLine("   Introduzca el valor del angulo (C): ");
            //C = double.Parse(Console.ReadLine());
            C = InsertarValor.InsertarValorDecimal();
        }

        // Lados2AnguloDistintoForman1(double b, double c, double C)
        private void IntroducirValoresLados2AnguloDistintoForman1()
        {
            a = 0;
            A = 0;
            B = 0;
            Console.WriteLine("   Introduzca el valor de un lado (b):");
            //b = double.Parse(Console.ReadLine());
            b = InsertarValor.InsertarValorDecimal();
            Console.WriteLine("   Introduzca el valor de otro lado (c): ");
            //c = double.Parse(Console.ReadLine());
            c = InsertarValor.InsertarValorDecimal();
            Console.WriteLine("   Introduzca el valor del angulo (C): ");
            //C = double.Parse(Console.ReadLine());
            C = InsertarValor.InsertarValorDecimal();
        }

        // Lados3(double a, double b, double c)
        private void IntroducirValoresLados3()
        {            
            A = 0;
            B = 0;
            C = 0;
            Console.WriteLine("   Introduzca el valor de un lado (a):");
            //a = double.Parse(Console.ReadLine());
            a = InsertarValor.InsertarValorDecimal();
            Console.WriteLine("   Introduzca el valor de otro lado (b): ");
            //b = double.Parse(Console.ReadLine());
            b = InsertarValor.InsertarValorDecimal();
            Console.WriteLine("   Introduzca el valor del tercer lado (c): ");
            //c = double.Parse(Console.ReadLine());
            c = InsertarValor.InsertarValorDecimal();
        }

        // trianguloRectangulo(double a, double b)
        private void IntroducirValoresTrianguloRectangulo()
        {
            B = 0;
            A = 0;
            C = 90;
            c = 0;
            Console.WriteLine("   Introduzca el valor de un lado (a):");
            //a = double.Parse(Console.ReadLine());
            a = InsertarValor.InsertarValorDecimal();
            Console.WriteLine("   Introduzca el valor de otro lado (b): ");
            //b = double.Parse(Console.ReadLine());
            b = InsertarValor.InsertarValorDecimal();
        }

    }
}
