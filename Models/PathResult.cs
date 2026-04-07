using System.Collections.Generic;

namespace GraphPathfinder.Models
{
    public class PathResult
    {
        public List<Node> Path { get; }
        public double TotalDistance { get; }
        public long ExecutionTimeMs { get; set; } 
        public string ErrorMessage { get; } 
        public bool IsSuccess => ErrorMessage == null;

        // Конструктор для успішного результату
        public PathResult(List<Node> path, double totalDistance, long executionTimeMs)
        {
            Path = path;
            TotalDistance = totalDistance;
            ExecutionTimeMs = executionTimeMs;
            ErrorMessage = null;
        }

        // Конструктор для помилки (шлях не знайдено, від'ємний цикл тощо)
        public PathResult(string errorMessage)
        {
            Path = new List<Node>();
            TotalDistance = double.PositiveInfinity;
            ExecutionTimeMs = 0;
            ErrorMessage = errorMessage;
        }
    }
}
