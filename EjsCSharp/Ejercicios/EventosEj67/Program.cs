using System;
using System.Threading;
using System.Threading.Tasks;

namespace EventosEj67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public sealed  class Temporizador
    {
        private Thread hilo;
        private int intervalo;

        public bool Activo
        {
            get;set;
        }

        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }

        public delegate void encargadoTiempo(Thread hilo);

        public event encargadoTiempo miEvento;

        private Object bloqueo = new Object();

        public void Corriendo()
        {
            if(this.Activo==true)
            {
                this.Activo = false;
                lock(bloqueo)
                {
                    this.miEvento(this.hilo);
                }
                
            }
            else
            {
                this.hilo.Start();
                this.miEvento(this.hilo);
                
            }


        }

    }
}
