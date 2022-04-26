using System;
using System.IO;

namespace BibliotecaArchivosTexto
{
    public class ArchivoTexto
    {

        public static void Guardar(string ruta,string texto)
        {
            using (StreamWriter writer = new StreamWriter(ruta))

            {

                writer.Write(texto);

                
            }
        }

        public static string Cargar(string ruta)
        {
            string retorno = "";
            
            StreamReader sr = new StreamReader(ruta);

            // Leo una línea de texto

            retorno= sr.ReadToEnd();

            // Cierro el archivo

            sr.Close();

            return retorno;
        }
    }

}
