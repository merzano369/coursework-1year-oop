using System.Collections.Generic;
using System.Linq;

namespace GraphPathfinder.Models
{
    public class Graph
    {
        public List<Node> Nodes { get; } = new List<Node>();
        public List<Edge> Edges { get; } = new List<Edge>();

        public void AddNode(Node node)
        {
            Nodes.Add(node);
        }

        public void AddEdge(Node source, Node target, double weight)
        {
            Edges.Add(new Edge(source, target, weight));
            // Якщо граф неорієнтований, розкоментуй наступний рядок:
            // Edges.Add(new Edge(target, source, weight));
        }

        public IEnumerable<Edge> GetOutgoingEdges(Node node)
        {
            return Edges.Where(e => e.Source == node);
        }
    }
}
