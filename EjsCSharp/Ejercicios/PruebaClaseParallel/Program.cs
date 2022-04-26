using System;
using System.Threading;
using System.Threading.Tasks;

namespace PruebaClaseParallel
{
    class Program
    {
        //Variable global estatica. No hace falta pasarla por parametro a los metodos que la utilicen.
        private static int acumulador = 0;
        static void Main(string[] args)
        {
            /*
            for(int i=0;i<=99;i++)
            {
                Metodo(i);

                Console.WriteLine("Acumulador vale:"+ acumulador + " y el hilo que hace esta tarea es : " + Thread.CurrentThread.ManagedThreadId);
            }*/

            // Esta sentencia abrevia la sintaxis del bucle for, y lo hace con tareas paralelas.

            Parallel.For(0, 100, Metodo);

        }

        public static void Metodo(int num)
        {
            if(acumulador%2==0)
            {
                acumulador += num;

                Thread.Sleep(100);
            }
            else
            {
                acumulador -= num;

                Thread.Sleep(100);
            }

            Console.WriteLine("Acumulador vale:" + acumulador + " y el hilo que hace esta tarea es : " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
