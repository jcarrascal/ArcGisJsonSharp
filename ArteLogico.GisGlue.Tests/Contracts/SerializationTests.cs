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
        public void RoundTripSerialization_WhenGivenAWebMapWithAnOperationalLayer_ThenMatchesTheInput()
        {
            // Based on a sample given by Esri on http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html#/ArcGIS_map_service_operational_layer/02qt00000018000000/
            this.CheckRoundTripSerialization<WebMap>("SerializationTestsApprovals");
        }

        [Test]
        public void RoundTripSerialization_WhenGivenAWebMapWithASingleBasemapLayer_ThenMatchesTheInput()
        {
            // Based on a sample given by Esri on http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html#/Single_basemap_layer/02qt00000016000000/
            this.CheckRoundTripSerialization<WebMap>("SerializationTestsApprovals");
        }

        [Test]
        public void RoundTripSerialization_WhenGivenAWebMapWithASingleOperationalLayer_ThenMatchesTheInput()
        {
            // Based on a sample given by Esri on http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html#/Single_layer_from_an_ArcGIS_map_service_as_an_operational_layer/02qt0000001m000000/
            this.CheckRoundTripSerialization<WebMap>("SerializationTestsApprovals");
        }

        [Test]
        public void RoundTripSerialization_WhenGivenAWebMapWithFeatureServiceOperationalLayers_ThenMatchesTheInput()
        {
            // Based on a sample given by Esri on http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html#/ArcGIS_feature_service_operational_layers/02qt00000017000000/
            this.CheckRoundTripSerialization<WebMap>("SerializationTestsApprovals");
        }

        [Test]
        public void RoundTripSerialization_WhenGivenAWebMapWithTwoBasemapLayers_ThenMatchesTheInput()
        {
            // Based on a sample given by Esri on http://resources.arcgis.com/en/help/arcgis-web-map-json/index.html#/Two_basemap_layers/02qt00000015000000/
            this.CheckRoundTripSerialization<WebMap>("SerializationTestsApprovals");
        }
    }
}
