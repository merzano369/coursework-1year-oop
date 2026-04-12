using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using GraphPathfinder.Models;

namespace GraphPathfinder.Algorithms
{
    public class AStar : IPathAlgorithm
    {
        public string Name => "A*";

        public PathResult FindPath(Graph graph, Node start, Node target)
        {
            var gScores = new Dictionary<Node, double>(); // зберігає реальну відстань від start до конкретного вузла
            var fScores = new Dictionary<Node, double>(); // зберігає суму: реальна відстань + евристика до target
            var previous = new Dictionary<Node, Node>(); // для відновлення шляху

            foreach (var node in graph.Nodes)
            {
                gScores[node] = double.PositiveInfinity;
                fScores[node] = double.PositiveInfinity;
            }

            gScores[start] = 0;
            fScores[start] = Heuristic(start, target);

            var priorityQueue = new PriorityQueue<Node, double>();
            priorityQueue.Enqueue(start, fScores[start]);

            // --- ЕТАП 3: Основний цикл пошуку ---
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
                    var tentativeGScore = gScores[current] + edge.Weight;

                    if (tentativeGScore < gScores[neighbor])
                    {
                        previous[neighbor] = current;
                        gScores[neighbor] = tentativeGScore;
                        fScores[neighbor] = tentativeGScore + Heuristic(neighbor, target);

                        priorityQueue.Enqueue(neighbor, fScores[neighbor]);
                    }
                }
            }

            if (double.IsPositiveInfinity(gScores[target]))
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

            return new PathResult(path, gScores[target], 0);
        }

        private static double Heuristic(Node a, Node b)
        {
            double dX = a.X - b.X;
            double dY = a.Y - b.Y;
            return Math.Sqrt(dX * dX + dY * dY);        
        }
    }
}
