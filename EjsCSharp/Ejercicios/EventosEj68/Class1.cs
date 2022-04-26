using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosEj68
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        private string apellido;
        private string nombre;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        /// <summary>
        /// Crea una cadena con el nombre y apellido de la persona
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Apellido:" + this.Apellido);
            return sb.ToString();
        }

        /// <summary>
        /// Constructor por defecto que inicializa ambas cadenas vacias
        /// </summary>
       public Persona()
        {
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
        }

        public event DelegadoString EventoString;

        /// <summary>
        /// Compara el nombre y el apellido pasados por parametros con los que estan cargados y si son diferentes
        /// lanza el evento correspondiente al cambio de usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public void MostrarEvento(string nombre, string apellido)
        {
            if(this.EventoString!=null && nombre!= this.Nombre && apellido!= this.Apellido)
            {
                this.EventoString("El usuario cambio.");
            }
            
        }


    }
}
