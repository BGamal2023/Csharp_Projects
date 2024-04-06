using My_Tetris_Game_2024_V1._2_Deps._4_Awaad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace My_Tetris_Game_2024_V1.__Globals
{
    class Globals
    {
        //-----------------MainWindow-------------
        public static int mainWindow_Width = 500;
        public static int mainWindow_Height = 900;
        //-----------------gameArea----------------
        public static string gameArea_Name = "gameArea";
        public static int gameArea_Width = 400;
        public static int gameArea_Height = 800;
        public static Brush gameArea_Background = Brushes.Black;
        public static int No_Of_gameArea_Cols = 16;
        public static int No_Of_gameArea_Rows = 32;
        public static int timerTick = 1000;
        //-----------------Blocks-------------------
        public static int block_piece_Hight = 25;
        public static int block_piece_Width = 25;
        //----------------Canvas Block--------------
        //----------------keys strokes handling----
        public static bool isUP = false;
        public static bool isDOWN = false;
        public static bool isLEFT = false;
        public static bool isRIGHT = false;
        //------------------------------------------
        public static int rect_1_Col = 8;
        public static int rect_2_Col = 8;
        public static int rect_3_Col = 8;
        public static int rect_4_Col = 9;
        public static int rect_1_Row = 0;
        public static int rect_2_Row = 1;
        public static int rect_3_Row = 2;
        public static int rect_4_Row = 2;
        //------------------------------------------
        public enum E_shapeType
        {
            I,S,O,T,L
        }
        //-------------------------------------------
        public static bool R_Collision = false;
        public static bool L_Collision = false; 
        public static bool D_Collision=false;
        //-----------------------------------------
        public static List<Rectangle> curr_frame_Rectangles=new List<Rectangle>();
        public static List<Container_For_Down_Collisied_Frames> base_Rectangles= new List<Container_For_Down_Collisied_Frames>();
    }
}
