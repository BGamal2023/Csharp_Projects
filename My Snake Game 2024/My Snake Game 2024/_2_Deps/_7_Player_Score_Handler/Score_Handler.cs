using My_Snake_Game_2024.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace My_Snake_Game_2024._2_Deps._7_Player_Score_Handler
{
    internal class Score_Handler
    {
        //----------------------------------------------------------------------------------------
        public void update_Player_Sore(Label scoreValue)
        {
            scoreValue.Content = Globals.Score;
        }
        //----------------------------------------------------------------------------------------
    }
}
