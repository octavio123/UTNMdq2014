using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace UTNMdq2014.Datos
{
    public abstract class Repositorio<T> : IDisposable
    {
        protected List<T> Datos { get; set; }
        private string filepath;
        private readonly string dir = "Datos";

        protected Repositorio(string filepath)
        {
            this.filepath = dir + "/" + filepath;

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            this.Datos = new List<T>();
            Load();
        }

        private static XmlWriter GetWriteStream(string path)
        {
            XmlWriter writer = null;
            try
            {
                writer = XmlWriter.Create(path, new XmlWriterSettings());
            }
            catch (UnauthorizedAccessException access)
            {
                System.Windows.Forms.MessageBox.Show("Acceso denegado: " + access.Message);
                //App.Instance.Log.Append(GetType().Name, "Cannot open write stream : " + access.Message);
            }
            catch (DirectoryNotFoundException dirNf)
            {
                System.Windows.Forms.MessageBox.Show("Directorio no encontrado: " + dirNf.Message);
                //App.Instance.Log.Append(GetType().Name, "Cannot open write stream : " + dirNf.Message);
            }

            return writer;
        }

        private static XmlTextReader GetReadStream(string path)
        {
            XmlTextReader reader = null;
            try
            {
                if (File.Exists(path))
                    reader = new XmlTextReader(path);
            }
            catch (UnauthorizedAccessException access)
            {
                System.Windows.Forms.MessageBox.Show("Acceso denegado: " + access.Message);
                //App.Instance.Log.Append(GetType().Name, "Cannot open read stream : " + access.Message);
            }
            catch (DirectoryNotFoundException dirNf)
            {
                System.Windows.Forms.MessageBox.Show("Directorio no encontrado: " + dirNf.Message);
                //App.Instance.Log.Append(GetType().Name, "Cannot open read stream : " + dirNf.Message);
            }

            return reader;
        }

        protected void Save()
        {
            using (var stream = GetWriteStream(filepath))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(T[]));
                serializer.WriteObject(stream, Datos.ToArray());
            }
        }

        protected void Load()
        {
            if (File.Exists(filepath))
            {
                using (var stream = GetReadStream(filepath))
                {
                    DataContractSerializer serializer = new DataContractSerializer(typeof(T[]));
                    foreach (var elemento in serializer.ReadObject(stream) as T[])
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
