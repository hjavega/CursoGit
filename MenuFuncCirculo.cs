using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Bloque_1
{
    class MenuFuncCirculo:Menu
    {
        double radio;

        public void Menu()
        {
            bool VerMenu = true;
            InsertarValor insertarValor = new InsertarValor();
            while (VerMenu)
            {
                Console.Clear();
                Console.WriteLine("*** Bienvenido al módulo de funciones de la circunferencia ***");
                Console.WriteLine("   Inserte el radio de la circunferencia que quiere calcular");
                Console.WriteLine("   ... Pulse 0 para salir al menú principal:");
                Console.WriteLine("");
                Console.WriteLine("Valor: ");

                // Leemos la opción que vamos a introducir
                //double valor = double.Parse(Console.ReadLine());
                double valor = insertarValor.InsertarValorDecimal();

                Console.WriteLine("");
                if (valor != 0)
                {
                    FuncCirculo circulo = new FuncCirculo(valor);
                    circulo.CalculosCirculo();
                    VerMenu = OtraOperacion();    // OtraOperacion es heredada, lo que nos ahorra de meter el código nuevamente o tener que instanciarla.
                }
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
