using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibraryXMLSerialization
{
    public class XMLSerialization<T>
    {
        /// <summary>
        /// Serializaion xml générique de l'objet de type T
        /// </summary>
        /// <param name="path">Chemin complet du fichier de déstination avec le nom et l'extension</param>
        /// <param name="obj">Objet de type T à sérialiser</param>
        public static void Serialize(string path, T obj)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));

            TextWriter textWriter = new StreamWriter(path);

            formatter.Serialize(textWriter, obj);

            textWriter.Close();
        }
        /// <summary>
        /// Deserializaion xml générique d'un objet de type T
        /// </summary>
        /// <param name="path">Chemin complet du fichier à deserialiser avec le nom et l'extension</param>
        /// <returns></returns>
        public static T Deserialize(string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));

            TextReader textReader = new StreamReader(path);

            T temp = (T)formatter.Deserialize(textReader);

            textReader.Close();

            return temp;
        }
    }
}
