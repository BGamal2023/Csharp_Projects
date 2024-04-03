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

namespace My_Tetris_Game_2024_V1._2_Deps._0_MainWindow_Handler
{
    internal class MainWindow_Handler
    {
        //----------------------------------------------------------------------------
        public void handle_mainWindow(MainWindow mWindow)
        {
            //--
            show_The_Main_Window_In_The_Middle_Of_Screen(mWindow);
            //--
            set_mainWindow_Background(mWindow);
            //
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

    }
}
