using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej20
{
    class Peso : Dinero
    {

        /// <summary>
        /// Constructor por defecto que setea el valor de la cotizacion con respecto al dolar
        /// </summary>
        private Peso()
        {
            this.CotizRespectoDolar = 201;
        }
        /// <summary>
        /// Constructor con un parametro
        /// </summary>
        /// <param name="cantidad"></param>
        public Peso(double cantidad) : this()
        {
            this.Cantidad = cantidad;
        }

        /// <summary>
        /// Sobrecarga del operador Peso que convierte un objeto de tipo Euro a uno de tipo Peso
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator Peso(Euro e)
        {
            Peso p = new Peso(e.Cantidad);
            p.Cantidad = e.Cantidad * e.CotizRespectoDolar;
            return p;
        }

        /// <summary>
        /// Sobrecarga del operador Peso que convierte un objeto de tipo Dolar a uno de tipo Peso
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Peso(Dolar d)
        {
            Peso p = new Peso(d.Cantidad);
            p.Cantidad = p.Cantidad * p.CotizRespectoDolar;
            return p;
        }

        /// <summary>
        /// Sobrecarga del operador peso que crea un objeto de tipo Peso con un valor determiado
        /// </summary>
        /// <param name="d"></param>
        public static implicit operator Peso(double d)
        {
            Peso p = new Peso(d);
            return p;
        }

        /// <summary>
        /// Sobrecarga del operador == que compara un objeto de tipo Peso con uno de tipo Dolar
        /// </summary>
        /// <param name="p"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator ==(Peso p, Dolar d)
        {
            if (d.Cantidad == (p.Cantidad * p.CotizRespectoDolar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Sobrecarga del operador == que compara un objeto de tipo Peso con uno de tipo Dolar
        /// </summary>
        /// <param name="p"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(d == p);
        }
        /// <summary>
        /// Sobrecarga del operador == que compara dos objetos de tipo Peso
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Peso p1, Peso  p2)
        {
            if (p1.Cantidad == p2.Cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Sobrecarga del operador != que compara dos objetos de tipo Peso
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Sobrecarga del operador == que compara un objeto de tipo Peso con uno de tipo Euro
        /// </summary>
        /// <param name="p"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator ==(Peso p, Euro e)
        {
            if (e.Cantidad == (p.Cantidad / p.CotizRespectoDolar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Sobrecarga del operador != que compara un objeto de tipo Peso con uno de tipo Euro
        /// </summary>
        /// <param name="p"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator !=(Peso p, Euro e)
        {
            return !(e == p);
        }

        /// <summary>
        /// Sobrecarga del operador + que suma al valor de un Peso el valor de un objeto de tipo Euro
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Peso operator +(Euro e, Peso p)
        {
            return p.Cantidad + (e.Cantidad * e.CotizRespectoDolar * p.CotizRespectoDolar);
        }

        /// <summary>
        /// Sobrecarga del operador + que suma al valor de un Peso el valor de un objeto de tipo Dolar
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Peso operator +(Dolar d, Peso p)
        {
            return p.Cantidad + (d.Cantidad * p.CotizRespectoDolar);
        }

        /// <summary>
        /// Sobrecarga del operador - que resta al valor de un Peso el valor de un objeto de tipo Dolar
        
        /// </summary>
        /// <param name="p"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static Peso operator -(Peso p, Dolar d)
        {
            return p.Cantidad - (d.Cantidad * p.CotizRespectoDolar);
        }
        /// <summary>
        /// Sobrecarga del operador - que resta al valor de un Peso el valor de un objeto de tipo Euro
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Peso operator -(Euro d, Peso p)
        {
            return d.Cantidad - (p.Cantidad / p.CotizRespectoDolar);
        }
    }
}
