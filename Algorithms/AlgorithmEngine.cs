using System.Diagnostics;
using GraphPathfinder.Models;

namespace GraphPathfinder.Algorithms
{
    public class AlgorithmEngine
    {
        public PathResult Execute(IPathAlgorithm algorithm, Graph graph, Node start, Node target)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = algorithm.FindPath(graph, start, target);
            stopwatch.Stop();
            
            if (result != null)
                result.ExecutionTimeMs = stopwatch.ElapsedMilliseconds;
                
            return result;
        }
    }
}
