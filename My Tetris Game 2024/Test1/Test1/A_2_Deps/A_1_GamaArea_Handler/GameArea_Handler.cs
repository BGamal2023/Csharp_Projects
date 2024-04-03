using My_Tetris_Game_2024.__Globals;
using My_Tetris_Game_2024.A_2_Deps.A_8_Container_Class;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace My_Tetris_Game_2024.A_2_Deps.A_1_GamaArea_Handler
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
        //---------------------------------------------------------------------
        public void add_Blocks_Of_shape_To_The_GameArea(Grid gameArea)
        {
            for (int i = 0; i < Globals.the_current_Shape_In_gameArea.Count; i++)
            {
                Container_Class container = Globals.the_current_Shape_In_gameArea[i];
                Rectangle curr_Block = container.get_one_Piece_Of_Shape();
                gameArea.Children.Add(curr_Block);
            }
        }
        //---------------------------------------------------------------------
        public void set_Cols_And_Rows_For_The_Blocks_Of_Shapes()
        {
            for(int i = 0; i < Globals.the_current_Shape_In_gameArea.Count; i++)
            {
                //--
               Container_Class container = Globals.the_current_Shape_In_gameArea[i];
                Rectangle curr_Block=container.get_one_Piece_Of_Shape();
                //--
                Grid.SetColumn(curr_Block, container.get_curr_Col());
                Grid.SetRow(curr_Block, container.get_curr_Row());
                //--
            }
          
        }
        //---------------------------------------------------------------------
        public void initialize_First_Shape(Grid gameArea)
        {
            //--
            add_Blocks_Of_shape_To_The_GameArea(gameArea);
            //--
            set_Cols_And_Rows_For_The_Blocks_Of_Shapes();
            //--
        }
    }
}

/// draw default shape
/// then get input to change
/// update the container
/// deliver it to drawer_In_gameArea.