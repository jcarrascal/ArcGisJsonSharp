using Newtonsoft.Json;
using System;

namespace ArteLogico.GisGlue.Contracts
{
    public class ExtentConverter : JsonConverter
    {
        public override bool CanRead
        {
            get
            {
                return true;
            }
        }

        public override bool CanWrite
        {
            get
            {
                return true;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(Extent) == objectType;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var extent = (Extent)existingValue;
            decimal? d;
            d = reader.ReadAsDecimal();
            d = reader.ReadAsDecimal();
            d = reader.ReadAsDecimal();
            d = reader.ReadAsDecimal();
            return existingValue;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var extent = (Extent)value;
            writer.WriteStartArray();
            writer.WriteStartArray();
            writer.WriteValue(extent.X1);
            writer.WriteValue(extent.Y1);
            writer.WriteEndArray();
            writer.WriteStartArray();
            writer.WriteValue(extent.X2);
            writer.WriteValue(extent.Y2);
            writer.WriteEndArray();
            writer.WriteEndArray();
        }
    }
}