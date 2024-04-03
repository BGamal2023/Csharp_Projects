using My_Tetris_Game_2024.A_2_Deps.A_5_Tetris_Shapes_Handler;
using My_Tetris_Game_2024.A_2_Deps.A_7_Canvas_Blocks;
using My_Tetris_Game_2024.A_2_Deps.A_8_Container_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace My_Tetris_Game_2024.__Globals
{
    internal class Globals
    {
        //-----------------MainWindow----------------------
        public static int mainWindow_Width = 500;
        public static int mainWindow_Height = 700;



        //-----------------gameArea----------------------
        public static string gameArea_Name = "gameArea";
        public static Brush gameArea_Background = Brushes.Black;
        public static int gameArea_Height = 700;
        public static int gameArea_Width = 350;
        public static int No_Of_gameArea_Cols = 17;
        public static int No_Of_gameArea_Rows = 34;


        //-----------------Blocks-----------------------
        public static int block_piece_Hight = 20;
        public static int block_piece_Width= 20;
        public static int block_init_Row = 2;
        public static int block_init_col = 7;
        public static Dictionary<int, Rectangle> I_Block_Dic = new Dictionary<int, Rectangle>();
        //----------------keys strokes handling-------
        public static bool isUP=false;
        public static bool isDOWN=false;
        public static bool isLEFT=false;
        public static bool isRIGHT=false;
        //------------------------------------------

        public static int timerTick = 1000;
        public static Dictionary<int, Canvas_Blocks> dic_Canvas_Blocks = new Dictionary<int, Canvas_Blocks>();
        public static Dictionary<int, Rectangle> dic_Curr_Showen_Shape_Rectangles = new Dictionary<int, Rectangle>();
        public static Dictionary<int, Container_Class> the_current_Shape_In_gameArea = new Dictionary<int, Container_Class>();
       
        public static int reqShape = 0;
        public static int req_Inner_Shape = 0;
        //------------------------------------------

      

        //-------------------------------------------------------

        public enum En_CurrentShape
        {
            L_Shape=0,
            S_Shape=1,
            O_Shape=2,
            I_Shape=3,
            J_Shape=4,
            Z_Shape=5,
            T_Shape=6
        }
        public static bool does_L_Shape_Selected=false;
        public static bool does_S_Shape_Selected=false;
        public static bool does_O_Shape_Selected=false;
        public static bool does_I_Shape_Selected=false;
        public static bool does_J_Shape_Selected=false;
        public static bool does_Z_Shape_Selected=false;
        public static bool does_T_Shape_Selected=false;

        public static bool isCollision = false;



    }
}
