using Grid_Test.My_Libs.My_Lib_1;
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

namespace My_Snake_Game_2024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //----------------------------------------------------------------------------------------
        Key_Strokes_Handler obj_Key_Strokes_Handler = new Key_Strokes_Handler();

        //----------------------------------------------------------------------------------------
        public MainWindow()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------------------
        private void handle_The_Keys_Strokes(object sender, KeyEventArgs e)
        {
            obj_Key_Strokes_Handler.handle_The_Keys_Strokes(e);
        }
    }
}