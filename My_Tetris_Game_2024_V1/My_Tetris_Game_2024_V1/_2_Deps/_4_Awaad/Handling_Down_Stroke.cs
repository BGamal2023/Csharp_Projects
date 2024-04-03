using My_Tetris_Game_2024_V1.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Tetris_Game_2024_V1._2_Deps._4_Awaad
{
    internal class Handling_Down_Stroke
    {

        public void handle_Down_Strokes(List<My_Rect_For_Shapes> currFrame)
        {
            Globals.L_Collision = false;
            if (Globals.D_Collision != true)
            {
                foreach (My_Rect_For_Shapes i_My_Rect in currFrame)
                {
                    i_My_Rect.row++;
                }

            }

        }
        //-------------------------------------------------------------------------------------------
       
    }
}
