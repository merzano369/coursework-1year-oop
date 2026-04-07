using System.Windows;
using System.Windows.Input;
using GraphPathfinder.Controllers;
using GraphPathfinder.Services;

namespace GraphPathfinder
{
    public partial class MainWindow : Window
    {
        private readonly GraphController _controller;
        private readonly GraphVisualizer _visualizer;

        public MainWindow()
        {
            InitializeComponent();
            _controller = new GraphController();
            _visualizer = new GraphVisualizer();
            
            InitializeAlgorithms();
        }

        private void InitializeAlgorithms()
        {
            AlgorithmSelector.Items.Add("Dijkstra");
            AlgorithmSelector.Items.Add("Bellman-Ford");
            AlgorithmSelector.Items.Add("A*");
            AlgorithmSelector.SelectedIndex = 0;
        }

        private void MainCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // logic to add nodes via controller
        }

        private void FindPathBtn_Click(object sender, RoutedEventArgs e)
        {
            StatusText.Text = "Calculating...";
            // logic to call controller.Solve
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            // logic to clear
            _visualizer.Visualize(_controller.CurrentGraph, MainCanvas);
        }

        private void ExportBtn_Click(object sender, RoutedEventArgs e)
        {
            // logic to export
        }
    }
}
