using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ej57Serializacion
{
    class Persona
    {
        private string nombre;
        private string apellido;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Persona ()
        {
            
        }

        /// <summary>
        /// Constructor con 2 paramtros
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="ape"></param>
        public Persona(string nom, string ape)
        {
            this.nombre = nom;
            this.apellido = ape;
        }

        /// <summary>
        /// Serializa un objeto de tipo Persona en xml.
        /// </summary>
        /// <param name="objeto"></param>
        public static void Guardar(Persona objeto)
        {
                try
                {
                    using (StreamWriter streamWriter = new StreamWriter(""))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                        xmlSerializer.Serialize(streamWriter, objeto);
                    }
                }
                catch (Exception)
                {
                    throw new ErrorArchivoException("Error al guardar el archivo.");
                }   
        }

        /// <summary>
        /// Deserializa un objeto de tipo Persona de xml.
        /// </summary>
        /// <returns></returns>
        public static Persona Leer()
           
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(""))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                    Persona objeto = xmlSerializer.Deserialize(streamReader) as Persona;
                    return objeto;
                }
            }
            catch (Exception)
            {
                throw new ErrorArchivoException("Error al cargar el archivo.");
            }
        }

    }
}
