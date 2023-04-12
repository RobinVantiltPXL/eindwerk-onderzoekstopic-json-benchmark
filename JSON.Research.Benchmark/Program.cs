using BenchmarkDotNet.Running;
using JSON.Research.Benchmark.Benchmarks;

BenchmarkRunner.Run<JSONDeserializeBenchmark>();
BenchmarkRunner.Run<JSONDeserializeAdmObjectBenchmark>();
BenchmarkRunner.Run<JSONSerializeBenchmark>();