using BenchmarkDotNet.Running;
using JSON.Research.Benchmark.Benchmarks;

BenchmarkRunner.Run<JSONDeserializeBenchmark>();
BenchmarkRunner.Run<JSONSerializeBenchmark>();