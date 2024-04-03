using My_Tetris_Game_2024.__Globals;
using My_Tetris_Game_2024.A_2_Deps.A_5_Tetris_Shapes_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Shapes;

namespace My_Tetris_Game_2024.A_2_Deps.A_7_Canvas_Blocks
{
    internal class Drawing_In_Canvas_Blocks_Area
    {

        //--------------------------------------------------------------------
        private L_Shape obj_L_Block = new L_Shape();
        //---------------------------------------------------------------------
        public void draw_The_Req_Tetris_Shap_In_The_Canvas_Blocks( Grid gameArea)
        {
            switch (Globals.reqShape)
            {
                //--
                case 0:
                    draw_L_Tetris_Shape(gameArea);
                    break;
              /*  //--
                case 1:
                    draw_T_Tetris_Shape();
                    break;
                //--
                case 2:
                    draw_S_Tetris_Shape();
                    break;
                //--
                case 3:
                    draw_O_Tetris_Shape();
                    break;
                //--
                case 4:
                    draw_Z_Tetris_Shape();
                    break;
                //--
                case 5:
                    draw_J_Tetris_Shape();
                    break;
                //--
                default:
                    draw_L_Tetris_Shape( gameArea);
                    break;
                    //--*/
            }
        }
        //---------------------------------------------------------------------
        public void draw_L_Tetris_Shape(Grid gameArea)
        {
            //-
            Globals.dic_Curr_Showen_Shape_Rectangles.Clear();
            //--
            for(int i = 0; i < obj_L_Block.get_List_Of_L_Shapes_Blocks().Count; i++)
            {
                Globals.dic_Curr_Showen_Shape_Rectangles.Add(i, (obj_L_Block.get_List_Of_L_Shapes_Blocks()[i]));
            }
            //--
            int count = Globals.dic_Curr_Showen_Shape_Rectangles.Count;
            //-------------------------------------------
            if (Globals.req_Inner_Shape == 0)
            {
                for (int i = 0; i < count; i++)
                {
                    ///I shape will be in 1 - 4 - 7
                    ///
                    int block_No_In_Canvas_Area = obj_L_Block.get_No_Of_Cols_And_Rows_For_L_Blocks_Shape_0()[i];
                    int col = Globals.dic_Canvas_Blocks[block_No_In_Canvas_Area].getCol();
                    int row = Globals.dic_Canvas_Blocks[block_No_In_Canvas_Area].getRow();
                    add_To_The_Game_Area(gameArea,i, col, row);

                }
            }else if(Globals.req_Inner_Shape == 1)
            {
                for (int i = 0; i < count; i++)
                {
                    
                   
                    int block_No_In_Canvas_Area = obj_L_Block.get_No_Of_Cols_And_Rows_For_L_Blocks_Shape_1()[i];
                    int col = Globals.dic_Canvas_Blocks[block_No_In_Canvas_Area].getCol();
                    int row = Globals.dic_Canvas_Blocks[block_No_In_Canvas_Area].getRow();
                    add_To_The_Game_Area(gameArea,i, col, row);

                }
            }
            else if (Globals.req_Inner_Shape == 2)
            {
                for (int i = 0; i < count; i++)
                {
                    int block_No_In_Canvas_Area = obj_L_Block.get_No_Of_Cols_And_Rows_For_L_Blocks_Shape_0()[i];
                    int col = Globals.dic_Canvas_Blocks[block_No_In_Canvas_Area].getCol();
                    int row = Globals.dic_Canvas_Blocks[block_No_In_Canvas_Area].getRow();
                    add_To_The_Game_Area(gameArea, i, col, row);



                }
            }
            else if (Globals.req_Inner_Shape == 3)
            {
                for (int i = 0; i < count; i++)
                {
                    int block_No_In_Canvas_Area = obj_L_Block.get_No_Of_Cols_And_Rows_For_L_Blocks_Shape_0()[i];
                    int col = Globals.dic_Canvas_Blocks[block_No_In_Canvas_Area].getCol();
                    int row = Globals.dic_Canvas_Blocks[block_No_In_Canvas_Area].getRow();
                    add_To_The_Game_Area(gameArea,i, col, row);


                }
            }
            else { }
            //-------------
           
            //--
        }
        //---------------------------------------------------------------------
        private void draw_T_Tetris_Shape() { }
        //---------------------------------------------------------------------
        private void draw_S_Tetris_Shape() { }
        //---------------------------------------------------------------------
        private void draw_O_Tetris_Shape() { }
        //---------------------------------------------------------------------
        private void draw_Z_Tetris_Shape() { }
        //---------------------------------------------------------------------
        private void draw_J_Tetris_Shape() { }
        //---------------------------------------------------------------------
        public void add_To_The_List_Of_Current_Showen_shape(int no_OF_Block, Rectangle The_Block_Itself)
        {
            Globals.dic_Curr_Showen_Shape_Rectangles.Add(no_OF_Block, The_Block_Itself);
        }
        //---------------------------------------------------------------------
        private void add_To_The_Game_Area(Grid gameArea, int count, int Col , int Row)
        {
          //  remove_From_Game_Area(gameArea,Globals.dic_Curr_Showen_Shape_Rectangles);

            Rectangle block = Globals.dic_Curr_Showen_Shape_Rectangles[count];
            gameArea.Children.Add(block);
            //--

            Grid.SetColumn(block, Col);
            Grid.SetRow(block, Row);
            //--
        }
        //---------------------------------------------------------------------
        private void remove_From_Game_Area(Grid gameArea,Dictionary<int , Rectangle> last_Shape)
        {
            for (int i=0;i<last_Shape.Count;i++)
            {
                gameArea.Children.Remove(last_Shape[i]);    
            }
        }


    }
}
