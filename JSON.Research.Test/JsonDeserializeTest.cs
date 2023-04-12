using JSON.Research.Benchmark.Util;
using JSON.Research.Domain;
using System.Reflection;

namespace JSON.Research.Test
{
    [TestClass]
    public class JsonDeserializeTest
    {
        private static readonly string jsonString = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("JSON.Research.Test.Resources.test.json")).ReadToEnd();
        private static readonly Person expectedPerson = PersonBuilder.GetDemoPerson();

        [TestMethod]
        public void NewtonsoftJsonShouldDeserializeCorrectly()
        {
            Person person = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(jsonString);

            person.Should().BeEquivalentTo(expectedPerson);
        }

        [TestMethod]
        public void JilShouldDeserializeCorrectly()
        {
            Person person = Jil.JSON.Deserialize<Person>(jsonString);

            person.Should().BeEquivalentTo(expectedPerson);
        }
        [TestMethod]
        public void NetJsonShouldDeserializeCorrectly()
        {
            Person person = NetJSON.NetJSON.Deserialize<Person>(jsonString);

            person.Should().BeEquivalentTo(expectedPerson);
        }
        [TestMethod]
        public void Utf8JsonShouldDeserializeCorrectly()
        {
            Person person = Utf8Json.JsonSerializer.Deserialize<Person>(jsonString);

            person.Should().BeEquivalentTo(expectedPerson);
        }
        [TestMethod]
        public void SystemTextJsonShouldDeserializeCorrectly()
        {
            Person person = System.Text.Json.JsonSerializer.Deserialize<Person>(jsonString);

            person.Should().BeEquivalentTo(expectedPerson);
        }
    }
}