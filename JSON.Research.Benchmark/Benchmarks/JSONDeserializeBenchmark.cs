using BenchmarkDotNet.Attributes;
using JSON.Research.Domain;
using System.Reflection;

namespace JSON.Research.Benchmark.Benchmarks
{
    public class JSONDeserializeBenchmark
    {
        private static readonly string jsonString = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("JSON.Research.Benchmark.Resources.test.json")).ReadToEnd();

        [Benchmark(Baseline = true)]
        public void NewtonsoftJson_Deserialize_Benchmark()
        {
            Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(jsonString);
        }

        [Benchmark]
        public void Jil_Deserialize_Benchmark()
        {
            Jil.JSON.Deserialize<Person>(jsonString);
        }

        [Benchmark]
        public void NetJSON_Deserialize_Benchmark()
        {
            NetJSON.NetJSON.Deserialize<Person>(jsonString);
        }

        [Benchmark]
        public void Utf8Json_Deserialize_Benchmark()
        {
            Utf8Json.JsonSerializer.Deserialize<Person>(jsonString);
        }

        [Benchmark]
        public void SystemTextJson_Deserialize_Benchmark()
        {
            System.Text.Json.JsonSerializer.Deserialize<Person>(jsonString);
        }
    }
}
