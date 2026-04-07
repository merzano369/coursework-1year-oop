using System.Collections.Generic;
using GraphPathfinder.Models;

namespace GraphPathfinder.Algorithms
{
    public class AStar : IPathAlgorithm
    {
        public string Name => "A*";

        public PathResult FindPath(Graph graph, Node start, Node target)
        {
            // Placeholder
            return new PathResult("Not implemented yet");
        }
    }
}
