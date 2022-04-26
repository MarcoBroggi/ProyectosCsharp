using System;
using PruebaSql;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");

                Db baseDeDatos = new Db();

                SqlConnection sqlConnection = new SqlConnection(baseDeDatos.connectionString);

                SqlCommand comando;

                comando = new SqlCommand();

                comando.CommandType = System.Data.CommandType.Text;

                comando.Connection = sqlConnection;

                List<ClasePrueba> lista = baseDeDatos.RetornarUsuario();

                foreach (ClasePrueba cp in lista)
                {
                    Console.WriteLine(cp.Mostrar());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }







        }
    }
}
