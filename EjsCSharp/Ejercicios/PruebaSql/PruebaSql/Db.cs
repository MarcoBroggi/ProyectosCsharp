using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PruebaSql
{
    public class Db
    {
        public string connectionString = "Data Source=(local)\\sqlexpress; Initial Catalog=Prueba ;Integrated Security=True";

       /* public Db (string cadena)
        {
            this.connectionString = cadena;
        }*/

        public List<ClasePrueba> RetornarUsuario()
        {

            string consulta = "SELECT * FROM Table_1";

            List<ClasePrueba> lista = new List<ClasePrueba>();
            //Establece la conexion
            SqlConnection cn = new SqlConnection(this.connectionString);

            //Establece la consulta
            SqlCommand cm = new SqlCommand(consulta, cn);

            try
            {
                //Conectarse 
                cn.Open();

                //Ejecuta la consulta
                SqlDataReader dr=  cm.ExecuteReader();

                while(dr.Read())
                {
                    ClasePrueba var = new ClasePrueba();
                    // Por cada fila verifica las celdas. 
                    var.Id = (int)dr["ID"];
                    var.Asd = dr["Nombre"].ToString();

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

        public int CrearUsuario(ClasePrueba var)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = (this.connectionString);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText= ($"insert into Table_1 (ID, Nombre) values ('{var.Id}', '{var.Asd}')");

            sqlCommand.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();

                //Retorna el numero de filas afectadas.
                return sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                sqlConnection.Close();
                    
            }


        }
    }
}
