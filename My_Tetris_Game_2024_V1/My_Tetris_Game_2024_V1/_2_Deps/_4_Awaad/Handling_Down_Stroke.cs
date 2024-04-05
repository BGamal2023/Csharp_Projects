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
        Handling_Down_Collision obj_Handling_Down_Collision=new Handling_Down_Collision();

        public void handle_Down_Strokes(List<My_Rect_For_Shapes> currFrame)
        {
          
            //----
            obj_Handling_Down_Collision.handle_Down_Collision(currFrame);
            //----
            if (Globals.D_Collision != true)
            {
                foreach (My_Rect_For_Shapes i_My_Rect in currFrame)
                {
                    i_My_Rect.row++;
                }

            }
            //----

        }
        //-------------------------------------------------------------------------------------------

    }
}
