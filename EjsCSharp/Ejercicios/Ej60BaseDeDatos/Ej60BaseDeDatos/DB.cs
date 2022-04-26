using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej60BaseDeDatos
{
    public  class DB
    {

        private string connectionString= "Data Source=(local)\\sqlexpress; Initial Catalog =Nothwind; Integrated Security = True";

        public List<Producto> Cargar()
        {
            string consulta = "SELECT * FROM Products";

            List<Producto> lista = new List<Producto>();

            SqlConnection cn = new SqlConnection(this.connectionString);

            SqlCommand cm = new SqlCommand(consulta, cn);

            try
            {
                //Conectarse 
                cn.Open();

                //Ejecuta la consulta
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    Producto var = new Producto();
                    // Por cada fila verifica las celdas. 
                    var.ID = (int)dr["ProductID"];
                    var.Nombre = dr["ProductName"].ToString();
                    var.IDProveedor = (int)dr["SupplierID"];
                    var.IDCategoria = (int)dr["CategoryID"];
                    var.CantidadUnidad = dr["QuantityPerUnit"].ToString();
                    var.PrecioUnidad = (float)dr["UnitPrice"];
                    var.Stock = (int)dr["UnitsInStock"];
                    var.UnidadesOrden = (int)dr["UnitsOnOrder"];
                    var.NivelReorden = (int)dr["ReorderLevel"];
                    if((int)dr["Discontinued"]==0)
                    {
                        var.Discontinued = false;
                    }
                    else
                    {
                        var.Discontinued = true;
                    }


                    

                    lista.Add(var);

                    
                }

                //Si se retorna en el try, el finally se ejecuta de todas formas. 
                // return lista;
            }
            catch (Exception e)
            {

            }
            finally
            {

                //Cierra la conexion
                cn.Close();
            }

            return lista;
        }

        public int CrearProducto(Producto var)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = (this.connectionString);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = ($"INSERT INTO Products (ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) VALUES ('{var.ID}', '{var.Nombre}'), '{var.IDProveedor}', '{var.IDCategoria}', '{var.CantidadUnidad}', '{var.PrecioUnidad}', '{var.Stock}', '{var.UnidadesOrden}', '{var.NivelReorden}', '{var.Discontinued}'");

            sqlCommand.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();

                //Retorna el numero de filas afectadas.
                
            }
            catch(Exception)
            {

            }
            finally
            {
                sqlConnection.Close();

            }

            return sqlCommand.ExecuteNonQuery();
        }

        public int BorrarProducto(int id)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = (this.connectionString);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = ($"DELETE FROM Products WHERE ProductID = " + id);

            sqlCommand.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();

                //Retorna el numero de filas afectadas.

            }
            catch (Exception)
            {

            }
            finally
            {
                sqlConnection.Close();

            }

            return sqlCommand.ExecuteNonQuery();
        }

        public int ModificarProductoNombre(Producto var,int id, string nombre)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = (this.connectionString);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = ($"UPDATE Products SET ProductName = '{nombre}' WHERE id = '{id}'");

            sqlCommand.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();

                //Retorna el numero de filas afectadas.

            }
            catch (Exception)
            {

            }
            finally
            {
                sqlConnection.Close();

            }

            return sqlCommand.ExecuteNonQuery();
        }




    }
}
