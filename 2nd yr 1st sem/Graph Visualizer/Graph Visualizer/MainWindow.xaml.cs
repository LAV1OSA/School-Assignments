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
using Graph_Visualizer.Annotations;
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
        public GraphObject GraphObjects { get; set; }
        /*public  ObservableCollection<EdgesAsLines> EdgesAsShapes { get; set; }*/
        private bool _isDraggingVertex;
        
        public MainWindow()
        {
            InitializeComponent();
            /*VerticesAsShapes = new ObservableCollection<VertexAsEllipse>();
            EdgesAsShapes = new ObservableCollection<EdgesAsLines>();*/
            GraphObjects = new GraphObject();
            DataContext = this;
        }

        public MainWindow(Graph<string> graph) :this()
        {
            Graph = graph;
            for (int i = 0; i < graph.VertexCount; i++)
            {
                var vertexShape = new VertexAsEllipse(graph.Vertices[i]);
                GraphObjects.Vertices.Add(vertexShape);
                GraphObjects.Collection.Add(vertexShape);
            }
            
            foreach (var graphEdge in graph.Edges)
            {
                var from = GraphObjects.Vertices[graphEdge.From];
                var to = GraphObjects.Vertices[graphEdge.To];
                var edgeShape = new EdgesAsLines(from, to, graphEdge.Weight);
                GraphObjects.Edges.Add(edgeShape);
                GraphObjects.Collection.Add(edgeShape);
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
                    var vertexShape = new VertexAsEllipse(Graph.Vertices[i]);
                    GraphObjects.Vertices.Add(vertexShape);
                    GraphObjects.Collection.Add(vertexShape);
                }
                foreach (var graphEdge in Graph.Edges)
                {
                    var from = GraphObjects.Vertices[graphEdge.From];
                    var to = GraphObjects.Vertices[graphEdge.To];
                    var edgeShape = new EdgesAsLines(from, to, graphEdge.Weight);
                    GraphObjects.Edges.Add(edgeShape);
                    GraphObjects.Collection.Add(edgeShape);
                }
            }
            CmbBoxFrom.ItemsSource = Graph.Vertices;
            CmbBoxTo.ItemsSource = Graph.Vertices;
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
                var vertexShape = new VertexAsEllipse(TxtBoxAddVertex.Text);
                GraphObjects.Vertices.Add(vertexShape);
                GraphObjects.Collection.Add(vertexShape);
                CmbBoxFrom.ItemsSource = Graph.Vertices;
                CmbBoxTo.ItemsSource = Graph.Vertices;
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
                var newEdge = new Edge(int.Parse(input[0]), int.Parse(input[1]), float.Parse(input[2]));
                Graph.AddEdge(newEdge);
                var from = GraphObjects.Vertices[newEdge.From];
                var to = GraphObjects.Vertices[newEdge.To];
                var edgeShape = new EdgesAsLines(from, to, newEdge.Weight);
                GraphObjects.Edges.Add(edgeShape);
                GraphObjects.Collection.Add(edgeShape);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void BtnGetShortestPath_OnClick(object sender, RoutedEventArgs e)
        {
            var fromString = CmbBoxFrom.Text;
            var toString = CmbBoxTo.Text;
            var fromIndex = Graph.GetIndex(fromString);
            var toIndex = Graph.GetIndex(toString);
            var shortestPath = Graph.GetShortestPath(fromIndex);
            var prev = shortestPath.Prev[toIndex];
            var cost = shortestPath.Costs[toIndex];
            var searchOrder = new Stack<int>();
            searchOrder.Push(toIndex);
            while (prev != -1)
            {
                searchOrder.Push(prev);
                prev = shortestPath.Prev[prev];
            }

            var count = searchOrder.Count;
            var edgesInPath = new List<EdgesAsLines>();
            for (int i = 0; i < count - 1; i++)
            {
                var from = searchOrder.Pop();
                var to = searchOrder.Peek(); 
                edgesInPath.AddRange(GraphObjects.Edges.Where(
                    c => 
                        (c.From == GraphObjects.Vertices[from] &&
                        c.To == GraphObjects.Vertices[to]) || 
                        (c.From == GraphObjects.Vertices[to] &&
                         c.To == GraphObjects.Vertices[from])
                    ));
            }

            foreach (var graphObjectsEdge in GraphObjects.Edges)
            {
                graphObjectsEdge.Color = Brushes.DimGray;
            }
            foreach (var edge in edgesInPath)
            {
                edge.Color = Brushes.LawnGreen;
            }
        }
    }
    /// <summary>
    /// An Edge class that aids in displaying the edge as lines in the canvas
    /// </summary>
    public class EdgesAsLines : INotifyPropertyChanged
    {
        private double _zIndex = 5;
        private double _left = 0;
        private double _top = 0;
        private double _x1 = 100;
        private double _y1 = 100;
        private double _x2 = 100;
        private double _y2 = 100;
        private float _weight = 0;
        private Brush _color = Brushes.DimGray;
        private VertexAsEllipse _from;
        private VertexAsEllipse _to;

        public VertexAsEllipse From
        {
            get => _from;
            set
            {
                _from = value;
                
                OnPropertyChanged();
            }
        }
        public VertexAsEllipse To
        {
            get => _to;
            set
            {
                _to = value;
                OnPropertyChanged();
            }
        }
        public double ZIndex
        {
            get => _zIndex;
            set
            {
                _zIndex = value;
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
        public double Top
        {
            get => _top;
            set
            {
                _top = value;
                OnPropertyChanged();
            }
        }
        public double X1
        {
            get => _x1;
            set
            {
                _x1 = value;
                OnPropertyChanged();
            }
        }

        public double Y1
        {
            get => _y1;
            set
            {
                _y1 = value;
                OnPropertyChanged();
            }
        }
        public double X2
        {
            get => _x2;
            set
            {
                _x2 = value;
                OnPropertyChanged();
            }
        }
       
        public double Y2
        {
            get => _y2;
            set
            {
                _y2 = value;
                OnPropertyChanged();
            }
        }
        public float Weight
        {
            get => _weight;
            set
            {
                _weight = value;
                OnPropertyChanged();
            }
        }
        public Brush Color
        {
            get => _color;
            set
            {
                _color = value;
                OnPropertyChanged();
            }
        }
        public EdgesAsLines(VertexAsEllipse from,VertexAsEllipse to, float weight)
        {
            _from = from;
            _to = to;
            _weight = weight;
            ChangeCoordinates();
        }

        public void ChangeCoordinates()
        {
            var x1 = From.Left + From.Radius;
            var x2 = To.Left + To.Radius;
            var y1 = From.Top + From.Radius;
            var y2 = To.Top + To.Radius;
            var lesserX = Math.Min(x1, x2);
            var lesserY = Math.Min(y1, y2);
            _top = lesserY;
            _left = lesserX;
            _x1 = x1 - _left;
            _y1 = y1 - _top;
            _x2 = x2 - _left;
            _y2 = y2 - _top;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    /// <summary>
    /// A Vertex Class that aids in displaying the vertex to the canvas dynamically
    /// </summary>
    public class VertexAsEllipse : INotifyPropertyChanged
    {
        private double _zIndex = 10;
        private double _top = 100;
        private double _left = 100;
        public int Radius = 10;
        public double ZIndex
        {
            get => _zIndex;
            set
            {
                _zIndex = value;
                OnPropertyChanged();
            }
        }
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
            Random r = new Random();
            int randLeft = r.Next(30, 1000);
            int randTop = r.Next(30, 800);
            VertexName = vertexVertexName;
            Top = randTop;
            Left = randLeft;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    /// <summary>
    /// Contains collection of both edges and vertices to be added to the canvas
    /// </summary>
    public class GraphObject : INotifyPropertyChanged
    {
        ObservableCollection<VertexAsEllipse> _vertices = new ObservableCollection<VertexAsEllipse>();
        ObservableCollection<EdgesAsLines> _edges = new ObservableCollection<EdgesAsLines>();
        CompositeCollection collection = new CompositeCollection();
        public event PropertyChangedEventHandler? PropertyChanged;
        public CompositeCollection Collection
        {
            get
            {
                return collection;
            }

            set
            {
                collection = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<EdgesAsLines> Edges
        {
            get
            {
                return _edges;
            }

            set
            {
                _edges = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<VertexAsEllipse> Vertices
        {
            get
            {
                return _vertices;
            }

            set
            {
                _vertices = value;
                OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
