using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace test
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
        //----------------------------------------------------------------
        private void RecreateLines()
        {
            if (this.ActualWidth == 0 || this.ActualHeight == 0)
            {
                return;
            }

            double cellWidth = this.ActualWidth / (this.LineThickness * this.Columns);
            this.verticalLines.Viewbox = new Rect(0, 0, cellWidth, 1);

            double cellHeight = this.ActualHeight / (this.LineThickness * this.Rows);
            this.horizontalLines.Viewbox = new Rect(0, 0, 1, cellHeight);

            double qv = (1d - this.LineThickness / this.ActualWidth) / this.Columns;
            this.verticalLines.Viewport = new Rect(0, 0, qv, 1);

            double qh = (1d - this.LineThickness / this.ActualHeight) / this.Rows;
            this.horizontalLines.Viewport = new Rect(0, 0, 1, qh);
        }
    }
}