using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ArteLogico.GisGlue.Contracts
{
    public static class JsonHelper
    {
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
    }
}