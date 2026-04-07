using System;
using System.Diagnostics;
using GraphPathfinder.Models;
using GraphPathfinder.Algorithms;

namespace GraphPathfinder.Services
{
    public class BenchmarkRunner
    {
        public TimeSpan RunBenchmark(IPathAlgorithm algorithm, Graph graph, Node start, Node target)
        {
            var stopwatch = Stopwatch.StartNew();
            algorithm.FindPath(graph, start, target);
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }
    }
}
