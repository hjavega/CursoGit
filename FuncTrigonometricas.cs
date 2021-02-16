using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using static System.Math;

/* Haremos las siguientes funciones matemáticas:
 * Cálculo de triangulos conociendo diferentes valores.
 * 
 * Emplearemos básicamente los siguientes conceptos:
 * Metodos del sistema para funciones matemáticas (using static System.Math;)
 * Clases
 * Métodos
 * Constructores
 * 
 * Encapsulación + uso del this 
 *  
 *  
 */


namespace Ejercicio_Bloque_1
{
    class FuncTrigonometricas
    {
        private double a, b, c, A, B, C, area;

        // Hacemos los constructores
        public FuncTrigonometricas(double a=0, double b=0, double c=0, double A=0, double B=0, double C=0)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.A = A;
            this.B = B;
            this.C = C;
        }      

                

        // Resolución de triángulos conociendo un lado y dos ángulos:  1. Se conoce un lado y sus dos ángulos adyacentes 
        public void Lado1AngulosAdyacentes2(double a, double B, double C)
        {
            // Asignación de variables
            this.a = a;
            this.B = B;
            this.C = C;

            // Cálculo del angulo que falta
            A = 180 - B - C;

            // Cálculo del resto de los lados
            b = (a * Sin(B)) / Sin(A);
            c = (a * Sin(C)) / Sin(A);

            // Cálculo del Área del triangulo
            AreaTriangulo();
            VisualizaDatosTriangulo();
        }

        // Resolución de triángulos conociendo un lado y dos ángulos: 2. Se conoce un lado, uno de los dos ángulos adyacentes y otro ángulo, el opuesto
        public void Lado1AnguloAdyacentes1AnguloOpuesto1(double a, double C, double A)
        {
            // Asignación de variables
            this.a = a;
            this.C = C;
            this.A = A;

            // Cálculo del angulo que falta
            B = 180 - A - C;

            // Cálculo de los lados
            b = (a * Sin(B)) / Sin(A);
            c = (a * Sin(C)) / Sin(A);

            // Cálculo del Área del triangulo
            AreaTriangulo();
            VisualizaDatosTriangulo();
        }

        // Resolución de triangulos conociendo dos lados y un angulo: 1. Se conocen dos lados y el ángulo que forman éstos
        public void Lados2AnguloFormanLados1(double a, double b, double C)
        {
            // Asignación de variables
            this.a = a;
            this.b = b;
            this.C = C;

            // Cálculo del lado desconocido
            c = Sqrt(Pow(a, 2) + Pow(b, 2) - ((2 * a * b) * Cos(C)));

            // Cálculo de los ángulos
            A = Asin((a * Sin(C)) / c);
            A = PasoRadianesGrados(A);            
            B = 180 - A - C;

            // Cálculo del Área del triangulo
            AreaTriangulo();
            VisualizaDatosTriangulo();
        }


        // Resolución de triangulos conociendo dos lados y un angulo: 2. Se conocen dos lados y un ángulo diferente al que forman éstos 
        public void Lados2AnguloDistintoForman1(double b, double c, double C)
        {
            // Asignación de variables
            this.c = c;
            this.b = b;
            this.C = C;

            // Cálculo de angulos
            B = Asin((b * Sin(C)) / c);
            B = PasoRadianesGrados(B);
            A = 180 - B - C;

            // Cáculo del lado desconocido
            a = (b * Sin(A)) / Sin(B);

            // Cálculo del Área del triangulo
            AreaTriangulo();
            VisualizaDatosTriangulo();
        }

        // Resolución de triángulos conociendo los tres lados
        public void Lados3(double a, double b, double c)
        {
            // Asignación de variables
            this.a = a;
            this.b = b;
            this.c = c;

            // Cálculo de ángulos
            A = Acos((Pow(b, 2) + Pow(c, 2) - Pow(a, 2)) / (2 * b * c));
            B = Acos((Pow(a, 2) + Pow(c, 2) - Pow(b, 2)) / (2 * a * c));
            A = PasoRadianesGrados(A);
            B = PasoRadianesGrados(B);
            C = 180 - A - B; 

            // Cálculo del Área del triangulo
            AreaTriangulo();
            VisualizaDatosTriangulo();
        }

        // Calculo del Triangulo Rectangulo conociendo los dos lados que forman el ángulo recto.
        public void trianguloRectangulo(double a, double b)
        {
            this.a = a;
            this.b = b;
            
            C = 90;
            
            // hipotenusa = c;
            double hipotenusa = Sqrt(Pow(a, 2) + Pow(b, 2));
            c = hipotenusa;

            // Cálculo de angulos
            A = Asin(a / hipotenusa) * 180 / PI;
            B = Asin(b / hipotenusa) * 180 / PI;

            area = (a * b) / 2;
            double perímetro = a + b + hipotenusa;
                        
            Console.WriteLine("El lado 'a' tiene un valor de " + a);
            Console.WriteLine("El lado 'b' tiene un valor de " + b);
            Console.WriteLine("La Hipotenusa del triangulo rectangulo es: " + hipotenusa);
            Console.WriteLine("El área del triangulo rectangulo es: " + area);
            Console.WriteLine("El perímetro del triangulo rectangulo es: " + perímetro);
            Console.WriteLine("El valor del ángulo 'A' del triangulo rectangulo es: " + A + "º");
            Console.WriteLine("El valor del ángulo 'B' del triangulo rectangulo es: " + B + "º");
            Console.WriteLine("El valor del ángulo 'C' del triangulo rectangulo es: " + C + "º");
        }

        public double PasoRadianesGrados(double Z)
        {
            return (Z * 180) / PI;
        }


        public double AreaTriangulo()
        {
            area = (1 / 2) * b * c * Sin(A);
            // area = (Pow(a,2) * Sin(B) * Sin(C)) / (2 * Sin(B + C));
            return area;
        }

        public void VisualizaDatosTriangulo()
        {
            Console.WriteLine($"El valor del lado 'a' del triangulo es: {a}");
            Console.WriteLine($"El valor del lado 'b' del triangulo es: {b}");
            Console.WriteLine($"El valor del lado 'c' del triangulo es: {c}");
            Console.WriteLine($"El valor del angulo 'A' del triangulo es: {A}º");
            Console.WriteLine($"El valor del angulo 'B' del triangulo es: {B}º");
            Console.WriteLine($"El valor del angulo 'C' del triangulo es: {C}º");
            Console.WriteLine($"El valor del área del triangulo es: {area}");
        }

        
    }
}
