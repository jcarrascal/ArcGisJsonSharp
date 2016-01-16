using Newtonsoft.Json;
using System;

namespace ArteLogico.GisGlue.Contracts
{
    public class ColorConverter : JsonConverter
    {
        /// <summary>
        /// Gets a value indicating whether this instance can read.
        /// </summary>
        /// <value><c>true</c> if this instance can read; otherwise, <c>false</c>.</value>
        public override bool CanRead
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance can write.
        /// </summary>
        /// <value><c>true</c> if this instance can write; otherwise, <c>false</c>.</value>
        public override bool CanWrite
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        /// A value indicating whther this instance can convert the specified object type.
        /// </returns>
        public override bool CanConvert(Type objectType)
        {
            return typeof(Color) == objectType;
        }

        /// <summary>
        /// Reads the json.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value.</param>
        /// <param name="serializer">The serializer.</param>
        /// <returns>The object instance.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            int? r = reader.ReadAsInt32();
            int? g = reader.ReadAsInt32();
            int? b = reader.ReadAsInt32();
            int? a = reader.ReadAsInt32();
            reader.Skip();
            if (r.HasValue && g.HasValue && b.HasValue && a.HasValue)
            {
                return new Color { R = (byte)r.Value, G = (byte)g.Value, B = (byte)b.Value, A = (byte)a.Value };
            }

            return existingValue;
        }

        /// <summary>
        /// Writes the json.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var color = (Color)value;
            writer.WriteStartArray();
            writer.WriteValue(color.R);
            writer.WriteValue(color.G);
            writer.WriteValue(color.B);
            writer.WriteValue(color.A);
            writer.WriteEndArray();
        }
    }
}
