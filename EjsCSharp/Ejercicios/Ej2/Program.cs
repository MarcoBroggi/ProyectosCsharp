using System;


namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            int cuadrado = 0;
            int cubo = 0;
            Console.WriteLine("INgresar numero");

            numero = int.Parse(Console.ReadLine());

            if(numero<0)
            {
                Console.WriteLine("Error numero invalido");
            }
            else
            {
                cuadrado = (int)Math.Pow(numero, 2);
                cubo = (int)Math.Pow(numero, 3);
            }

            Console.WriteLine("Cuadrado: " + cuadrado);
            Console.WriteLine("Cubo: " + cubo);
        }
    }
}
