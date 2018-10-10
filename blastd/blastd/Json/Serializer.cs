using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using Newtonsoft.Json;

namespace blastd.Json
{
    public class Serializer
    {
        /// <summary>
        /// Deserialized a string representation of JSON data into an object of type T
        /// </summary>
        /// <typeparam name="T">Type of object to serialize to</typeparam>
        /// <param name="json">json representation of objects</param>
        /// <returns></returns>
        public T Deserialize<T>(string json)
        {
            T output = JsonConvert.DeserializeObject<T>(json);
            return output;
        }
    }
}