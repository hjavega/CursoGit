using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace Ejercicio_Bloque_1
{
    class FuncCirculo
    {
        private double area, perimetro, diametro, radio;
        
        public FuncCirculo(double radio)
        {
            this.radio = radio;
            area = 0;
            perimetro = 0;
            diametro = 0;           
        }

       
        public void CalculosCirculo()
        {
            area = PI * Pow(radio, 2);
            perimetro = 2 * PI * radio;
            diametro = 2 * radio;
            Console.WriteLine($"El radio del Circulo es: {radio}");
            Console.WriteLine($"El area del Circulo es: {area}");
            Console.WriteLine($"El perímetro del Circulo es: {perimetro}");
            Console.WriteLine($"El diámetro del Circulo es: {diametro}");
            Console.WriteLine("");
        } 


    }
}
