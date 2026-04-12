using GraphPathfinder.Models;

namespace GraphPathfinder.Algorithms
{
    public class BellmanFord : IPathAlgorithm
    {
        public string Name => "Bellman-Ford";

        public PathResult FindPath(Graph graph, Node start, Node target)
        {
            var distances = new Dictionary<Node, double>();
            var previous = new Dictionary<Node, Node>();

            // --- ЕТАП 1: Ініціалізація ---
            
            // TODO: Оголоси Dictionary<Node, double> для зберігання відстаней до кожного вузла
            
            // TODO: Оголоси Dictionary<Node, Node> для зберігання попередніх вузлів (щоб відновити маршрут)

            // TODO: Пройдись по всіх graph.Nodes і встанови кожному відстань = double.PositiveInfinity

            // TODO: Встанови відстань до start = 0

            // TODO: Збережи кількість вузлів графа в змінну verticesCount

            // --- ЕТАП 2: Основний цикл (V - 1 разів) ---
            
            // TODO: Запусти зовнішній цикл від 0 до verticesCount - 1

                // TODO: Всередині — пройдись по всіх graph.Edges
                
                    // TODO: Отримай u (Source), v (Target), weight (Weight) з поточного ребра

                    // TODO: Перевір умову релаксації:
                    //       - distances[u] != double.PositiveInfinity
                    //       - distances[u] + weight < distances[v]
                    //       Якщо обидві виконуються — оновити distances[v] і previous[v]

            // --- ЕТАП 3: Перевірка на від'ємні цикли ---
            
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

            foreach (var node in graph.Nodes)
            {
                foreach ()
            }
        }
    }
}
