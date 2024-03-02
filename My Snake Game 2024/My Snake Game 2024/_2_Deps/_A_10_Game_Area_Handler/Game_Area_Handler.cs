using My_Snake_Game_2024.__Globals;
using My_Snake_Game_2024.My_Libs.My_Lib_1;
using My_Snake_Game_2024;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace My_Snake_Game_2024._2_Deps._A_10_Game_Area_Handler
{
    internal class Game_Area_Handler
    {
        //-------------------------------------------------------------------------------------
        #region The Fields
        private Grid gameArea = new Grid();
        private const string handle_The_Keys_Strokes = "handle_The_Keys_Strokes";
        private Key_Strokes_Handler obj_Key_Strokes_Handler=new Key_Strokes_Handler();
        #endregion
        //-------------------------------------------------------------------------------------
        public Grid handle_The_Game_Area(MainWindow mainwindow)
        {
            //--
            create_And_Add_Grid(mainwindow);
            //--
            add_Required_Cols();
            //--
            add_Required_Rows();
            //--
            return gameArea;
        }
        //-------------------------------------------------------------------------------------
        private void create_And_Add_Grid(MainWindow mainwindow)
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
            mainwindow.Content = gameArea;
            //--
            gameArea.Focus();
            //--
        }
        //-------------------------------------------------------------------------------------
        private void add_Required_Cols()
        {
           for(int i=0; i < Globals.No_Of_gameArea_Cols; i++)
            {
                //--
                ColumnDefinition col = new ColumnDefinition();
                //--
                gameArea.ColumnDefinitions.Add(col);
                //--
            }
        }
        //-------------------------------------------------------------------------------------
        private void add_Required_Rows()
        {
            for(int i = 0; i < Globals.No_Of_gameArea_Rows; i++)
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
