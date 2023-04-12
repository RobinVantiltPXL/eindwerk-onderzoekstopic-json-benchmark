using JSON.Research.Benchmark.Util;
using JSON.Research.Domain;

namespace JSON.Research.Test
{
    [TestClass]
    public class JsonSerializeTest
    {
        private static readonly Person expectedPerson = PersonBuilder.GetDemoPerson();

        [TestMethod]
        public void NewtonsoftJsonShouldSerializeCorrectly()
        {
            string serialisedPerson = Newtonsoft.Json.JsonConvert.SerializeObject(expectedPerson);
            Person person = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(serialisedPerson);

            person.Should().BeEquivalentTo(expectedPerson);
        }

        [TestMethod]
        public void JilShouldSerializeCorrectly()
        {
            string serialisedPerson = Jil.JSON.Serialize(expectedPerson);
            Person person = Jil.JSON.Deserialize<Person>(serialisedPerson);

            person.Should().BeEquivalentTo(expectedPerson);
        }
        [TestMethod]
        public void NetJsonShouldSerializeCorrectly()
        {
            string serialisedPerson = NetJSON.NetJSON.Serialize(expectedPerson);
            Person person = NetJSON.NetJSON.Deserialize<Person>(serialisedPerson);

            person.Should().BeEquivalentTo(expectedPerson);
        }
        [TestMethod]
        public void Utf8JsonShouldSerializeCorrectly()
        {
            string serialisedPerson = System.Text.Encoding.UTF8.GetString(Utf8Json.JsonSerializer.Serialize(expectedPerson));
            Person person = Utf8Json.JsonSerializer.Deserialize<Person>(serialisedPerson);

            person.Should().BeEquivalentTo(expectedPerson);
        }
        [TestMethod]
        public void SystemTextJsonShouldSerializeCorrectly()
        {
            string serialisedPerson = System.Text.Json.JsonSerializer.Serialize(expectedPerson);
            Person person = System.Text.Json.JsonSerializer.Deserialize<Person>(serialisedPerson);

            person.Should().BeEquivalentTo(expectedPerson);
        }
    }
}