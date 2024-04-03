using My_Tetris_Game_2024.__Globals;
using My_Tetris_Game_2024.A_1_General_Manager;
using System.Diagnostics;
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

namespace My_Tetris_Game_2024
{
    
    public partial class MainWindow : Window
    {
        //------------------------------------------------------------------------------
        #region The Fields
        private General_Manager obj_General_Manager=new General_Manager();
        private DispatcherTimer gameTimer=new DispatcherTimer();
        #endregion
        //------------------------------------------------------------------------------
        public MainWindow()
        {
            //--
            InitializeComponent();
            //--
            obj_General_Manager.initialize_Window(this,gameArea);
            //--
            obj_General_Manager.initialize_The_Game(gameTimer, gameArea);
            //--
            set_Timer();
        }

      

        //------------------------------------------------------------------------------
        private void handle_Key_Down_Strokes(object sender, KeyEventArgs e)

        {
            switch (e.Key)
            {
                case Key.Up:

                    Globals.isUP = true;
                    Debug.WriteLine("Up arrow pressed");

                    break;
                case Key.Down:

                    Globals.isDOWN = true;
                    Debug.WriteLine("Down arrow pressed");

                    break;
                case Key.Left:
                    Globals.isLEFT = true;
                    Debug.WriteLine("Left arrow pressed");
                    break;
                case Key.Right:
                    Globals.isRIGHT = true;
                    Debug.WriteLine("Right arrow pressed");
                    break;
                default:

                    break;
            }
          
        }
        //------------------------------------------------------------------------------
        private void handle_The_Key_Up_Strokes(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up:

                    Globals.isUP = false;
                    Debug.WriteLine("is up =  " + Globals.isUP);

                    break;
                case Key.Down:

                    Globals.isDOWN = false;

                    break;
                case Key.Left:
                    Globals.isLEFT = false;

                    break;
                case Key.Right:
                    Globals.isRIGHT = false;

                    break;
                default:

                    break;
            }
        }
        //------------------------------------------------------------------------------
        private void set_Timer()
        {
            gameTimer.Interval = System.TimeSpan.FromMicroseconds(Globals.timerTick);
            gameTimer.Tick += timerTick;
            gameTimer.Start();
        }
        //------------------------------------------------------------------------------

        private void timerTick(object? sender, EventArgs e)
        {
            obj_General_Manager.Tick(gameTimer,gameArea);
        }
        //------------------------------------------------------------------------------

    }
}