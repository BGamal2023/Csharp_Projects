using My_Tetris_Game_2024.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Tetris_Game_2024.A_2_Deps.A_5_Tetris_Blocks_Handler
{
    internal class Selector_Shapes
    {
        //---------------------------------------------------------------------------------------
        public void detect_The_Shape_That_Should_Be_Drawen()
        {


            switch (Globals.reqShape)
            {
                case 0:
                    Globals.does_I_Shape_Selected= true; break;
                case 1:
                    Globals.does_O_Shape_Selected= true; break;
                case 2: 
                    Globals.does_J_Shape_Selected = true; break;
                case 3:
                    Globals.does_L_Shape_Selected=(true); break;
                case 4:
                    Globals.does_S_Shape_Selected=(true); break;
                case 5:
                    Globals.does_T_Shape_Selected=((true)); break;
                case 6:
                    Globals.does_Z_Shape_Selected=true; break;

            }



            if (Globals.isUP == true)
            {
                Globals.req_Inner_Shape++;
                if (Globals.req_Inner_Shape > 4)
                {
                    Globals.req_Inner_Shape = 0;
                }
                Globals.isUP = false;
            }
        }
        //---------------------------------------------------------------------------------------
        public void get_The_Required_Inner_Shape_Type_For_Current_Shown_Tetris()
        {
            if (Globals.isUP == true)
            {
                Globals.req_Inner_Shape++;
                if (Globals.req_Inner_Shape > 4)
                {
                    Globals.req_Inner_Shape = 0;
                }
                Globals.isUP = false;
            }
        }
        //---------------------------------------------------------------------------------------
        public void fill_The_Container_With_Required_Shape()
        {

        }

    }
}
