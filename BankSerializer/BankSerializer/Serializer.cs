using System.Text.Json;
using System.Xml.Serialization;

namespace BankSerializer
{
    public class Serializer
    {
        public string SerializeJSONList<T>(IEnumerable<T> users)
        {
            return JsonSerializer.Serialize(users);
        }

        public IEnumerable<T> DeSerializeJSONList<T>(string data)
        {
            return JsonSerializer.Deserialize(data, typeof(IEnumerable<T>)) as IEnumerable<T>;
        }

        public string SerializeJSON<T>(T user)
        {
            return JsonSerializer.Serialize(user);
        }

        public T DeSerializeJSON<T>(string data)
        {
            return (T)JsonSerializer.Deserialize(data, typeof(T));
        }
        public string SerializeXML<T>(T user)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StringWriter stringWriter = new StringWriter();

            serializer.Serialize(stringWriter, user);
            return stringWriter.ToString();
        }

        public T DeSerializeXML<T>(string data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StringReader stringReader = new StringReader(data);

            return (T)serializer.Deserialize(stringReader);
        }

        public string SerializeXMLList<T>(IEnumerable<T> users)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            StringWriter stringWriter = new StringWriter();

            serializer.Serialize(stringWriter, users);
            return stringWriter.ToString();
        }

        public IEnumerable<T> DeSerializeXMLList<T>(string data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            StringReader stringReader = new StringReader(data);

            return serializer.Deserialize(stringReader) as IEnumerable<T>;
        }
    }
}