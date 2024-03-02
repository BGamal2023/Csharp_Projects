using My_Snake_Game_2024.__Globals;
using My_Snake_Game_2024._2_Deps._9_List_Of_Snake_Pieces_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace My_Snake_Game_2024._2_Deps._5_Game_Levels_Handler
{
    internal class Game_Level_Handler
    {
        //-----------------------------------------------------------------------------------------------
        #region The Fields
        List_Of_Snake_Pieces_Handler obj_List_Of_Snake_Parts_Handler =new List_Of_Snake_Pieces_Handler();
        #endregion
        //-----------------------------------------------------------------------------------------------
        #region The Main Method
        public void update_Game_Level(DispatcherTimer gameTimer)
        {
            //--
            int no_Of_Pieces_Of_The_Snake = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_The_Snake_Pieces();
            //--
            run_Level_1(no_Of_Pieces_Of_The_Snake, gameTimer);
            //--
            run_Leve_2(no_Of_Pieces_Of_The_Snake, gameTimer);
            //--
            run_Level_3(no_Of_Pieces_Of_The_Snake,gameTimer);
            //--
        }
        #endregion
        //-----------------------------------------------------------------------------------------------
        #region Auxilaries Methods
        private void run_Level_1(int no_Of_Pieces_Of_The_Snake,DispatcherTimer gameTimer)
        {
            if (no_Of_Pieces_Of_The_Snake == Globals.Score_Level_1)
            {   
                //--
                Globals.Level = 1;
                //--
                Globals.timerTick = Globals.level_1_speed;
                //--
                gameTimer.Interval = TimeSpan.FromMilliseconds(Globals.timerTick);
                //--
            }

        }
        //-----------------------------------------------------------------------------------------------
        private void run_Leve_2(int no_Of_Pieces_Of_The_Snake, DispatcherTimer gameTimer) {

             if (no_Of_Pieces_Of_The_Snake == Globals.Score_Level_2)
            {
                //--
                Globals.Level = 2;
                //--
                Globals.timerTick = Globals.level_2_speed;
                //--
                gameTimer.Interval = TimeSpan.FromMilliseconds(Globals.timerTick);
                //--
            }

        }
        //-----------------------------------------------------------------------------------------------
        private void run_Level_3(int no_Of_Pieces_Of_The_Snake, DispatcherTimer gameTimer)
        {
            if (no_Of_Pieces_Of_The_Snake == Globals.Score_Level_3)
            {
                //--
                Globals.Level = 3;
                //--
                Globals.timerTick = Globals.level_3_speed;
                //--
                gameTimer.Interval = TimeSpan.FromMilliseconds(Globals.timerTick);
                //--
            }
        }
        //-----------------------------------------------------------------------------------------------
        #endregion
        //-----------------------------------------------------------------------------------------------
    }
}
