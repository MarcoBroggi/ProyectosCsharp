using System;
using Moneda;
namespace ConsolaMoneda
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro eu = new Euro(100);

            Console.WriteLine(eu.Cantidad);
            Console.WriteLine(eu.CotizRespectoDolar);





                
        }
    }
}
