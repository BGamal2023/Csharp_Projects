using My_Tetris_Game_2024.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Tetris_Game_2024.A_2_Deps.A_5_Tetris_Blocks_Handler
{
    internal class Tetris_Shapes_Manager
    {
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
    }
}
