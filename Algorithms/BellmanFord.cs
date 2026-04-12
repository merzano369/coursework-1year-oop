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

            // --- ЕТАП 2: Основний цикл (V - 1 разів) ---
            for (int i = 0; i < verticesCount - 1; i++)
            {
                foreach (var edge in graph.Edges)
                {
                    var u = edge.Source;
                    var v = edge.Target;
                    var weight = edge.Weight;

                    if (distances[u] != double.PositiveInfinity && distances[u] + weight < distances[v])
                    {
                        previous[v] = u;
                        distances[v] = distances[u] + weight;

                    }
                }
            }

            // --- ЕТАП 3: Перевірка на від'ємні цикли ---
            foreach (var edge in graph.Edges)
            {
                
            }
            
            // TODO: Ще раз пройдись по всіх graph.Edges
            
                // TODO: Якщо знову спрацьовує умова релаксації — повернути:
                //       new PathResult("Помилка: Граф містить цикл з від'ємною вагою. Найкоротшого шляху не існує.")

            // --- ЕТАП 4: Формування результату ---
            
            // TODO: Якщо distances[target] == double.PositiveInfinity — повернути:
            //       new PathResult("Шлях між заданими вузлами не знайдено.")

            // TODO: Оголоси List<Node> path для збереження маршруту

            // TODO: Починаючи з target, у циклі while йди назад по previous,
            //       додаючи кожен вузол у path, поки не дійдеш до null

            // TODO: Перевернути path (він записувався з кінця в початок)

            // TODO: Повернути new PathResult(path, distances[target], 0)
        }
    }
}
