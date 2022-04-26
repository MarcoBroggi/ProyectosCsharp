using System;

namespace Ej20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar(10);
            Euro euro = new Euro(10);
            Peso peso = new Peso(10);
            dolar = dolar - euro;
            Console.WriteLine(dolar.Cantidad);
            peso= peso - dolar;
            Console.WriteLine(peso.Cantidad);
            Euro euro2 = 24.3;
            try
            {
                euro2 = euro2 - dolar;

                Console.WriteLine(euro2.Cantidad);
            }
            catch(ValorInvalidoException e)
            {
                Console.WriteLine(e.Message);
            }

           


        }
    }
}
