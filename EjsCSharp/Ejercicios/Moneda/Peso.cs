using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Peso : Dinero
    {


        private Peso()
        {
            this.CotizRespectoDolar = 201;
        }

        public Peso(double cantidad) : this()
        {
            this.Cantidad = cantidad;
        }

        public static explicit operator Euro(Peso p)
        {
            Euro e = new Euro(p.Cantidad);
            e.Cantidad = p.Cantidad / e.CotizRespectoDolar /p.CotizRespectoDolar;
            return e;
        }

        public static explicit operator Dolar(Peso p)
        {
            Dolar d = new Dolar(p.Cantidad);
            d.Cantidad = p.Cantidad / p.CotizRespectoDolar;
            return d;
        }

        public static implicit operator Peso(double d)
        {
            Peso p = new Peso(d);
            return p;
        }

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

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(d == p);
        }

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

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

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

        public static bool operator !=(Peso p, Euro e)
        {
            return !(e == p);
        }

        public static Peso operator +(Euro e, Peso p)
        {
            p.Cantidad= p.Cantidad + (e.Cantidad * e.CotizRespectoDolar * p.CotizRespectoDolar);
            return p;
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            p.Cantidad= p.Cantidad + (d.Cantidad * p.CotizRespectoDolar);
            return p;
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            p.Cantidad= p.Cantidad - (d.Cantidad * p.CotizRespectoDolar);
            return p;
        }

        public static Peso operator -(Euro e, Peso p)
        {
            p.Cantidad= p.Cantidad - (e.Cantidad * p.CotizRespectoDolar * e.CotizRespectoDolar);
            return p;
        }
    }
}
