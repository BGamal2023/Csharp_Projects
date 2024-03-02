using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Tetris_Game_2024.__Globals
{
    internal class Globals
    {
        //-----------------gameArea----------------------
        public static string gameArea_Name = "gameArea";
        public static Brush gameArea_Background = Brushes.Black;
        public static int gameArea_Height = 750;
        public static int gameArea_Width = 500;
        public static int No_Of_gameArea_Cols = 18;
        public static int No_Of_gameArea_Rows = 18;
        //------------------------------------------------
        public static Dictionary<string ,Image> li_Of_Blocks_Images= new Dictionary<string ,Image>();
    }
}
