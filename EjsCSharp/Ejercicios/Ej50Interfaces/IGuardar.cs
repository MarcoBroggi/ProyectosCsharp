using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej50Interfaces
{
    public interface IGuardar<T,V>
    {
        
        public void Guardar(T obj,string ruta);

        public V Leer(string ruta);
    }
}
