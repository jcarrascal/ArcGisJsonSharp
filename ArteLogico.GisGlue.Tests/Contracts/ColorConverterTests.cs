using ApprovalTests;
using ApprovalTests.Namers;
using ApprovalTests.Reporters;
using ArteLogico.GisGlue.Contracts;
using Newtonsoft.Json;
using NUnit.Framework;
using System.IO;

namespace ArteLogico.GisGlue.Tests.Contracts
{
    [TestFixture]
    [UseReporter(typeof(DiffReporter))]
    [UseApprovalSubdirectory("ColorConverterTestsApprovals")]
    public class ColorConverterTests
    {
        [Test]
        public void RoundTripSerialization_WhenGivenAColor_ThenMatchesTheInput()
        {
            this.CheckRoundTripSerialization<Color>("ColorConverterTestsApprovals");
        }

        [Test]
        public void RoundTripSerialization_WhenGivenAColorContainer_ThenMatchesTheInput()
        {
            /*var cont = new ColorContainer { Background = new Color { R = 100 } };
            string result = JsonHelper.Serialize(cont, Formatting.Indented);
            System.Console.WriteLine(result);*/
            this.CheckRoundTripSerialization<ColorContainer>("ColorConverterTestsApprovals");
        }

        public class ColorContainer
        {
            public Color Background { get; set; }
        }
    }
}
