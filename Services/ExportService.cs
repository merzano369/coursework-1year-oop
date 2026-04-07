using System.IO;
using GraphPathfinder.Models;

namespace GraphPathfinder.Services
{
    public class ExportService
    {
        public void ExportPath(PathResult result, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Path Result - Total Distance: {result.TotalDistance}");
                writer.WriteLine($"Execution Time: {result.ExecutionTimeMs} ms");
                writer.WriteLine("Nodes:");
                foreach (var node in result.Path)
                    writer.WriteLine(node.Id);
            }
        }
    }
}
