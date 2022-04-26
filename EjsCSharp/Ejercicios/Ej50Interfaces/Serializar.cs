using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ej50Interfaces
{

   
    public class Serializar<S,V> : IGuardar<S,V>
    {
        /// <summary>
        /// Serializa en un archivo .json un objeto 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="ruta"></param>
        /// <returns>True si lo guarda, False si tira una excepcion</returns>
        public void Guardar(S obj,string ruta)
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            try
            {
                jsonSerializerOptions.WriteIndented = true;

                string objetoJson = JsonSerializer.Serialize<object>(obj, jsonSerializerOptions);

                File.WriteAllText(ruta, objetoJson);
            }
            catch(Exception )
            {
                throw new ErrorArchivoException("Error al serializar a .json");
            }
           
        }
        /// <summary>
        /// Lee un objeto de un archivo .json
        /// </summary>
        /// <returns>Retorna el objeto leido</returns>
        public V Leer(string ruta)
        {
            string objetoJson = "";
            
            try
            {
                objetoJson = File.ReadAllText(ruta);
            }

            catch (Exception)
            {
                throw new ErrorArchivoException("Error al cargar el .json");
            }

            V objetoAux = JsonSerializer.Deserialize<V>(objetoJson);

            return objetoAux;
        }
    }
}
