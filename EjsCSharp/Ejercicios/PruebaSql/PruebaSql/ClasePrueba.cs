using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSql
{
   public class ClasePrueba
    {
        private int id;

        private string asd;

        public int Id
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }

        public string Asd
        {
            set
            {
                this.asd = value;
            }
            get
            {
                return asd;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ID:" + this.Id);
            sb.AppendLine("Nombre: " + this.Asd);
            return sb.ToString();
        }
    }
}
