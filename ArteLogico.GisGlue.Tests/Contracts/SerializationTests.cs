using ApprovalTests;
using ApprovalTests.Namers;
using ApprovalTests.Reporters;
using ArteLogico.GisGlue.Contracts;
using Newtonsoft.Json;
using NUnit.Framework;

namespace ArteLogico.GisGlue.Tests.Contracts
{
    [TestFixture]
    [UseReporter(typeof(DiffReporter))]
    [UseApprovalSubdirectory("SerializationTestsApprovals")]
    public class SerializationTests
    {
        [Test]
        public void FeatureServiceOperationalLayersRoundtripSerialization()
        {
            // Based on a sample given by Esri on http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html#/ArcGIS_feature_service_operational_layers/02qt00000017000000/
            string resourceName = @"ArteLogico.GisGlue.Tests.Contracts.SerializationTestsApprovals.SerializationTests.FeatureServiceOperationalLayersRoundtripSerialization.approved.txt";
            CheckRoundtripSerialization(resourceName);
        }

        [Test]
        public void OperationalLayerRoundTripSerialization()
        {
            // Based on a sample given by Esri on http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html#/ArcGIS_map_service_operational_layer/02qt00000018000000/
            string resourceName = @"ArteLogico.GisGlue.Tests.Contracts.SerializationTestsApprovals.SerializationTests.OperationalLayerRoundTripSerialization.approved.txt";
            CheckRoundtripSerialization(resourceName);
        }

        [Test]
        public void SingleBasemapLayerRoundTripSerialization()
        {
            // Based on a sample given by Esri on http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html#/Single_basemap_layer/02qt00000016000000/
            string resourceName = @"ArteLogico.GisGlue.Tests.Contracts.SerializationTestsApprovals.SerializationTests.SingleBasemapLayerRoundTripSerialization.approved.txt";
            CheckRoundtripSerialization(resourceName);
        }

        [Test]
        public void SingleOperationalLayerRoundTripSerialization()
        {
            // Based on a sample given by Esri on http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html#/Single_layer_from_an_ArcGIS_map_service_as_an_operational_layer/02qt0000001m000000/
            string resourceName = @"ArteLogico.GisGlue.Tests.Contracts.SerializationTestsApprovals.SerializationTests.SingleOperationalLayerRoundTripSerialization.approved.txt";
            CheckRoundtripSerialization(resourceName);
        }

        [Test]
        public void TwoBasemapLayerRoundTripSerialization()
        {
            // Based on a sample given by Esri on http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html#/Two_basemap_layers/02qt00000015000000/
            string resourceName = @"ArteLogico.GisGlue.Tests.Contracts.SerializationTestsApprovals.SerializationTests.TwoBasemapLayerRoundTripSerialization.approved.txt";
            CheckRoundtripSerialization(resourceName);
        }

        private static void CheckRoundtripSerialization(string resourceName)
        {
            string expected = Helper.ReadAllText(resourceName);
            var webMap = JsonHelper.Deserialize<WebMap>(expected);
            string result = JsonHelper.Serialize(webMap, Formatting.Indented);
            Approvals.Verify(result);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
