using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Graphs;
using Path = Graphs.Path;

namespace Graph_Visualizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public FileDataProvider<string> DataProvider = new FileDataProvider<string>();
        public Graph<string> Graph { get; set; }
        public ObservableCollection<VertexAsEllipse> VerticesAsShapes { get; set; }
        private bool _isDraggingVertex;

        public MainWindow()
        {
            InitializeComponent();
            VerticesAsShapes = new ObservableCollection<VertexAsEllipse>();
            DataContext = this;
        }

        public MainWindow(Graph<string> graph) :this()
        {
            Graph = graph;
            for (int i = 0; i < graph.VertexCount; i++)
            {
                VerticesAsShapes.Add(new VertexAsEllipse(graph.Vertices[i]));
            }
        }
        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (Graph == null)
            {
                DataProvider.CreateGraphFromFile("../../../../Vertex Data.txt", "../../../../Edge Data.txt");
                Graph = DataProvider.Graph;
                for (int i = 0; i < Graph.VertexCount; i++)
                {
                    VerticesAsShapes.Add(new VertexAsEllipse(Graph.Vertices[i]));
                }
            }
        }
        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse vertex = sender as Ellipse;
            _isDraggingVertex = true;
            vertex.CaptureMouse();
        }

        private void Ellipse_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Ellipse vertex = sender as Ellipse;
            _isDraggingVertex = false;
            vertex.ReleaseMouseCapture();
        }
        private void Ellipse_MouseMove(object sender, MouseEventArgs e)
        {
            Ellipse vertex = sender as Ellipse;
            VertexAsEllipse vertexAsEllipseFromSource = vertex.DataContext as VertexAsEllipse;//Gets the data source from the collection of VerticesAsShapes

            if (!_isDraggingVertex) return;

            // get the position of the mouse relative to the Canvas
            var mousePos = e.GetPosition(CanvasMain);

            // center the rect on the mouse
            if (mousePos.X < ViewBox.ActualWidth - vertex.ActualWidth/2 
                && mousePos.X > vertex.ActualWidth/2
                && mousePos.Y > vertex.ActualHeight/2
                && mousePos.Y < ViewBox.ActualHeight - vertex.ActualHeight / 2)
            {
                vertexAsEllipseFromSource.Left = mousePos.X - (vertex.ActualWidth / 2);
                vertexAsEllipseFromSource.Top = mousePos.Y - (vertex.ActualHeight / 2);
            }

        }
        private void BtnAddVertex_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Graph.AddVertex(TxtBoxAddVertex.Text);
                VerticesAsShapes.Add(new VertexAsEllipse(TxtBoxAddVertex.Text));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }

        private void BtnAddEdge_OnClick(object sender, RoutedEventArgs e)
        {
            var input = TxtBoxAddEdge.Text.Split(",");
            try
            {
                Graph.AddEdge(new Edge(int.Parse(input[0]), int.Parse(input[1]), float.Parse(input[2])));
                VerticesAsShapes.Add(new VertexAsEllipse(TxtBoxAddVertex.Text));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
    /// <summary>
    /// A Vertex Class that aids in displaying the vertex to the canvas dynamically
    /// </summary>
    public class VertexAsEllipse : INotifyPropertyChanged
    {
        private double _top = 100;
        private double _left = 100;
        public double Top
        {
            get => _top;
            set
            {
                _top = value;
                OnPropertyChanged();
            }
        }

        public double Left
        {
            get => _left;
            set
            {
                _left = value;
                OnPropertyChanged();
            }
        }
        public string VertexName { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;

        public VertexAsEllipse(string vertexVertexName)
        {
            VertexName = vertexVertexName;
            Top = 20;
            Left = 20;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
