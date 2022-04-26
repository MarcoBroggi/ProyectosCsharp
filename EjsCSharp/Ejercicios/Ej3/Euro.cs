using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej20
{
    class Euro : Dinero
    {
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private Euro()
        {
            this.CotizRespectoDolar = 1.08;
        }

        /// <summary>
        /// Constructor con un parametro
        /// </summary>
        /// <param name="cantidad"></param>
        public Euro(double cantidad) : this()
        {
            this.Cantidad = cantidad;
        }

       

        /// <summary>
        /// Sobrecarga del operador Dolar que convierte el valor de un objeto Euro a Dolar
        /// </summary>
        /// <param name="e"></param>

        public static explicit operator Dolar(Euro e)
        {
            Dolar  d = new Dolar(e.Cantidad);
            d.Cantidad = e.Cantidad * e.CotizRespectoDolar;
            return d;
        }

        /// <summary>
        /// Sobrecarga del operador Peso que le asigna el valor de un objeto Euro en pesos
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator Peso(Euro e)
        {
            Peso p= new Peso(e.Cantidad);
            p.Cantidad = p.Cantidad * p.CotizRespectoDolar;
            return p;
        }
        /// <summary>
        /// Sobrecarga del operador Euro en donde se crea un objeto de ese tipo con un valor determinado
        /// </summary>
        /// <param name="d"></param>
        public static implicit operator Euro(double d)
        {
            Euro eu = new Euro(d);
            return eu;
        }
        /// <summary>
        /// Sobrecarga del operador == que compara entre un ojeto Euro y un Dolar
        /// </summary>
        /// <param name="e"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator ==(Euro e ,Dolar d)
        {
            if (d.Cantidad == (e.Cantidad * e.CotizRespectoDolar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Sobrecarga del operador != que compara entre un ojeto Euro y un Dolar
        /// </summary>
        /// <param name="e"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator !=(Euro e,Dolar d)
        {
            return !(d == e);
        }

        /// <summary>
        /// Sobrecarga del operador == que compara dos objetos de tipo Euro
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static bool operator ==(Euro e1, Euro e2)
        {
            if (e1.Cantidad == e2.Cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Sobrecarga del operador != que compara dos objetos de tipo Euro
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        /// <summary>
        /// Sobrecarga del operador == que compara un objeto de tipo Euro y otro de tipo Peso
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator ==(Euro e, Peso p)
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
        /// Sobrecarga del operador != que compara un objeto de tipo Euro y uno de tipo Peso
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        /// <summary>
        /// Sobrecarga del operador + que suma a la cantidad de un objeto de tipo Dolar la cantidad de uno de 
        /// tipo Euro
        /// </summary>
        /// <param name="e"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static Euro operator +(Euro e,Dolar d)
        {
            return d.Cantidad + (e.Cantidad * e.CotizRespectoDolar);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Euro operator +(Euro d, Peso p)
        {
            return d.Cantidad + (p.Cantidad / p.CotizRespectoDolar);
        }

        /// <summary>
        /// Sobrecarga del operador - que resta a la cantidad de un objeto de tipo Dolar la cantidad de uno de 
        /// tipo Euro
        /// </summary>
        /// <param name="e"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static Euro operator -(Euro e, Dolar d)
        {
            return d.Cantidad - (e.Cantidad / e.CotizRespectoDolar);
        }

        /// <summary>
        /// Sobrecarga del operador - que resta a la cantidad de un objeto de tipo Dolar la cantidad de uno de 
        /// tipo Peso
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Euro operator -(Euro d, Peso p)
        {
            return d.Cantidad - (p.Cantidad / p.CotizRespectoDolar);
        }

    }

}
