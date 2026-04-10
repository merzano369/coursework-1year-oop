using System.Collections.Generic;
using GraphPathfinder.Models;

namespace GraphPathfinder.Algorithms
{
    public class Dijkstra : IPathAlgorithm
    {
        public string Name => "Dijkstra";

        public PathResult FindPath(Graph graph, Node start, Node target)
        {
            foreach (var edge in graph.Edges)
            {
                if (edge.Weight < 0)
                {
                    return new PathResult("Помилка: Алгоритм Дейкстри не працює з від'ємними вагами ребер.");
                }
            }

            var distances = new Dictionary<Node, double>();
            var previous = new Dictionary<Node, Node>();
            var priorityQueue = new PriorityQueue<Node, double>();

            foreach (var node in  graph.Nodes)
            {
                distances[node] = double.PositiveInfinity;
            }

            distances[start] = 0;
            priorityQueue.Enqueue(start, 0);

            
        }
    }
}
