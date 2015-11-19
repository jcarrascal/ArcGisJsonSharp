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
    public class SerializationTests
    {
        [Test]
        public void OperationalLayerRoundTripSerialization()
        {
            // Based on a sample given by Esri on
            // http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html#/ArcGIS_map_service_operational_layer/02qt00000018000000/
            string expected = File.ReadAllText(@"Contracts\OperationalLayer.json");
            var webMap = JsonHelper.Deserialize<WebMap>(expected);
            string result = JsonHelper.Serialize(webMap, Formatting.Indented);
            Approvals.Verify(result);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleBasemapLayerRoundTripSerialization()
        {
            // Based on a sample given by Esri on
            // http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html#/Single_basemap_layer/02qt00000016000000/
            string expected = File.ReadAllText(@"Contracts\SingleBasemapLayer.json");
            var webMap = JsonHelper.Deserialize<WebMap>(expected);
            string result = JsonHelper.Serialize(webMap, Formatting.Indented);
            Approvals.Verify(result);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleOperationalLayerRoundTripSerialization()
        {
            // Based on a sample given by Esri on
            // http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html#/Single_layer_from_an_ArcGIS_map_service_as_an_operational_layer/02qt0000001m000000/
            string expected = File.ReadAllText(@"Contracts\SingleOperationalLayer.json");
            var webMap = JsonHelper.Deserialize<WebMap>(expected);
            string result = JsonHelper.Serialize(webMap, Formatting.Indented);
            Approvals.Verify(result);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TwoBasemapLayerRoundTripSerialization()
        {
            // Based on a sample given by Esri on
            // http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html#/Two_basemap_layers/02qt00000015000000/
            string expected = File.ReadAllText(@"Contracts\TwoBasemapLayers.json");
            var webMap = JsonHelper.Deserialize<WebMap>(expected);
            string result = JsonHelper.Serialize(webMap, Formatting.Indented);
            Approvals.Verify(result);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}