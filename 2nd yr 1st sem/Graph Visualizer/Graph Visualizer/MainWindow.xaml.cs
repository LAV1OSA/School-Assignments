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
        public ObservableCollection<Vertex> VerticesAsShapes { get; set; }
        public ObservableCollection<Vertex> EdgesAsShapes { get; set; }
        private bool _isDraggingVertex;

        public MainWindow()
        {
            InitializeComponent();
            VerticesAsShapes = new ObservableCollection<Vertex>();
            DataContext = this;
        }

        public MainWindow(Graph<string> graph) :this()
        {
            Graph = graph;
            for (int i = 0; i < graph.VertexCount; i++)
            {
                VerticesAsShapes.Add(new Vertex(graph.Vertices[i],i));
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
                    VerticesAsShapes.Add(new Vertex(Graph.Vertices[i], i));
                }
            }
        }
        /*private void ViewBox_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            UpdateViewBox((e.Delta > 0) ? 5 : -5);
        }

        private void UpdateViewBox(int i)
        {
            if ((VBoxMain.Width >= 0) && VBoxMain.Height >= 0)
            {
                VBoxMain.Width += i;
                VBoxMain.Height += i;
            }
        }*/
        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse vertex = e.Source as Ellipse;
            _isDraggingVertex = true;
            vertex.CaptureMouse();
        }

        private void Ellipse_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Ellipse vertex = e.Source as Ellipse;
            _isDraggingVertex = false;
            vertex.ReleaseMouseCapture();
        }
        private void Ellipse_MouseMove(object sender, MouseEventArgs e)
        {
            Ellipse vertex = e.Source as Ellipse;
            Vertex vertexFromSource = VerticesAsShapes[0];
            foreach (var vertexAsShape in VerticesAsShapes)
            {
                if (vertexAsShape.VertexName == vertex.Name)
                {
                    vertexFromSource = vertexAsShape;
                }
            }
            
            if (!_isDraggingVertex) return;

            // get the position of the mouse relative to the Canvas
            var mousePos = e.GetPosition(CanvasMain);

            // center the rect on the mouse
            if (mousePos.X < ViewBox.ActualWidth - vertex.ActualWidth/2 
                && mousePos.X > vertex.ActualWidth/2
                && mousePos.Y > vertex.ActualHeight/2
                && mousePos.Y < ViewBox.ActualHeight - vertex.ActualHeight / 2)
            {
                vertexFromSource.Left = mousePos.X - (vertex.ActualWidth / 2);
                vertexFromSource.Top = mousePos.Y - (vertex.ActualHeight / 2);
            }

        }
        private void BtnAddVertex_OnClick(object sender, RoutedEventArgs e)
        {
        }

    }

    public class Vertex : INotifyPropertyChanged
    {
        private double _top = 100;
        private double _left = 100;
        /*
        private Geometry _pathData;
        */
        public double Top
        {
            get => _top;
            set
            {
                _top = value;
                OnPropertyChanged();
            }
        }

        public double Left {
            get => _left;
            set
            {
                _left = value;
                OnPropertyChanged();
            }
        }
        public string VertexName { get; set; }
        public int Index { get; set; }
        /*public Geometry PathData {
            get => _pathData;
            set
            {
                _pathData = value;
                OnPropertyChanged();
            }
        }*/

        public event PropertyChangedEventHandler? PropertyChanged;

        public Vertex(string vertexVertexName, int index)
        {
            /*EllipseGeometry myEllipseGeometry = new EllipseGeometry();
            myEllipseGeometry.RadiusX = 25;
            myEllipseGeometry.RadiusY = 25;
            */

            VertexName = vertexVertexName;
            Index = index;
            Top = 20;
            Left = 20;
            /*
            PathData = myEllipseGeometry;
        */
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
