using System;
using System.Collections.Generic;
using GraphPathfinder.Models;
using GraphPathfinder.Algorithms;

namespace GraphPathfinder.Controllers
{
    public class GraphController
    {
        private Graph _graph;
        private readonly AlgorithmEngine _engine;

        public GraphController()
        {
            _graph = new Graph();
            _engine = new AlgorithmEngine();
        }

        public PathResult Solve(IPathAlgorithm algorithm, Node start, Node target)
        {
            return _engine.Execute(algorithm, _graph, start, target);
        }

        public Graph CurrentGraph => _graph;
    }
}
