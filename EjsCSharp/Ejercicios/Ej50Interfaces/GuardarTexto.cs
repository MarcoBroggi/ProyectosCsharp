using System;
using System.IO;

namespace Ej50Interfaces
{
    public class GuardarTexto<T,V> : IGuardar<T,V>
    {
        /// <summary>
        /// Guarda un objeto generico en un archivo de texto
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="ruta"></param>
        public void Guardar(T obj, string ruta)
        {

            try
            {
                using (StreamWriter writer = new StreamWriter(ruta))

                {
                    writer.Write(obj);
                }

            }
            catch(Exception)
            {
                throw new ErrorArchivoException("Error al guardar el archivo.");
            }
            }

        /// <summary>
        /// Carga el contenido de una archivo de texto en una variable generica
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public V Leer(string ruta)
        {
            V retorno;
            string aux = "";
           
            try
            {
                StreamReader sr = new StreamReader(ruta);

                // Leo todo el texto

                aux = sr.ReadToEnd();

                // Cierro el archivo

                sr.Close();
                retorno = (V)Convert.ChangeType(aux, typeof(V));

            }
            catch
            {
                throw new ErrorArchivoException("Error al leer del archivo.");
            }

            return retorno;
        }
    }
}
