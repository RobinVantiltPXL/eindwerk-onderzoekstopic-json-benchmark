using BenchmarkDotNet.Attributes;
using JSON.Research.Benchmark.Util;
using JSON.Research.Domain;

namespace JSON.Research.Benchmark.Benchmarks
{
    public class JSONSerializeBenchmark
    {
        private static readonly Person demoPerson = PersonBuilder.GetDemoPerson();


        [Benchmark(Baseline = true)]
        public void NewtonsoftJson_Serialize_Benchmark()
        {
            Newtonsoft.Json.JsonConvert.SerializeObject(demoPerson);
        }

        [Benchmark]
        public void Jil_Serialize_Benchmark()
        {
            Jil.JSON.Serialize(demoPerson);
        }

        [Benchmark]
        public void NetJSON_Serialize_Benchmark()
        {
            NetJSON.NetJSON.Serialize(demoPerson);
        }

        [Benchmark]
        public void Utf8Json_Serialize_Benchmark()
        {
            Utf8Json.JsonSerializer.Serialize(demoPerson);
        }

        [Benchmark]
        public void SystemTextJson_Serialize_Benchmark()
        {
            System.Text.Json.JsonSerializer.Serialize(demoPerson);
        }
    }
}
