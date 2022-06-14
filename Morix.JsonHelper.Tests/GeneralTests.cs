using Morix;

namespace Morix.Tests
{
    [TestClass]
    public class GeneralTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var d = new
            {
                Name = "asdf",
                Price = 10.53m
            };

            var text = Morix.JsonHelper.Serialize(d);

            Assert.IsTrue(text.Contains("Name"), "No Name");
            Console.WriteLine(text);

            Morix.JsonHelper.Options = new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true
            };
            text = Morix.JsonHelper.Serialize(d);
            Console.WriteLine(text);
        }
    }
}