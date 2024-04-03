using My_Tetris_Game_2024_V1.__Globals;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace My_Tetris_Game_2024_V1._2_Deps._1_GameArea_Handler
{
    internal class GameArea_Handler
    {
        //---------------------------------------------------------------------
        public void handle_GameArea(Grid gameArea)
        {
            //--
            add_Required_Cols(gameArea);
            //--
            add_Required_Rows(gameArea);    
            //--

        }
        //---------------------------------------------------------------------
        private void add_Required_Cols(Grid gameArea)
        {
            for (int i = 0; i < Globals.No_Of_gameArea_Cols; i++)
            {
                //--
                ColumnDefinition col = new ColumnDefinition();
                //--
                gameArea.ColumnDefinitions.Add(col);
                //--
            }
        }
        //---------------------------------------------------------------------
        private void add_Required_Rows(Grid gameArea)
        {
            for (int i = 0; i < Globals.No_Of_gameArea_Rows; i++)
            {
                //--
                RowDefinition row = new RowDefinition();
                //--
                gameArea.RowDefinitions.Add(row);
                //--
            }
        }
       
   
    }
}

/// draw default shape
/// then get input to change
/// update the container
/// deliver it to drawer_In_gameArea.