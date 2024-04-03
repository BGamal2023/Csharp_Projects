using My_Tetris_Game_2024.__Globals;
using My_Tetris_Game_2024.A_2_Deps.A_5_Tetris_Shapes_Handler;
using My_Tetris_Game_2024.A_2_Deps.A_6_Creating_Rect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace My_Tetris_Game_2024.A_2_Deps.A_7_Canvas_Blocks
{
    internal class Creating_The_Canvas_Blocks
    {
        private Creating_Rect obj_Creating_Rect=new Creating_Rect();
        //---------------------------------------------------------------------
        public void create_The_Canvas_Blocks()
        {
            Canvas_Blocks cavasBlock_0 = new Canvas_Blocks(7, 0);
            Canvas_Blocks cavasBlock_1 = new Canvas_Blocks(8, 0);
            Canvas_Blocks cavasBlock_2 = new Canvas_Blocks(9, 0);
            Canvas_Blocks cavasBlock_3 = new Canvas_Blocks(7, 1);
            Canvas_Blocks cavasBlock_4 = new Canvas_Blocks(8, 1);
            Canvas_Blocks cavasBlock_5 = new Canvas_Blocks(9, 1);
            Canvas_Blocks cavasBlock_6 = new Canvas_Blocks(7, 2);
            Canvas_Blocks cavasBlock_7 = new Canvas_Blocks(8, 2);
            Canvas_Blocks cavasBlock_8 = new Canvas_Blocks(9, 2);
            Globals.dic_Canvas_Blocks.Add(0, cavasBlock_0);
            Globals.dic_Canvas_Blocks.Add(1, cavasBlock_1);
            Globals.dic_Canvas_Blocks.Add(2, cavasBlock_2);
            Globals.dic_Canvas_Blocks.Add(3, cavasBlock_3);
            Globals.dic_Canvas_Blocks.Add(4, cavasBlock_4);
            Globals.dic_Canvas_Blocks.Add(5, cavasBlock_5);
            Globals.dic_Canvas_Blocks.Add(6, cavasBlock_6);
            Globals.dic_Canvas_Blocks.Add(7, cavasBlock_7);
            Globals.dic_Canvas_Blocks.Add(8, cavasBlock_8);

        }
        //---------------------------------------------------------------------
    }
}
