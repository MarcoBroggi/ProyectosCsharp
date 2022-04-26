using System;
using System.Threading.Tasks;

namespace Ej64Hilos_
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1= new Caja();
            Caja caja2= new Caja();


            Negocio negocio = new Negocio(caja1, caja2);

            negocio.Clientes.Add("Cliente1");
            negocio.Clientes.Add("Cliente2");
            negocio.Clientes.Add("Cliente3");
            negocio.Clientes.Add("Cliente4");
            negocio.Clientes.Add("Cliente5");
            negocio.Clientes.Add("Cliente6");
            negocio.Clientes.Add("Cliente7");
            negocio.Clientes.Add("Cliente8");
            negocio.Clientes.Add("Cliente9");

            Task tareaAsignar = new Task(negocio.AsignarCaja);

            Task tareaCaja1 = new Task(caja1.AtenderClientes);

            Task tareaCaja2 = new Task(caja2.AtenderClientes);

            tareaAsignar.Start();

            tareaAsignar.Wait();

            tareaCaja1.Start();
            tareaCaja2.Start();

            Console.WriteLine("Hello World!");



        }
    }
}
