using BenchmarkDotNet.Attributes;
using System.Reflection;

namespace JSON.Research.Benchmark.Benchmarks
{
    public class JSONDeserializeAdmObjectBenchmark
    {
        private static readonly string jsonString = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("JSON.Research.Benchmark.Resources.house.json")).ReadToEnd();

        [Benchmark(Baseline = true)]
        public void NewtonsoftJson_Deserialize_object_Benchmark()
        {
            Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString);
        }

        [Benchmark]
        public void Jil_Deserialize_object_Benchmark()
        {
            Jil.JSON.Deserialize<object>(jsonString);
        }

        [Benchmark]
        public void NetJSON_Deserialize_object_Benchmark()
        {
            NetJSON.NetJSON.DeserializeObject(jsonString);
        }

        [Benchmark]
        public void Utf8Json_Deserialize_object_Benchmark()
        {
            Utf8Json.JsonSerializer.Deserialize<object>(jsonString);
        }

        [Benchmark]
        public void SystemTextJson_Deserialize_object_Benchmark()
        {
            System.Text.Json.JsonSerializer.Deserialize<object>(jsonString);
        }
    }
}
