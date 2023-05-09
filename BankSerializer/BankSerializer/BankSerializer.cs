using BankServer.Models;
using System.Text.Json;
using System.Xml.Serialization;

namespace BankSerializer
{
    public class BankSerializer
    {
        public string SerializeJSON<T>(IEnumerable<T> users)
        {
            return JsonSerializer.Serialize(users);
        }

        public IEnumerable<T> DeSerializeJSON<T>(string data)
        {
            return JsonSerializer.Deserialize(data, typeof(IEnumerable<T>)) as IEnumerable<T>;
        }
    }
}