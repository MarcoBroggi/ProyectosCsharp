using System;
using System.Threading;
using System.Threading.Tasks;

namespace PruebaHilos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 


             Thread t = new Thread(MetodoPrueba);

             Thread t2 = new Thread(MetodoPrueba2);

             t.Start();
            

               //Sincroniza el hilo con el principal. Se vuelven 1 solo hilo 
              // t.Join();


               t2.Start();



               Console.WriteLine("Hello World!");
               Thread.Sleep(1000);
               Console.WriteLine("Hello World!");
               Thread.Sleep(1000);
               Console.WriteLine("Hello World!");*/

            //BLOQUEO DE HILOS 

            /*  CuentaBancaria cuenta = new CuentaBancaria(2000);

              Thread[] hilosPersonas = new Thread[15];

              for(int i=0;i< 15; i++)
              {
                  Thread t = new Thread(cuenta.LLamarASacarPlata);

                  //Le dan nombre a los hilos.
                  t.Name = i.ToString();
                  hilosPersonas[i] = t;
              }
              for (int i = 0; i < 15; i++)
              {


                  hilosPersonas[i].Start();
              }



              */

          /*  //Para ejecutar un hilo cuando termine otro se usa una TaskCompletionSource.
            TaskCompletionSource<bool> tareaTerminada = new TaskCompletionSource<bool>();



            Thread t = new Thread(()=>
            {
                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine("Hilo 1");
                    Thread.Sleep(1000);
                }
                //Al ejecutar este hilo se pone la variable en true
                tareaTerminada.TrySetResult(true);
            });

            Thread t2 = new Thread(() =>
            {
                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine("Hilo 2");
                    Thread.Sleep(1000);
                }
                
            });

            t.Start();
            
            //Comprueba si el hilo termino y si es true ejecuta una vez que el hilo anterior termine.
            var resultado = tareaTerminada.Task.Result;

            //Sincroniza el hilo con el principal. Se vuelven 1 solo hilo 
            // t.Join();

            // Ejecuta al terminae el hilo anterior.
            t2.Start();*/

            //ThreadPool: Sirven para reutilizar hilos cuando sus tareas culminen y no tener que crear otros nuevos.

            for(int i=0; i<=99;i++)
            {
                //El queue user work item recibe si o si un object, por lo que al metodo que recibe le tenemos
                //que pasar un object por parametro.
                ThreadPool.QueueUserWorkItem(Tarea,i);
                //Al tener el mismo hilo haciendo la misma tarea, para diferenciarlas se les asigna el valor de i
                //como segundo parametro.




            }

            Console.ReadLine();

            
        }

        public static void MetodoPrueba()
        {
            Console.WriteLine("Hello World! hilo2");
            Thread.Sleep(1000);
            Console.WriteLine("Hello World! hilo2");
            Thread.Sleep(1000);
            Console.WriteLine("Hello World! hilo2");
        }

        public static void MetodoPrueba2()
        {
            Console.WriteLine("Hello World! hilo3");
            Thread.Sleep(1000);
            Console.WriteLine("Hello World! hilo3");
            Thread.Sleep(1000);
            Console.WriteLine("Hello World! hilo3");
        }

        // Le paso el object para que el trhread pool funcione.
        public static void Tarea(Object o)
        {
            int indice = (int)o;
            Console.WriteLine("Comenzo el thread numero:" + Thread.CurrentThread.ManagedThreadId + "tarea numero:" + indice);

            Thread.Sleep(1000);

            Console.WriteLine("Termino el thread numero" + Thread.CurrentThread.ManagedThreadId + "tarea numero:" + indice);
        }
    }

    public class CuentaBancaria
    {
        //Objeto necesario oara bloquear un hilo. 
        private Object bloqueo = new Object();
        public double saldo;

        public CuentaBancaria(double saldo)
        {
            this.saldo = saldo;
        }

        public double SacarPlata(double plata)
        {
            //Encierra el metodo para que no lo puedan ejecutar los hilos cuando la cuenta no tiene saldo.
            // Dentro del lock va el codigo que no se debe permitir seguir ejecutando.
            lock(bloqueo)
            {
                if (this.saldo >= plata)
                {
                    this.saldo -= plata;

                    Console.WriteLine("Se retiraron :" + plata.ToString());


                }
            }
            
            if(this.saldo<plata)
            {
                Console.WriteLine("No hay suficiente saldo. En el hilo de " + Thread.CurrentThread.Name);
            }

            return this.saldo;
               
        }
        // Se crea un metodo porque en un hilo no se le pueden pasar parametros a los metodos que pasamos en los hilos.
        public void LLamarASacarPlata()
        {
            SacarPlata(500);
        }


       
    }
}
