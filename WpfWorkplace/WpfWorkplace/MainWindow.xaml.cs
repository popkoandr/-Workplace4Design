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

namespace WpfWorkplace
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Brush drawingBrush = Brushes.AliceBlue;
        private Brush selectedDrawingBrush = Brushes.LightGoldenrodYellow;
        private Pen drawingPen = new Pen(Brushes.SteelBlue, 3);
        private Size squareSize = new Size(30, 30);


        private void drawingSurface_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var pointClicked = e.GetPosition(drawingSurface);

            DrawingVisual visual = new DrawingVisual();
            DrawSquare(visual, pointClicked, false);
            drawingSurface.AddVisual(visual);
            //  MessageBox.Show("Hello2!");
        }



        private void DrawSquare(DrawingVisual visual, Point pointClicked, bool v)
        {
           using (DrawingContext dc = visual.RenderOpen())
            {
                Brush brush = drawingBrush;
                dc.DrawRectangle(brush, drawingPen, new Rect(pointClicked, squareSize));
            }
        }
    }
}
