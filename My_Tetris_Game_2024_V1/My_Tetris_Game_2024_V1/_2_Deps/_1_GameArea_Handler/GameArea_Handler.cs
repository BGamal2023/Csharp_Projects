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
        public Grid gameArea = new Grid();
        //---------------------------------------------------------------------
        public Grid creat_And_Handle_The_GameArea()
        {
            set_Diemension_For_The_GameArea();
            //--
            add_Required_Cols();
            //--
            add_Required_Rows();    
            //--
            gameArea.ShowGridLines = true;
            gameArea.Background = Globals.gameArea_Background;
            return gameArea;
        }
        //---------------------------------------------------------------------
        private void add_Required_Cols()
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
        private void add_Required_Rows()
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
        //---------------------------------------------------------------------
        private void set_Diemension_For_The_GameArea()
        {
            gameArea.Width = Globals.gameArea_Width;
            gameArea.Height=Globals.gameArea_Height;
        }

    }
}

/// draw default shape
/// then get input to change
/// update the container
/// deliver it to drawer_In_gameArea.