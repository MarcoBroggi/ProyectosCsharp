using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej64Hilos_
{
    class Caja
    {
        private List<String> filaClientes;

        public List<String> FilaClientes
        {
            set
            {
                this.filaClientes = value;
            }
            get
            {
                return this.filaClientes;
            }
        }

        /// <summary>
        /// Muestra la lista de clientes siendo atendidos y el hilo en que se encuentran
        /// </summary>
        public void AtenderClientes()
        {
            foreach(String s in this.FilaClientes)
            {
                Console.WriteLine("Nombre: "+ s + "En el hilo: " + Task.CurrentId);
                Task.Delay(2000);
            }

        }

        /// <summary>
        /// Constructor por defecto que inicializa la lista de fila de clientes
        /// </summary>
        public Caja()
        {
            this.filaClientes = new List<string>();

            
        }


    }
}
