using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej20
{
    class Dolar : Dinero
    {
        
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private Dolar()
        {
            this.CotizRespectoDolar = 1;
        }

        /// <summary>
        /// Constructor con un parametro
        /// </summary>
        /// <param name="cantidad"></param>
        public Dolar(double cantidad) : this()
        {
            this.Cantidad = cantidad;
        }

        
        /// <summary>
        /// Sobrecarga del operador euro que convierte un valor en dolares a un valor en euros
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Euro(Dolar d)
        {
            Euro e = new Euro(d.Cantidad);
            e.Cantidad = e.Cantidad / e.CotizRespectoDolar;
            return e;
        }
        /// <summary>
        /// Sobrecarga del operador peso que convierte un valor en dolares a un valor en pesos
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Peso(Dolar d)
        {
            Peso p = new Peso(d.Cantidad);
            p.Cantidad = p.Cantidad * p.CotizRespectoDolar;
            return p;
        }

        /// <summary>
        /// Sobrecarga del operador Dolar que crea un objeto de tipo Dolar
        /// </summary>
        /// <param name="d"></param>
        public static implicit operator Dolar(double d)
        {
            Dolar dolar = new Dolar(d);
            return dolar;
        }
        /// <summary>
        /// Sobrecarga del operador == para comprarar un objeto Dolar con un Euro
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator ==(Dolar d,Euro e)
        {
            if(d.Cantidad==(e.Cantidad*e.CotizRespectoDolar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Sobrecarga del operador != para comprarar un objeto Dolar con un Euro
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        /// <summary>
        /// Sobrecarga del operador == para comprarar dos objetos de tipo Dolar
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            if (d1.Cantidad == d2.Cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Sobrecarga del operador != para comprarar dos objetos de tipo Dolar
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        /// <summary>
        /// Sobrecarga del operador == para comprarar un objeto de tipo DOlar con uno de tipo Peso
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static bool operator ==(Dolar d, Peso p)
        {
            if (d.Cantidad == (p.Cantidad / p.CotizRespectoDolar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Sobrecarga del operador != para comprarar un objeto de tipo Dolar con uno de tipo Peso
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }

        /// <summary>
        /// Sobrecarga del operador + que suma al valor de un objeto Dolar el valor de un Euro
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static Dolar operator + (Dolar d,Euro e)
        {
          return  d.Cantidad + (e.Cantidad * e.CotizRespectoDolar);
        }

        /// <summary>
        /// Sobrecarga del operador + que suma al valor de un objeto Dolar el valor de un Peso
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Dolar operator +(Dolar d, Peso p)
        {
            return d.Cantidad + (p.Cantidad / p.CotizRespectoDolar);
        }

        /// <summary>
        /// Sobrecarga del operador - que resta al valor de un objeto Dolar el valor de un Euro
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static Dolar operator -(Dolar d, Euro e)
        {
            return d.Cantidad - (e.Cantidad * e.CotizRespectoDolar);
        }
        /// <summary>
        /// Sobrecarga del operador - que resta al valor de un objeto Dolar el valor de un Peso
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Dolar operator -(Dolar d, Peso p)
        {
            return d.Cantidad - (p.Cantidad / p.CotizRespectoDolar);
        }


    }
}
