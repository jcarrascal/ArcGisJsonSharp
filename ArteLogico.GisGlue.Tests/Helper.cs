using ApprovalTests;
using ArteLogico.GisGlue.Contracts;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ArteLogico.GisGlue.Tests
{
    internal static class Helper
    {
        public static void CheckRoundTripSerialization<T>(this object obj, string folder, [CallerMemberName] string methodName = null)
        {
            Type type = obj.GetType();
            string resourceName = type.Namespace + "." + folder + "." + type.Name + "." + methodName + ".approved.txt";
            string expected = Helper.ReadAllText(resourceName);
            var deserialized = JsonHelper.Deserialize<T>(expected);
            string result = JsonHelper.Serialize(deserialized, Formatting.Indented);
            Approvals.Verify(result);
            Assert.That(result, Is.EqualTo(expected));
        }

        public static string ReadAllText(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                Assert.That(stream, Is.Not.Null, "The resource " + resourceName + " was not found.");
                using (var reader = new StreamReader(stream))
                {
                    string text = reader.ReadToEnd();
                    return text;
                }
            }
        }
    }
}
