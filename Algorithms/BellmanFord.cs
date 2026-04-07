using System.Collections.Generic;
using GraphPathfinder.Models;

namespace GraphPathfinder.Algorithms
{
    public class BellmanFord : IPathAlgorithm
    {
        public string Name => "Bellman-Ford";

        public PathResult FindPath(Graph graph, Node start, Node target)
        {
            // Placeholder
            return new PathResult("Not implemented yet");
        }
    }
}
