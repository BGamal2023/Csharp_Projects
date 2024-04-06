using My_Tetris_Game_2024_V1.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using My_Tetris_Game_2024_V1;
using My_Tetris_Game_2024_V1._2_Deps._1_GameArea_Handler;

namespace My_Tetris_Game_2024_V1._2_Deps._0_MainWindow_Handler
{
    internal class MainWindow_Handler
    {
        
        //---------------------------------------------------------------------------
        private GameArea_Handler obj_GameArea_Handler=new GameArea_Handler();
        //----------------------------------------------------------------------------
        public void handle_mainWindow(MainWindow mWindow,Grid gameArea)
        {
            //--
            show_The_Main_Window_In_The_Middle_Of_Screen(mWindow);
            //--
            // set_mainWindow_Background(mWindow);
            //--
            set_Diemenstions_For_mainWindow(mWindow);
            //--
            add_The_Grid_Game_Area_To_MainWindow(mWindow ,gameArea);
            //--
        }
        //----------------------------------------------------------------------------
        private void set_mainWindow_Background(MainWindow mWindow)
        {
            
            string imagePath = "E:\\Programming\\12_C#\\Csharp_Projects\\Resources\\Background.png";  
            ImageSource imageSource = new BitmapImage(new Uri(imagePath, UriKind.Absolute));

            // Set the window background
           mWindow.Background = new ImageBrush(imageSource);
        }
        //----------------------------------------------------------------------------
        private void show_The_Main_Window_In_The_Middle_Of_Screen(MainWindow mWindow)
        {
            mWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        //----------------------------------------------------------------------------
        private void add_The_Grid_Game_Area_To_MainWindow(MainWindow mWindow,Grid gameArea)
        {
          
          mWindow.Content = gameArea;


        }
        //----------------------------------------------------------------------------
        private void set_Diemenstions_For_mainWindow(MainWindow mWindow)
        {
            mWindow.Width = Globals.mainWindow_Width;
            mWindow.Height = Globals.mainWindow_Height;
        }
    }
}
