using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public abstract class Dinero
    {
        private double cantidad;
        private double cotizRespectoDolar;

        public double Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                if (value < 0)
                {
                    throw new ValorInvalidoException("No se puede tener una cantidad negativa!");
                }
                else
                {
                    this.cantidad = value;
                }
                
            }
        }
            public double CotizRespectoDolar
         {
            get
            {
                return this.cotizRespectoDolar;
            }
            set
            {
                if (value < 0)
                {
                    throw new ValorInvalidoException("No se puede tener una cantidad negativa!");
                }
                else
                {
                    this.cotizRespectoDolar = value;
                }
                
            }
         }
        }

    }

