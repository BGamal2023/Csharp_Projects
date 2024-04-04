using My_Tetris_Game_2024_V1._2_Deps._2_Canvas_Area_Handler;
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
        public static int mainWindow_Height = 700;
        //-----------------gameArea----------------
        public static string gameArea_Name = "gameArea";
        public static Brush gameArea_Background = Brushes.Black;
        public static int gameArea_Height = 700;
        public static int gameArea_Width = 350;
        public static int No_Of_gameArea_Cols = 17;
        public static int No_Of_gameArea_Rows = 34;
        public static int timerTick = 1000;
        //-----------------Blocks-------------------
        public static int block_piece_Hight = 20;
        public static int block_piece_Width = 20;
        //----------------Canvas Block--------------
        public static Dictionary<int ,Canvas_Block> dic_Canvas_Blocks= new Dictionary<int ,Canvas_Block>();
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
