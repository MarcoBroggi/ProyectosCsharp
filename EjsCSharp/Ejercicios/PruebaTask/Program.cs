using System;
using System.Threading;
using System.Threading.Tasks;

namespace PruebaTask
{
    class Program
    {
        private static int acumulador = 0;

        static void Main(string[] args)
        {
            /*
            // Se declara la tarea
            Task tarea = new Task(Tarea);

            //Comienza la tarea
            tarea.Start();

            //Se puede abreviar con la siguiente linea:
            // Task tarea=Task.Run(()=>Tarea());  Se crea la instancia y corre sin necesidad de usar el start.



            /* Task tarea2 = new Task(TareaOtra);
             tarea2.Start();

            Task tarea2 = tarea.ContinueWith(TareaOtra);
            */

            /*  HacerTodas();
              Console.ReadLine();*/

            //Cancelar tasks: para cancelarlas se necesita un cancelation token.

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            CancellationToken cancellationToken = cancellationTokenSource.Token;


            Task tarea = Task.Run(() => Metodo(cancellationToken));

            for(int i=0;i<=99;i++)
            {
                acumulador += 30;

                Thread.Sleep(1000);

                if(acumulador>100)

                {

                    cancellationTokenSource.Cancel();

                    break;
                }
            }

            Thread.Sleep(1000);

            Console.WriteLine("Valor acumulador: "+ acumulador);


            Console.ReadLine();

        }


        //Se ejecutan las 3 al mismo tiempo entrelazandose entre si
        /* public static void HacerTodas()
         {

             Task tarea =  Task.Run(() => Tarea());
             Task tarea2 = Task.Run(() => Tarea2());
             Task tarea3= Task.Run(() => Tarea3());


         }*/

        public static void HacerTodas()
        {

            Task tarea = Task.Run(() => Tarea());

            //Con Wait obligamos a que para seguir, la tarea este terminada. Una vez temrine, se ejecutan las 
            //siguientes.
            tarea.Wait();

            Task tarea2 = Task.Run(() => Tarea2());

            // Para ejecutar las 3, se espera que terminen las tareas pasadas por paranetros.
           // Task.WaitAll(tarea, tarea2);

            //Task.WaitAny(tarea, tarea2);  Con wait any a diferencia de la anterior espera a que cualquiera de 
            //las tareas pasadas por parametros termine para ejecutar las restantes.


            Task tarea3 = Task.Run(() => Tarea3());
            
            

        }
        public static void Tarea()
        {
           for(int i=0;i<=9;i++)
            {
                int numeroHilo = Thread.CurrentThread.ManagedThreadId;


                Thread.Sleep(1000);

                Console.WriteLine("Este ciclo es el hilo numero:" + numeroHilo + " es tarea 1");

            }
        }

        //Para hacer una tarea se inicie cuando otra termina, hay que pasarle al metodo que ejecuta la segunda tarea
        //un objeto task para que lo reconozca. Ese task es la tarea finalizada anterior. El pasaje es implicito 
        //por lo que no hay que pasarle por parametro la task anterior en la llamada.
        public static void TareaOtra(Task Objeto)
        {
            for (int i = 0; i <= 9; i++)
            {
                int numeroHilo = Thread.CurrentThread.ManagedThreadId;


                Thread.Sleep(1000);

                Console.WriteLine("Este ciclo es el hilo numero:" + numeroHilo + 
                    "y es otra tarea");

            }
        }

        public static void Tarea2()
        {
            for (int i = 0; i <= 9; i++)
            {
                int numeroHilo = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(500);

                Console.WriteLine("Este ciclo es el hilo numero:" + numeroHilo + "es la tarea 2");

            }
        }

        public static void Tarea3()
        {
            for (int i = 0; i <= 9; i++)
            {
                int numeroHilo = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(500);

                Console.WriteLine("Este ciclo es el hilo numero:" + numeroHilo+"es la tarea 3");

            }
        }

        public static void Metodo(CancellationToken cancel)
        {
            for (int i = 0; i <= 99; i++)
            {
                acumulador += i;

                int numHilo = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(100);

                Console.WriteLine("Acumulador : "+acumulador+" en el hilo : " + numHilo);

                if(cancel.IsCancellationRequested)
                {
                    //Se resetea si se pasa de 100
                    acumulador = 0;
                    return;
                }
            }
        }
    }
}
