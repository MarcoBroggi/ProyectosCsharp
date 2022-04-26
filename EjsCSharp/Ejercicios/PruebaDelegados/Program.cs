using System;
using System.Collections.Generic;

namespace PruebaDelegados
{
    class Program
    {

        public delegate void Delegado();
        public delegate double DelegadoLamda(double numero);
        public delegate int DelegadoSuma(int num1, int num2);
        static void Main(string[] args)
        {
            Delegado delegado = new Delegado(Prueba.MetodoQueImprime);



            delegado += Prueba2.Metodo2;

            delegado.Invoke();

            //Expresiones lamda : Funciones sin nombre. EJ: Funcion que hace el cuadrado de un numero
            // No hace falta declarar ni inicializar los parametros

            DelegadoLamda delegadoLamda = new DelegadoLamda(numero => numero * numero);

            //Para que sean 2 parametros se hace asi:


            DelegadoSuma delegadoSuma = new DelegadoSuma((num1, num2) => num1 + num2);

            //Para encontrar los numeros pares de una lista, se usa una expresion lamda para no llamar funciones

            List<int> listaNumeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> numerosPares = listaNumeros.FindAll(i => i % 2 == 0);

            // En una lista se puede hacer un foreach dentro de la lista con un lamda 

            numerosPares.ForEach(numero => Console.WriteLine(numero));

            //Para ejecutar mas lineas de codigo se hace con los metodos entre {} y separados por;

            numerosPares.ForEach(numero => { Console.WriteLine(numero); Console.WriteLine("uwu"); });













        }
    }

    class Prueba
    {
        public static void MetodoQueImprime()
        {
            Console.WriteLine("Este metodo imprime");

        }


    }


    class Prueba2
    {
        public static void Metodo2()
        {
            Console.WriteLine("Metodo 2 de prueba");
        }

    }
}
