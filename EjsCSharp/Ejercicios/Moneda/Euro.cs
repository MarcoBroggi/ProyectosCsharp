using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro : Dinero
    {
        private Euro()
        {
            this.CotizRespectoDolar = 1.08;
        }

        public Euro(double cantidad) : this()
        {
            this.Cantidad = cantidad;
        }

       



        public static explicit operator Dolar(Euro e)
        {
            Dolar  d = new Dolar(e.Cantidad);
            d.Cantidad = e.Cantidad * e.CotizRespectoDolar;
            return d;
        }

        public static explicit operator Peso(Euro e)
        {
            Peso p= new Peso(e.Cantidad);
            p.Cantidad = p.Cantidad * p.CotizRespectoDolar;
            return p;
        }

        public static implicit operator Euro(double d)
        {
            Euro eu = new Euro(d);
            return eu;
        }

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

        public static bool operator !=(Euro e,Dolar d)
        {
            return !(d == e);
        }

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

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

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

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            e.Cantidad = e.Cantidad + (d.Cantidad * e.CotizRespectoDolar);
            return e;
        }

        public static Euro operator +(Euro e, Peso p)
        {
            e.Cantidad= e.Cantidad + (p.Cantidad / p.CotizRespectoDolar /e.CotizRespectoDolar);
            return e;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            e.Cantidad= e.Cantidad - (d.Cantidad / e.CotizRespectoDolar);
            return e;
        }

        public static Euro operator -(Euro e, Peso p)
        {
            e.Cantidad= e.Cantidad - (p.Cantidad / p.CotizRespectoDolar);
            return e;
        }

    }

}
