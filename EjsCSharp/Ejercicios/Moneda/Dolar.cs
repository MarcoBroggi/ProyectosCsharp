using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
   public class Dolar : Dinero
    {
        

        private Dolar()
        {
            this.CotizRespectoDolar = 1;
        }

        public Dolar(double cantidad) : this()
        {
            this.Cantidad = cantidad;
        }

        

        public static explicit operator Euro(Dolar d)
        {
            Euro e = new Euro(0);
            Console.WriteLine(e.Cantidad);
            Console.WriteLine(d.Cantidad);
            Console.WriteLine(e.CotizRespectoDolar);
            e.Cantidad = d.Cantidad / e.CotizRespectoDolar;
            
            return e;
        }

        public static explicit operator Peso(Dolar d)
        {
            Peso p = new Peso(d.Cantidad);
            p.Cantidad = p.Cantidad * p.CotizRespectoDolar;
            return p;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar dolar = new Dolar(d);
            return dolar;
        }

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

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

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

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

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

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }

        public static Dolar operator + (Dolar d,Euro e)
        {
          d.Cantidad=  d.Cantidad + (e.Cantidad * e.CotizRespectoDolar);
            return d;
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            d.Cantidad= d.Cantidad + (p.Cantidad / p.CotizRespectoDolar);
            return d;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            d.Cantidad= d.Cantidad - (e.Cantidad * e.CotizRespectoDolar);
            return d;
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            d.Cantidad = d.Cantidad - (p.Cantidad / p.CotizRespectoDolar);
            return d;
        }


    }
}
