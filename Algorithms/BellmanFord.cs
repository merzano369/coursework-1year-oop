using GraphPathfinder.Models;

namespace GraphPathfinder.Algorithms
{
    public class BellmanFord : IPathAlgorithm
    {
        public string Name => "Bellman-Ford";

        public PathResult FindPath(Graph graph, Node start, Node target)
        {
            // 1. ініціалізація
                // словник відстаней та попередніх вузлів
            // 2. основний цикл (Релаксація)
                // зробити цикл, який повторюється (к-сть вузлів - 1)
                    // зробити внутрішній цикл, для перевірки чи можна скоротити шлях через цей вузол
            // 3. перевірка на від'ємні цикли
            // 4. відновлення шляху
        }
    }
}
