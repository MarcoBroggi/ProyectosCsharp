using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaEventos
{
   public class Class1
    {
        //UN evento es como un subtipo del delegado que no se ejecuta on demand como el delegado sino 
        //que se ejecuta como consecuencia de que ocurra otra accion. 

        //Numero al azar para determinar condicion de evento
        Random rand = new Random();
        //Delegado necesario para declarar el evento del tipo del delegado
        public delegate void miDelegado(string mensaje);
        //Nombre de evento
        public event miDelegado miEvento;
        
        //Metodo que ejecuta el evento si se cumple la condicion. 
        public void Metodo()
        {
            if(miEvento!=null && rand.Next(0,2)==1)
            {
                 this.miEvento("El numero es 1");
                
            }
        }

        


    }
}
