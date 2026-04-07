namespace GraphPathfinder.Models
{
    public class Edge
    {
        public Node Source { get; }
        public Node Target { get; }
        public double Weight { get; set; }

        public Edge(Node source, Node target, double weight)
        {
            Source = source;
            Target = target;
            Weight = weight;
        }
    }
}
