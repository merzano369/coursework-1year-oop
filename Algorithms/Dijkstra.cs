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

            while (priorityQueue.Count > 0)
            {
                var current = priorityQueue.Dequeue();

                if (current == target)
                {
                    break;
                }

                foreach (var edge in graph.GetOutgoingEdges(current))
                {
                    var neighbor = edge.Target;
                    var newDistance = distances[current] + edge.Weight;

                    if (newDistance < distances[neighbor])
                    {
                        distances[neighbor] = newDistance;
                        previous[neighbor] = current;
                        priorityQueue.Enqueue(neighbor, newDistance);
                    }
                }
            }

            if (distances[target] == double.PositiveInfinity)
            {
                return new PathResult("Шлях між заданими вузлами не знайдено.");
            }

            var path = new List<Node>();
            var currentNode = target;

            while (currentNode != null)
            {
                path.Add(currentNode);
                previous.TryGetValue(currentNode, out currentNode);
            }
            path.Reverse();

            return new PathResult(path, distances[target], 0);
        }
    }
}
