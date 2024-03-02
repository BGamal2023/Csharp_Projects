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
using Tetris_Game_2024.A_1_General_Manager;
using Tetris_Game_2024.A_2_Dep.A_4_GameArea_Handling;
namespace Tetris_Game_2024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //----------------------------------------------------------------------------------------
        private General_Manager obj_General_Manager=new General_Manager();
        DispatcherTimer gameTimer =new DispatcherTimer();
        Image BodyImage;
        int speed = 1;
        GameArea_Handing obj_GameArea_Handing = new GameArea_Handing();

        //----------------------------------------------------------------------------------------
        public MainWindow()
        {
            InitializeComponent();
            //----------------------------------------------
            gameTimer.Interval = System.TimeSpan.FromMicroseconds(1000);
            gameTimer.Tick += timerTick;
            gameTimer.Start();
            //------------------------------------------------
            obj_GameArea_Handing.handle_The_Game_Area(gameArea);
            //----------------------------------------------
            var uri = new System.Uri("E:\\Programming\\12_C#\\Csharp_Projects\\Tetris_Game_2024\\Tetris_Game_2024\\Assets\\Block-O.png");
            var converted = uri.AbsoluteUri;
            string BodyName = "Body";
             BodyImage = new Image
            {
                Width = 50,
                Height = 50,
                Name = BodyName,
                Source = new BitmapImage(new Uri(converted)),
            };
            //------------------------------------------------------------
            var uri2 = new System.Uri("E:\\Programming\\12_C#\\Csharp_Projects\\Tetris_Game_2024\\Tetris_Game_2024\\Assets\\Background.png");
            var converted2 = uri2.AbsoluteUri;
      
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri(converted2));
            this.Background = myBrush;


            //-----------------------------------------------------
            gameArea.Children.Add(BodyImage);
            Canvas.SetTop(BodyImage, 0);
            Canvas.SetLeft(BodyImage, 50);
            nextImage.DataContext= BodyImage;
           



        }

        private void timerTick(object? sender, EventArgs e)
        {

            speed+=5;
                Canvas.SetTop(BodyImage,speed);
            Canvas.SetLeft(BodyImage, 50);
         
        }

        private void handle_The_Key_Strokes(object sender, KeyEventArgs e)
        {
             
        }
    }
}