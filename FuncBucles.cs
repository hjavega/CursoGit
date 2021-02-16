using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Bloque_1
{
    class FuncBucles:InsertarValor
    {
        private int i, j;        
        
                        
        public void BucleWhile()
        {
            i = 1;
            long z = 0;            
                        
            Console.WriteLine("Indique un número del 1 hasta el 1000");
            //j = int.Parse(Console.ReadLine());
            j = InsertarValorEntero();
            while (j > 1000)
            {
                 Console.WriteLine("El número introducido es superior a 1000. Por favor, inserte un nuevamente un número del 1 hasta el 1000");
                 j = InsertarValorEntero();
            }
            Console.WriteLine("");
            Console.WriteLine("Muestra los números");

            
            while (i <= j)
            {
                Console.WriteLine($"{i}, ");
                z = z + i;
                i++;
            }
            Console.WriteLine("");
            Console.WriteLine($"La suma de todos los valores mostrados es igual a: {z}");
        }

        public void BucleDoWhile()
        {
            i = 1;
            long z = 0;

            Console.WriteLine("Indique un número del 1 hasta el 1000");
            //j = int.Parse(Console.ReadLine());
            j = InsertarValorEntero();
            while (j > 1000)
            {
                Console.WriteLine("El número introducido es superior a 1000. Por favor, inserte un nuevamente un número del 1 hasta el 1000");
                j = InsertarValorEntero();
            }
            Console.WriteLine("");
            Console.WriteLine("Muestra los números");

            do
            {
                Console.WriteLine($"{i}, ");
                z = z + i;
                i++;

            } while (i <= j);
            
            Console.WriteLine("");
            Console.WriteLine($"La suma de todos los valores mostrados es igual a: {z}");
        }
        
        public void BucleFor()
        {
            i = 1;
            long z = 0;

            Console.WriteLine("Indique un número del 1 hasta el 1000");
            //j = int.Parse(Console.ReadLine());
            j = InsertarValorEntero();

            Console.WriteLine("");
            Console.WriteLine("Muestra los números");

            for (i=1; i<=j; i++)
            {
                Console.WriteLine($"{i}, ");
                z = z + i;                
            }

            Console.WriteLine("");
            Console.WriteLine($"La suma de todos los valores mostrados es igual a: {z}");
        }
        
    }
}
