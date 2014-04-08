using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace UTNMdq2014.Datos
{
    public class Repositorio<T> : IDisposable
    {
        public List<T> Datos { get; set; }
        string file;

        protected Repositorio(string filename)
        {
            file = filename;
            this.Datos = new List<T>();
        }

        protected void Save()
        {
            using (XmlWriter writer = XmlWriter.Create(file))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T[]));
                serializer.Serialize(writer, Datos.ToArray());
            }
        }

        protected void Load()
        {
            if (File.Exists(file))
            {
                using (XmlReader reader = XmlReader.Create(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T[]));
                    foreach (var elemento in serializer.Deserialize(reader) as T[])
                    {
                        Datos.Add(elemento);
                    }
                }
            }
        }

        public void Dispose()
        {
            Save();
        }
    }
}
