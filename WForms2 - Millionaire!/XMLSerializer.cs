using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace WForms2___Millionaire_
{
    public class XMLSerializer : ISerializer
    {

        public void Save(ICollection<Questions> collection)
        {
            List<Questions> q = collection.ToList();
            FileStream stream = new FileStream("../../questions.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Questions>));
            serializer.Serialize(stream, collection);
            stream.Close();
        }



        public ICollection<Questions> Load()
        {
            FileStream stream = new FileStream("../../questions.xml", FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Questions>));
            List<Questions> list = (List<Questions>)serializer.Deserialize(stream);
            stream.Close();
            return list;
        }
    }
}
