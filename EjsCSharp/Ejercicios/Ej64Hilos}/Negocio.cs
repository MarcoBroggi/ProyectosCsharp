using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej64Hilos_
{
    class Negocio
    {
        private Caja caja1;
        private Caja caja2;

        private List<string> listaClientes;

        public Caja Caja1
        {
            get
            {
                return this.caja1;
            }

        }

        public Caja Caja2
        {
            get
            {
                return this.caja2;
            }

        }

        public List<string> Clientes
        {
            get
            {
                return this.listaClientes;
            }
        }

        /// <summary>
        /// Constructor con 2 parametros que inicializa 2 cajar y la lista de clientes
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        public Negocio(Caja c1, Caja c2)
        {
            c1 = new Caja();
            c2 = new Caja();
            this.listaClientes = new List<string>();
        }

        /// <summary>
        /// Asigna a un cliente a la caja que menor cantidad de clientes tiene en fila 
        /// </summary>
        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas");
            foreach(string s in this.Clientes)
            {
               if(this.caja1.FilaClientes.Count <= this.caja2.FilaClientes.Count)
                {
                    this.caja1.FilaClientes.Add(s);
                }
               else
                {
                    this.caja2.FilaClientes.Add(s);
                }

                Task.Delay(1000);
            }
        }

    }
}
