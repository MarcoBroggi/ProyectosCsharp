using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej60BaseDeDatos
{
    public class Producto
    {
        private int id;

        private string nombre;

        private int idProveedor;

        private int idCategoria;

        private string cantUnidad;

        private double precioUnidad;

        private int stock;

        private int unidadesOrden;

        private int nivelReorden;

        private bool discontinued;

        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                if(value>=0 )
                {
                    this.id = value;
                }
                else
                {
                    throw new ValorIngresadoInvalidoException("Error. Numero invalido.");
                }
                
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (value != null)
                    this.nombre = value;
                else
                    throw new ValorIngresadoInvalidoException("Error. Agregue una palabra");
            }
        }

        public int IDProveedor
        {
            get
            {
                return this.idProveedor;
            }
            set
            {
                if (value >= 0)
                {
                    this.idProveedor = value;
                }
                else
                {
                    throw new ValorIngresadoInvalidoException("Error. Numero invalido.");
                }

            }
        }

        public int IDCategoria
        {
            get
            {
                return this.idCategoria;
            }
            set
            {
                if (value >= 0)
                {
                    this.idCategoria = value;
                }
                else
                {
                    throw new ValorIngresadoInvalidoException("Error. Numero invalido.");
                }

            }
        }

        public string CantidadUnidad
        {
            get
            {
                return this.cantUnidad;
            }
            set
            {
                if (value !=null)
                {
                    this.cantUnidad = value;
                }
                else
                {
                    throw new ValorIngresadoInvalidoException("Error. Valor invalido.");
                }

            }
        }

        public double PrecioUnidad
        {
            get
            {
                return this.precioUnidad;
            }
            set
            {
                if (value >= 0)
                {
                    this.precioUnidad = value;
                }
                else
                {
                    throw new ValorIngresadoInvalidoException("Error. Numero invalido.");
                }

            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
                else
                {
                    throw new ValorIngresadoInvalidoException("Error. Numero invalido.");
                }

            }
        }

        public int UnidadesOrden
        {
            get
            {
                return this.unidadesOrden;
            }
            set
            {
                if (value >= 0)
                {
                    this.unidadesOrden = value;
                }
                else
                {
                    throw new ValorIngresadoInvalidoException("Error. Numero invalido.");
                }

            }
        }

        public int NivelReorden
        {
            get
            {
                return this.nivelReorden;
            }
            set
            {
                if (value >= 0)
                {
                    this.nivelReorden = value;
                }
                else
                {
                    throw new ValorIngresadoInvalidoException("Error. Numero invalido.");
                }

            }
        }
        public bool Discontinued
        {
            get
            {
                return this.discontinued;
            }
            set
            {
                this.discontinued = value;
            }
        }

        public Producto()
        {
            this.ID = 100;
            this.Nombre = "Alpha";
            this.IDProveedor = 1;
            this.IDCategoria = 1;
            this.NivelReorden = 1;
            this.CantidadUnidad = "13 unidades";
            this.Discontinued = false;
            this.Stock = 13;
            this.UnidadesOrden = 0;
            this.PrecioUnidad = 14.0;

        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------------------------");
            sb.AppendLine("ID: " + this.ID);
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("----------------------------------------");
            return sb.ToString();
        }

    }
}
