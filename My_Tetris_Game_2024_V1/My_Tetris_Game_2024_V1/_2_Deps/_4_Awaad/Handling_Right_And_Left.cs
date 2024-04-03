using My_Tetris_Game_2024_V1.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Tetris_Game_2024_V1._2_Deps._4_Awaad
{
    internal class Handling_Right_And_Left
    {

        public void handle_Righ_Strokes(List<My_Rect_For_Shapes> currFrame)
        {
            Globals.L_Collision = false;
            check_Righ_Collision(currFrame);
            if (Globals.R_Collision != true)
            {
                foreach (My_Rect_For_Shapes i_My_Rect in currFrame)
                {
                    i_My_Rect.col++;
                }

            }

        }
        //-------------------------------------------------------------------------------------------
        private  void check_Righ_Collision(List<My_Rect_For_Shapes> currFrame)
        {
            foreach (My_Rect_For_Shapes i_My_Rect in currFrame)
            {
                if (i_My_Rect.col >= 16)
                {
                    Globals.R_Collision = true;
                }

            }

        }
        //-------------------------------------------------------------------------------------------
        public void handle_Left_Strokes(List<My_Rect_For_Shapes> currFrame)
        {
            Globals.R_Collision = false;
            check_Left_Collision(currFrame);
            if (Globals.L_Collision != true)
            {
                foreach (My_Rect_For_Shapes i_My_Rect in currFrame)
                {
                    i_My_Rect.col--;
                }

            }
            

        }
        //-------------------------------------------------------------------------------------------
        private void check_Left_Collision(List<My_Rect_For_Shapes> currFrame)
        {
            foreach (My_Rect_For_Shapes i_My_Rect in currFrame)
            {
                if (i_My_Rect.col<= 0)
                {
                    Globals.L_Collision = true;
                }

            }

        }
        //-------------------------------------------------------------------------------------------

    }
}
