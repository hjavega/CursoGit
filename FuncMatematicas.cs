using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Math;

/* Haremos las siguientes funciones matemáticas:
 * Suma 2 y 3 números
 * multiplicación 2 y 3 números
 * división de 2 números
 * módulo de una división de 2 número
 * Elevar al cuadrado (potencia) 
 * Raiz cuadrada de un número.
 * Suma de los valores de un array en el cual le pasaremos por teclado el número de valores
 * 
 * Emplearemos básicamente los siguientes conceptos:
 * Clases
 * Métodos
 * Constructores
 * Sobrecarga (2 constructores, 2 funciones, etc...)
 * Encapsulación + uso del this 
 *  
 */
namespace Ejercicio_Bloque_1
{
    class FuncMatematicas
    {
        // Declaramos las variables a utilizar y las encapsulamos (private)
        private double a, b, c;

        // Declaramos los constructores para 1, 2 y 3 valores

        public FuncMatematicas() { }

        public FuncMatematicas(double a)
        {
            this.a = a;
        }
        
        public FuncMatematicas(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public FuncMatematicas(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
                      

        // HACEMOS LAS FUNCIONES

        // Suma 2 Números
        public double Suma(double a, double b)
        {
            return a + b;
        }
        
        // Suma 3 Números
        public double Suma(double a, double b, double c)
        {
            return a + b + c;
        }

        // Multiplicación 2 números
        public double Multiplicacion(double a, double b)
        {
            return a * b;
        }

        // Multiplicación 3 números
        public double Multiplicacion(double a, double b, double c)
        {
            return a * b * c;
        }

        // División de 2 números
        public double Division(double a, double b)
        {
            return a / b;
        }

        // Módulo de una división de 2 número
        public double Modulo(double a, double b)
        {
            return a % b;
        }

        public double ElevarCuadrado(double a)
        {
            return Pow(a, 2);
        }

        public double RaizCuadrada(double a)
        {
            return Sqrt(a);
        }
        
        public int SumaArray(int[] vector)
        {
            int x = 0; ;
            foreach(int contador in vector)
            {
                x = x + contador;
            }
            return x;
        }        
    }
}
