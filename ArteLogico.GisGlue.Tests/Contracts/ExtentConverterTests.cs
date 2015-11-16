using ApprovalTests;
using ArteLogico.GisGlue.Contracts;
using Newtonsoft.Json;
using NUnit.Framework;
using System.IO;

namespace ArteLogico.GisGlue.Tests.Contracts
{
    [TestFixture]
    public class ExtentConverterTests
    {
        [Test]
        public void WriteJson_WhenSerializingAnExtent_ThenTheFormatMatchesTheExample()
        {
            var extent = new Extent { X1 = 100, Y1 = 200, X2 = 1000, Y2 = 2000 };
            var serializer = JsonHelper.CreateSerializer();

            string result;
            using (var writer = new StringWriter())
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                jsonWriter.Formatting = Formatting.Indented;
                serializer.Serialize(jsonWriter, extent);
                result = writer.ToString();
            }

            Approvals.Verify(result);
        }
    }
}