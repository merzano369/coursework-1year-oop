using System.ComponentModel;
using System.Collections.Generic;
using GraphPathfinder.Models;
using System.Windows;

namespace GraphPathfinder.Algorithms
{
    public class BellmanFord : IPathAlgorithm
    {
        public string Name => "Bellman-Ford";

        public PathResult FindPath(Graph graph, Node start, Node target)
        {
            var distances = new Dictionary<Node, double>();
            var previous = new Dictionary<Node, Node>();

            foreach (var node in graph.Nodes)
            {
                distances[node] = double.PositiveInfinity;
            }

            distances[start] = 0;
            int verticesCount = graph.Nodes.Count;

            for (int i = 0; i < verticesCount - 1; i++)
            {
                foreach (var edge in graph.Edges)
                {
                    var u = edge.Source;
                    var v = edge.Target;
                    var weight = edge.Weight;

                    if (!double.IsPositiveInfinity(distances[u]) && distances[u] + weight < distances[v])
                    {
                        previous[v] = u;
                        distances[v] = distances[u] + weight;
                    }
                }
            }

            foreach (var edge in graph.Edges)
            {
                var u = edge.Source;
                var v = edge.Target;
                var weight = edge.Weight;

                if (!double.IsPositiveInfinity(distances[u]) && distances[u] + weight < distances[v])
                {
                    return new PathResult("Помилка: Граф містить цикл з від'ємною вагою. Найкоротшого шляху не існує.");
                }
            }

            if (double.IsPositiveInfinity(distances[target]))
            {
                return new PathResult("Шлях між заданими вузлами не знайдено.");
            }

            var path = new List<Node>();
            var currentNode = target;

            while (currentNode != null)
            {
                path.Add(currentNode);
                previous.TryGetValue(currentNode, out var nextNode);
                currentNode = nextNode;
            }
            path.Reverse();

            return new PathResult(path, distances[target], 0);
        }
    }
}
