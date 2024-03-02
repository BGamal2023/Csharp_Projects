using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris_Game_2024._A_2_Dep.A_0_MainWindow_Handling;
using Tetris_Game_2024.A_2_Dep.A_3_Assets_Images_Handler;

namespace Tetris_Game_2024.A_1_General_Manager
{
    internal class General_Manager
    {
        //----------------------------------------------------------------------------
        private Handle_The_GameArea obj_Handle_The_GameArea=new Handle_The_GameArea();
        private Assets_Images_Handler obj_Assets_Images_Handler=new Assets_Images_Handler();
        //----------------------------------------------------------------------------
        public void main_Method(MainWindow mWindow)
        {   //--
            obj_Handle_The_GameArea.handle_The_Game_Area(mWindow);
            //--
            handle_Assets_Photos();
            //--

        }
        //----------------------------------------------------------------------------
        private void handle_Assets_Photos()
        {
            obj_Assets_Images_Handler.get_All_Blocks_Images_From_Assets_Folder_And_Add_Them_To_The_Dictionary();
        }
    }
}
