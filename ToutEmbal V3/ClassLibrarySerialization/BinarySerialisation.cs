using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClassLibrarySerialization
{
    public class XMLSerialisation<T>
    {
        /// <summary>
        /// Serialization générique de l'objet de type T
        /// </summary>
        /// <param name="path">Chemin complet du fichier avec son nom et extension</param>
        /// <param name="obj">L'objet T à sérialiser</param>
        /// <exception cref="ArgumentNullException">Se produit quand l'objet est égal à null</exception>
        /// <exception cref="FileNotFoundException">Se produit quand le chemin est invalide</exception>
        /// <exception cref="UnauthorizedAccessException">Se produit quand les droits d'écriture au fichier sont absents</exception>
        /// <exception cref="PathTooLongException">Exception qui est levée quand un chemin d’accès ou un nom de fichier complet dépasse la longueur maximale définie par le système.</exception>
        public static void Serialize(string path, T obj)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);

            stream.Close();
        }
        /// <summary>
        /// Deserialization générique de l'objet de type T
        /// </summary>
        /// <param name="path">Chemin complet du fichier avec son nom et extension</param>
        /// <returns>L'objet de type T déserialisé</returns>
        /// <exception cref="FileNotFoundException">Se produit quand le chemin est invalide</exception>
        /// <exception cref="UnauthorizedAccessException">Se produit quand les droits de lecture au fichier sont absents</exception>
        /// <exception cref="PathTooLongException">Exception qui est levée quand un chemin d’accès ou un nom de fichier complet dépasse la longueur maximale définie par le système.</exception>
        public static T Deserialize(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);

            T temp = (T)formatter.Deserialize(stream);

            stream.Close();

            return temp;
        }
    }
}
