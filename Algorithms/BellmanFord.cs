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
            var distances = new Dictionary<Node, double>();
            var previous = new Dictionary<Node, Node>();

            foreach (var node in graph.Nodes)
            {
                foreach ()
            }
            // 2. основний цикл (Релаксація)
                // зробити цикл, який повторюється (к-сть вузлів - 1)
                    // зробити внутрішній цикл, для перевірки чи можна скоротити шлях через цей вузол
            // 3. перевірка на від'ємні цикли
                // пройтись по всіх ребрах (к-сть вузлів - 1) разів, і зробити іще один прохід, якщо сума стала від'ємною значить є безкінечний цикл. Якщо це відбувається видаємо помилку.
            // 4. відновлення шляху
                // скопіювати із дейкстра, тут аналогічно
        }
    }
}
