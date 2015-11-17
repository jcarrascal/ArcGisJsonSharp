using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.IO;

namespace ArteLogico.GisGlue.Contracts
{
    /// <summary>
    /// Helper methods that configure objects correctly to serialize/deserialize.
    /// </summary>
    public static class JsonHelper
    {
        /// <summary>
        /// Creates the serializer.
        /// </summary>
        /// <returns></returns>
        public static JsonSerializer CreateSerializer()
        {
            var serializer = new JsonSerializer()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                DefaultValueHandling = DefaultValueHandling.Ignore,
            };
            serializer.Converters.Add(new ExtentConverter());
            return serializer;
        }

        /// <summary>
        /// Deserializes the specified string.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public static T Deserialize<T>(string str)
        {
            using (var reader = new StringReader(str))
            {
                return Deserialize<T>(reader);
            }
        }

        /// <summary>
        /// Serializes the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <param name="formatting">The formatting.</param>
        /// <returns></returns>
        public static string Serialize(object obj, Formatting formatting = Formatting.None)
        {
            using (var writer = new StringWriter())
            {
                return Serialize(writer, obj, formatting);
            }
        }

        /// <summary>
        /// Serializes the specified writer.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="obj">The object.</param>
        /// <param name="formatting">The formatting.</param>
        /// <returns></returns>
        public static string Serialize(TextWriter writer, object obj, Formatting formatting = Formatting.None)
        {
            var serializer = CreateSerializer();
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                jsonWriter.Formatting = formatting;
                serializer.Serialize(jsonWriter, obj);
                return writer.ToString(); ;
            }
        }

        /// <summary>
        /// Deserializes the specified reader.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader">The reader.</param>
        /// <returns></returns>
        private static T Deserialize<T>(TextReader reader)
        {
            var serializer = CreateSerializer();
            using (var jsonReader = new JsonTextReader(reader))
            {
                return serializer.Deserialize<T>(jsonReader);
            }
        }
    }
}