using GraphPathfinder.Models;

namespace GraphPathfinder.Algorithms
{
    public interface IPathAlgorithm
    {
        string Name { get; } 
        PathResult FindPath(Graph graph, Node start, Node target);
    }
}
