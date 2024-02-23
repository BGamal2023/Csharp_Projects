using My_Snake_Game_2024._1_Managers;
using My_Snake_Game_2024.My_Libs.My_Lib_1;
using Snake_Game._2_Deps._3_Snake_Food_Handler;
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
using System.Windows.Threading;

namespace My_Snake_Game_2024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //----------------------------------------------------------------------------------------
        General_Manager obj_General_Manager = new General_Manager();
        Key_Strokes_Handler obj_Key_Strokes_Handler = new Key_Strokes_Handler();
        DispatcherTimer myTimer = new DispatcherTimer();
        Food_Posit_Handler obj_Food_Posit_Handler = new Food_Posit_Handler();
        //----------------------------------------------------------------------------------------
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                //--
                Grid gameArea = obj_General_Manager.start_The_Game(this);
                //--
                obj_General_Manager.handle_The_Snake_In_The_gameArea(myTimer, gameArea);
                //--
                List<int[]> positions = obj_Food_Posit_Handler.get_All_Positions_For_gameArea();
                obj_Food_Posit_Handler.print_All_gameArea_positions(positions);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);

            }

        }

        //-----------------------------------------------------------------------------------------
        private void handle_The_Keys_Strokes(object sender, KeyEventArgs e)
        {
            obj_Key_Strokes_Handler.handle_The_Keys_Strokes(e);
        }
    }
}