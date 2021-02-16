using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
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
    class FuncArray:InsertarValor
    {
        public int NumeroElementosArray()
        {
            Console.WriteLine("Inserte el número de Elementos del Array");
            //int i = int.Parse(Console.ReadLine());
            int i = InsertarValorEntero();
            return i;
        }

        public void InsertarArraySimple()
        {
            int z = NumeroElementosArray();
            int[] ArraySimple = new int[z];

            // Inserción con el bucle con un "for"
            for(int i=0; i < z; i++)
            {
                Console.WriteLine($"Inserte el valor {i} del array: ");
                //ArraySimple[i] = int.Parse(Console.ReadLine());
                ArraySimple[i] = InsertarValorEntero();
            }
            VisualizarArraySimple(ArraySimple);            
        }

        public int[] InsertarArraySimple(int z)
        {
            int[] ArraySimple = new int[z];

            // Inserción con el bucle con un "for"
            for (int i = 0; i < z; i++)
            {
                Console.WriteLine($"Inserte el valor {i} del array: ");
                //ArraySimple[i] = int.Parse(Console.ReadLine());
                ArraySimple[i] = InsertarValorEntero();
            }
            return ArraySimple;
        }

        public void VisualizarArraySimple(int[] ArraySimple)
        {
            // Inserción con el bucle con un "for"
            Console.WriteLine("Visualización mediante bucle for:");
            for (int i = 0; i < ArraySimple.Length; i++)
            {
                Console.WriteLine($"Posición[{i}]= {ArraySimple[i]}");
            }
            Console.WriteLine("");

            // Inserción con el bucle con un "foreach" (hace lo mismo que el anterior)
            Console.WriteLine("Visualización mediante bucle foreach:");
            int j = 0;
            foreach (int ContadorA in ArraySimple)
            {                          
                //Console.WriteLine(ContadorA);
                Console.WriteLine($"Posición[{j}]= {ContadorA}");
                j++;
            }            
        }

        public void InsertarArrayDataBase2Valores()
        {            
            DataBase2Valores[] dataBases2Valores = new DataBase2Valores[NumeroElementosArray()];
            string nombre;
            int edad;
            // Inserción con un for
            for (int z = 0; z < dataBases2Valores.Length; z++)
            {
                Console.WriteLine($"   Inserte el nombre del elemento {z}: ");
                nombre = Console.ReadLine();
                Console.WriteLine($"   Inserte la Edad del elemento {z}: ");
                //edad = int.Parse(Console.ReadLine());
                edad = InsertarValorEntero();
                dataBases2Valores[z] = new DataBase2Valores(nombre, edad);                
            }
            VisualizarArrayDataBase2Valores(dataBases2Valores);
        }

        public void VisualizarArrayDataBase2Valores(DataBase2Valores[] dataBases2Valores)
        {
            /*
            for (int i = 0; i < dataBases.Length; i++)
            {
                Console.WriteLine($"Posicion[{i}] = <{dataBases.}>");
            }
            */
            int i = 0;
            foreach (DataBase2Valores contador in dataBases2Valores)
            {
                Console.WriteLine($"Posicion[{i}] = <{contador.getNombre}, {contador.getEdad}>");
                i++;
            }
        }

        public void InsertarArrayDataBase()
        {
            // Necesitamos saber cuantos elementos tendrá el array
            int z = NumeroElementosArray();

            // Declaramos el array del tipo 
            DataBase[] dataBases = new DataBase[z];

            // Vamos insertando valores en el array
            int i = 0;
            string Nombre;
            string Apellido1;
            string Apellido2;
            string Direccion;
            string DNI;
            
            foreach (DataBase contador in dataBases)
            {
                // En este punto no sabemos como poder usar el metodo Set para introducir los valores dentro del array. Comprobar funcionalidad

                if (i == 0) Console.WriteLine("Vamos a comenzar a insertar valores");
                else Console.WriteLine("Vamos a insertar los valores de un nuevo registro");
                Console.WriteLine("");
                Console.WriteLine($" Introduzca el Nombre de la posición [{i}]: ");
                Nombre = Console.ReadLine();                
                Console.WriteLine($" Introduzca el Primer Apellido de la posición [{i}]: ");
                Apellido1 = Console.ReadLine();
                Console.WriteLine($" Introduzca el Segundo Apellido de la posición [{i}]: ");
                Apellido2 = Console.ReadLine();
                Console.WriteLine($" Introduzca la Dirección completa de la posición [{i}]: ");
                Direccion = Console.ReadLine();
                Console.WriteLine($" Introduzca el DNI de la posición [{i}]:");
                DNI = Console.ReadLine();
                dataBases[i] = new DataBase(Nombre, Apellido1, Apellido2, Direccion, DNI);
                i++;
                Console.WriteLine("");
            }

            // Llamamos al método correspondiente para visualizar el array que hemos definido
            int opcion;
            string opcionSN = "x";
            bool bucleMenu = true;
            bool bucleSN = true;
            
            // Hacemos el bucle para volver a visualizar los datos del array.
            while (bucleMenu)
            {
                Console.WriteLine("¿Como Desea visualizar los datos del array?:");
                Console.WriteLine("     1.- Mostrar todos los datos del array");
                Console.WriteLine("     2.- Mostrar una posición del array en concreto");
                Console.WriteLine("           Pulse '0' para salir y no ver ningún registro");
                // opcion = int.Parse(Console.ReadLine());
                opcion = InsertarValorEntero();

                if (opcion == 1)
                {
                    VisualizarArrayDataBase(dataBases);
                    bucleSN = true;
                }
                else if (opcion == 2)
                {
                    Visualiza1ValorArrayDataBase(dataBases);
                    bucleSN = true;
                }
                else if (opcion == 0) bucleMenu = false;
                else
                {
                    Console.WriteLine("El numero introducido no es correcto. Vuelva a intentarlo.");
                    Console.WriteLine("");
                }
                                
                while (bucleSN)
                {
                    if (opcion == 1 || opcion == 2) Console.WriteLine("¿Desea visualizar nuevamente valores del array? Pulse 'S' para Si o 'N' para No");
                    opcionSN = (Console.ReadLine());
                    if (opcionSN == "S" || opcionSN == "s") bucleSN = false;
                    else if (opcionSN == "N" || opcionSN == "n")
                    {
                        bucleMenu = false;
                        bucleSN = false;
                    }
                    else
                    {
                        Console.WriteLine("No ha pulsado una opción correcta. Vuelva a intentarlo");
                        bucleSN = true;
                    }
                }
            }
        }

        public void VisualizarArrayDataBase(DataBase[] dataBases)
        {
            int i = 0;
            foreach (DataBase contador in dataBases)
            {
                Console.WriteLine($" El registro de la posición [{i}] de la base de datos es:");
                Console.WriteLine($"      <Nombre: {contador.getNombre}>");
                Console.WriteLine($"      <Primer Apellido: {contador.getApellido1}>");
                Console.WriteLine($"      <Segundo Apellido: {contador.getApellido2}>");
                Console.WriteLine($"      <Dirección: {contador.getDireccion}>");
                Console.WriteLine($"      <DNI: {contador.getDNI}>");
                Console.WriteLine("");
                i++;
            }
        }

        public void Visualiza1ValorArrayDataBase(DataBase[] dataBases)
        {
            // Pedimos el número de registro que queremos visualizar.
            Console.WriteLine("Inserte el número de registro que quiere visualizar :");
            // int i = int.Parse(Console.ReadLine());
            int i = InsertarValorEntero();

            // Declaramos un valor concreto de la base de datos
            DataBase datos;
            datos = dataBases[i];

            // Mostramos los datos del registro seleccionado.
            Console.WriteLine($" El registro de la posición [{i}] de la base de datos es:");
            Console.WriteLine($" <Nombre: {datos.getNombre}>");
            Console.WriteLine($" <Primer Apellido: {datos.getApellido1}>");
            Console.WriteLine($" <Segundo Apellido: {datos.getApellido2}>");
            Console.WriteLine($" <Dirección: {datos.getDireccion}>");
            Console.WriteLine($" <DNI: {datos.getDNI}>");            
        }
                    
    }

    class DataBase2Valores
    {
        // Declaramos las variables privadas (Encapsulamiento)
        private string Nombre;
        private int Edad;
                
        // Definimos sus metodos de acceso Set y Get para encapsular
        public string getNombre { get => Nombre; set => Nombre = value; }
        public int getEdad { get => Edad; set => Edad = value; }

        // Generamos el constructor
        public DataBase2Valores(String Nombre, int Edad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
        }
    }

    class DataBase
    {
        // Declaramos las variables privadas (Encapsulamiento)
        private string Nombre;
        private string Apellido1;
        private string Apellido2;
        private string Direccion;
        private string DNI;

        // Definimos sus metodos de acceso Set y Get para encapsular
        public string getNombre { get => Nombre; set => Nombre = value; }
        public string getApellido1 { get => Apellido1; set => Apellido1 = value; }
        public string getApellido2 { get => Apellido2; set => Apellido2 = value; }
        public string getDireccion { get => Direccion; set => Direccion = value; }
        public string getDNI { get => DNI; set => DNI = value; }

        // Generamos el constructor
        public DataBase(string Nombre, string Apellido1, string Apellido2, string Direccion, string DNI)
        {
            this.Nombre = Nombre;
            this.Apellido1 = Apellido1;
            this.Apellido2 = Apellido2;
            this.Direccion = Direccion;
            this.DNI = DNI;
        }
    }


}
