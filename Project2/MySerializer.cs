using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Project2
{
    class MySerializer<T>
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));

        public void Serialize(T t, string path)
        {
            StreamWriter sw = new StreamWriter(path);
            serializer.Serialize(sw.BaseStream, t);
            sw.Close();
        }

        public T Deserialize(string path)
        {
            StreamReader sr = new StreamReader(path);
            T t = (T)serializer.Deserialize(sr.BaseStream);
            sr.Close();
            return t;
        }
    }
}
