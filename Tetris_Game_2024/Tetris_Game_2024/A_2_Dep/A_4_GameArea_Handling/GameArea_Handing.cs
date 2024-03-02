using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Tetris_Game_2024.__Globals;
using Tetris_Game_2024.My_Libs.My_Lib_1;

namespace Tetris_Game_2024.A_2_Dep.A_4_GameArea_Handling
{
    internal class GameArea_Handing
    {
        //-------------------------------------------------------------------------------------
        public void handle_The_Game_Area(Grid gameArea)
        {
            //--
            add_Required_Cols(gameArea);
            //--
            add_Required_Rows(gameArea);
            //--
        }
        //-------------------------------------------------------------------------------------
        private void create_And_Add_Grid(Grid gameArea)
        {
            //--
            gameArea.Name = Globals.gameArea_Name;
            gameArea.Focusable = true;
            gameArea.Background = Globals.gameArea_Background;
            gameArea.Height = Globals.gameArea_Height;
            gameArea.Width = Globals.gameArea_Width;
            gameArea.ShowGridLines = true;
            gameArea.HorizontalAlignment = HorizontalAlignment.Left;
            gameArea.VerticalAlignment = VerticalAlignment.Top;
            //--
        }
        //-------------------------------------------------------------------------------------
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
        //-------------------------------------------------------------------------------------
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
        //-------------------------------------------------------------------------------------
    }
}
