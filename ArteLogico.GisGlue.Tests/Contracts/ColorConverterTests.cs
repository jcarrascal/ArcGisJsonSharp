using ApprovalTests;
using ApprovalTests.Reporters;
using ArteLogico.GisGlue.Contracts;
using Newtonsoft.Json;
using NUnit.Framework;
using System.IO;

namespace ArteLogico.GisGlue.Tests.Contracts
{
    [TestFixture]
    [UseReporter(typeof(DiffReporter))]
    public class ColorConverterTests
    {
        [Test]
        public void ReadJsonWriteJson_WhenSerializingAColor_ThenTheFormatMatchesTheExample()
        {
            string example = "[ 108, 151, 203, 0 ]";
            Color color;
            var serializer = JsonHelper.CreateSerializer();

            string result;
            using (var writer = new StringWriter())
            using (var jsonWriter = new JsonTextWriter(writer))
            using (var reader = new StringReader(example))
            using (var jsonReader = new JsonTextReader(reader))
            {
                jsonWriter.Formatting = Formatting.Indented;
                color = serializer.Deserialize<Color>(jsonReader);
                serializer.Serialize(jsonWriter, color);
                result = writer.ToString();
            }

            Approvals.Verify(color);
            Assert.That(result, Is.EqualTo(example));
        }
    }
}