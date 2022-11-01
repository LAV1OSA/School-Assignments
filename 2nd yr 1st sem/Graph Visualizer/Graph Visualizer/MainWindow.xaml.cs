using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Graph_Visualizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isDraggingVertex;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse Vertex = e.Source as Ellipse;
            _isDraggingVertex = true;
            Vertex.CaptureMouse();
        }

        private void Ellipse_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Ellipse Vertex = e.Source as Ellipse;
            _isDraggingVertex = false;
            Vertex.ReleaseMouseCapture();
        }
        private void Ellipse_MouseMove(object sender, MouseEventArgs e)
        {
            Ellipse Vertex = e.Source as Ellipse;

            if (!_isDraggingVertex) return;

            // get the position of the mouse relative to the Canvas
            var mousePos = e.GetPosition(CanvasMain);

            // center the rect on the mouse
            double left = mousePos.X - (Vertex.ActualWidth / 2);
            double top = mousePos.Y - (Vertex.ActualHeight / 2);
            Canvas.SetLeft(Vertex, left);
            Canvas.SetTop(Vertex, top);
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

        private void BtnAddVertex_Click(object sender, MouseButtonEventArgs e)
        {
            /*Shape shape = new Ellipse()
           {
               Height = 50F,
               Width = 50F,
               Fill = Brushes.Aqua,

           };
           Panel.SetZIndex(shape, 5);
           Canvas.SetLeft(shape,100);
           Canvas.SetTop(shape,100);
           CanvasMain.Children.Add(shape);*/
        }

    }
}
