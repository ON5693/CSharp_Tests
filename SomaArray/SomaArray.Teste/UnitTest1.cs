using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using Xunit.Abstractions;
using SomaArray;

namespace SomaArray.Teste
{
    [Trait("Category", "Unit")]
    public class UnitTest1
    {
        private readonly ITestOutputHelper output;

        public UnitTest1(ITestOutputHelper output) => this.output = output;

        //Método para teste de performance da execução de cada loop 
        //Valores testados estão na classe 'HeavyBenchmarks' abaixo
        [Fact]
        public void TestPerformance()
        {
            var logger = new AccumulationLogger();

            var config = ManualConfig.Create(DefaultConfig.Instance)
                .AddLogger(logger)
                .WithOptions(ConfigOptions.DisableOptimizationsValidator);

            BenchmarkRunner.Run<HeavyBenchmarks>(config);

            output.WriteLine(logger.GetLog());

        }

        //Método para teste da soma dos valores do array
        //Valores testados estão no array 'vetor'
        [Fact]
        public void TestResult()
        {

            int[] vetor = { 1, 2, 3 };

            var sut = new Somar().SumArray(vetor);

            Assert.Equal(6, sut);


        }
        public int Size { get; set; } = 3;

    }

    [MemoryDiagnoser]
    public class HeavyBenchmarks
    {
        int sum = 0;

        Random rnd = new Random();

        [Params(100, 1_000_000)]
        public int Size { get; set; }

        private int[] vetor;

        [GlobalSetup]
        public void Setup()
        {
            vetor = Enumerable.Range(1,Size).Select(i => rnd.Next(10)).ToArray();
        }

        [Benchmark]
        public int ForEach()
        {
            foreach (var i in vetor)
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int ForEachParalell()
        {
            sum = vetor.AsParallel().Sum(x => (int)x);

            return sum;
        }
    }
}