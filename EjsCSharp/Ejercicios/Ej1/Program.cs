using System;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar 5 numeros: ");

            int numero;
            int max=0;
            int min=0;
            int flag = 0;
            double promedio=0;
            int i = 0;

           while(i<=4)
            {
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (flag == 0)
                    {
                        min = numero;
                        max = numero;
                        flag++;
                    }
                    if(numero<min)
                    {
                        min = numero;
                    }
                    if(numero>max)
                    {
                        max = numero;
                    }

                    promedio += numero;
                    i++;
                }
            }

            Console.WriteLine("El numero maximo es: " + max);
            Console.WriteLine("El numero minimo es: " + min);
            Console.WriteLine("El numero promedio es: " + promedio/5);









        }
    }
}
