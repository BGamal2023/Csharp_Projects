using My_Snake_Game_2024.__Globals;
using My_Snake_Game_2024._2_Deps._9_List_Of_Snake_Pieces_Handler;
using My_Snake_Game_2024.My_Libs.My_Lib_1.Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace My_Snake_Game_2024._2_Deps._2_Snake_Moving_Handler
{
    internal class _2_Calculation_The_Other_Snake_Pieces_Locations
    {
        //------------------------------------------------------------------------------------
        private List_Of_Snake_Pieces_Handler obj_List_Of_Snake_Parts_Handler = new List_Of_Snake_Pieces_Handler();
        //------------------------------------------------------------------------------------
        public void calculate_The_Locations_For_The_Remaining_Snake_Pieces_According_To_The_Selected_Dir(
            Dictionary<string, int> dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key,
            int next_Col_For_Snake_Head,
            string selected_Dir)
        {
            //--
            Calculate_The_Locations_In_The_Right_Dir(dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key, next_Col_For_Snake_Head, selected_Dir);
            //--
            calculate_The_Locations_In_The_Left_Dir(dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key, next_Col_For_Snake_Head, selected_Dir);
            //--
            calculate_The_Locations_In_The_Up_Dir(dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key, next_Col_For_Snake_Head, selected_Dir);
            //--
            claculate_The_Locations_In_The_Down_Dir(dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key, next_Col_For_Snake_Head, selected_Dir);
            //--

        }
        //------------------------------------------------------------------------------------
        private void claculate_The_Locations_In_The_Down_Dir(
            Dictionary<string, int> dic_Snake_Pieces_Locations_At_Pres_Dir, 
            int next_Col_For_Snake_Head, 
            string selected_Dir)
        {
            //--
            if (selected_Dir == Global_Directions.str_goDown)
            {
                //--
                Globals.currDirection = (int)Globals.En_currentDirection.down;
                //--
                calculate_And_Set_X_And_Y_For_The_Snake_Pieces_For_Down_Dir(dic_Snake_Pieces_Locations_At_Pres_Dir,next_Col_For_Snake_Head);    
                //--
            }
            //--
        }
        //------------------------------------------------------------------------------------
        private void calculate_The_Locations_In_The_Up_Dir(
            Dictionary<string, int> dic_Snake_Pieces_Locations_At_Pres_Dir,
            int next_Col_For_Snake_Head, 
            string selected_Dir)
        {
            if (selected_Dir == Global_Directions.str_goUp)
            {
                //--
                Globals.currDirection = (int)Globals.En_currentDirection.up;
                //--
                //--
                calculate_And_Set_X_And_Y_For_The_Snake_Pieces_For_Up_Dir(dic_Snake_Pieces_Locations_At_Pres_Dir, next_Col_For_Snake_Head);
                //--
            }
        }
        //------------------------------------------------------------------------------------
        private void calculate_The_Locations_In_The_Left_Dir(
            Dictionary<string, int> dic_Snake_Pieces_Locations_At_Pres_Dir, 
            int next_Col_For_Snake_Head, 
            string selected_Dir)
        {
            if (selected_Dir == Global_Directions.str_goLeft)
            {
                //--
                Globals.currDirection = (int)Globals.En_currentDirection.left;
                //--
                calculate_And_Set_X_And_Y_For_The_Snake_Pieces_For_Left_Dir(dic_Snake_Pieces_Locations_At_Pres_Dir,next_Col_For_Snake_Head);
                //--
            }
        }
        //------------------------------------------------------------------------------------
        private void Calculate_The_Locations_In_The_Right_Dir(
            Dictionary<string, int> dic_Snake_Pieces_Locations_At_Pres_Dir,
            int next_Col_For_Snake_Head, 
            string selected_Dir)
        {
            //--
            if (selected_Dir == Global_Directions.str_goRight)
            {
                //--
                Globals.currDirection = (int)Globals.En_currentDirection.right;
                //--
                calculate_And_Set_X_And_Y_For_The_Snake_Pieces_For_Right_Dir(dic_Snake_Pieces_Locations_At_Pres_Dir,next_Col_For_Snake_Head);
                //--
            }
            //--
        }
        //------------------------------------------------------------------------------------
        private void set_The_Location_For_The_Snake_Piece(Rectangle snakePart, int X, int Y)
        {
            Grid.SetColumn(snakePart, X);
            Grid.SetRow(snakePart, Y);
        }
        //------------------------------------------------------------------------------------
        private void calculate_And_Set_X_And_Y_For_The_Snake_Pieces_For_Right_Dir(
            Dictionary<string, int> dic_Snake_Pieces_Locations_At_Pres_Dir,
            int next_Col_For_Snake_Head
            )
        {
            //--
            #region get the counts of the snake pieces
            int listCount = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_The_Snake_Pieces();
            #endregion
            //--
            #region for loop for calculate and set for all snake pieces.
            for (int i = 0; i < listCount; i++)
            {
                //--
                var curr_Item_From_The_List = obj_List_Of_Snake_Parts_Handler.get_One_Piece_From_The_Snake_Pieces_List(i);
                //--
                #region calculate And set for the snake head
                if (i == 0)
                {
                    //--
                    int X = next_Col_For_Snake_Head;
                    int Y = dic_Snake_Pieces_Locations_At_Pres_Dir[Globals.key_Row_Body_ + i];
                    //--
                    set_The_Location_For_The_Snake_Piece(curr_Item_From_The_List, X, Y);
                    //--
                }
                #endregion
                //--
                #region calculate and set for the remaining snake pieces
                else
                {
                    //--
                    int X = dic_Snake_Pieces_Locations_At_Pres_Dir[Globals.key_Col_Body_ + (i - 1)];
                    int Y = dic_Snake_Pieces_Locations_At_Pres_Dir[Globals.key_Row_Body_ + (i - 1)];
                    //--
                    set_The_Location_For_The_Snake_Piece(curr_Item_From_The_List, X, Y);
                    //--
                }
                #endregion
                //--
            }
            #endregion
            //--
        }
        //------------------------------------------------------------------------------------
        private void calculate_And_Set_X_And_Y_For_The_Snake_Pieces_For_Left_Dir(
            Dictionary<string, int> dic_Snake_Pieces_Locations_At_Pres_Dir,
            int next_Col_For_Snake_Head
            )
        {
            //--
            #region get the counts of the snake pieces
            int count_Of_Snake_Pieces = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_The_Snake_Pieces();
            #endregion
            //--
            #region for loop for calculate and set for all snake pieces.
            for (int i = 0; i < count_Of_Snake_Pieces; i++)
            {
                //--
                var curr_Item_From_The_List = obj_List_Of_Snake_Parts_Handler.get_One_Piece_From_The_Snake_Pieces_List(i);
                //--
                #region calculate And set for the snake head
                if (i == 0)
                {
                    //--
                    int X = next_Col_For_Snake_Head;
                    int Y = dic_Snake_Pieces_Locations_At_Pres_Dir[Globals.key_Row_Body_ + i];
                    //--
                    set_The_Location_For_The_Snake_Piece(curr_Item_From_The_List, X, Y);
                    //--
                }
                #endregion
                //--
                #region calculate and set for the remaining snake pieces
                else
                {
                    //--
                    int X = dic_Snake_Pieces_Locations_At_Pres_Dir[Globals.key_Col_Body_ + (i - 1)];
                    int Y = dic_Snake_Pieces_Locations_At_Pres_Dir[Globals.key_Row_Body_ + (i - 1)];
                    //--
                    set_The_Location_For_The_Snake_Piece(curr_Item_From_The_List, X, Y);

                }
                #endregion
                //--
            }
            #endregion
            //--
        }
        //------------------------------------------------------------------------------------
        private void calculate_And_Set_X_And_Y_For_The_Snake_Pieces_For_Up_Dir(
            Dictionary<string, int> dic_Snake_Pieces_Locations_At_Pres_Dir,
            int next_Col_For_Snake_Head)
        {
            //--
            #region get the counts of the snake pieces
            int listCount = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_The_Snake_Pieces();
            #endregion
            //--
            #region for loop for calculate and set for all snake pieces.
            for (int i = 0; i < listCount; i++)
            {
                //--
                #region get current piece of the snake
                var curr_Item_From_The_List = obj_List_Of_Snake_Parts_Handler.get_One_Piece_From_The_Snake_Pieces_List(i);
                #endregion
                //--
                #region calculate And set for the snake head
                if (i == 0)
                {
                    //--
                    int X = dic_Snake_Pieces_Locations_At_Pres_Dir[Globals.key_Col_Body_ + i];
                    int Y = next_Col_For_Snake_Head;
                    //--
                    set_The_Location_For_The_Snake_Piece(curr_Item_From_The_List, X, Y);
                    //--
                }
                #endregion
                //--
                #region calculate and set for the remaining snake pieces
                
                else
                {
                    //--
                    int X = dic_Snake_Pieces_Locations_At_Pres_Dir[Globals.key_Col_Body_ + (i - 1)];
                    int Y = dic_Snake_Pieces_Locations_At_Pres_Dir[Globals.key_Row_Body_ + (i - 1)];
                    //--
                    set_The_Location_For_The_Snake_Piece(curr_Item_From_The_List, X, Y);
                    //--
                }
                #endregion
                //--
            }
            #endregion
            //--
        }
        //------------------------------------------------------------------------------------
        private void calculate_And_Set_X_And_Y_For_The_Snake_Pieces_For_Down_Dir(
           Dictionary<string, int> dic_Snake_Pieces_Locations_At_Pres_Dir,
           int next_Col_For_Snake_Head
           )
        {
            //--
            #region get the counts of the snake pieces
            int listCount = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_The_Snake_Pieces();
            #endregion
            //--
            #region for loop for calculate and set for all snake pieces.
            for (int i = 0; i < listCount; i++)
            {
                //--
                #region get current piece of the snake
                var curr_Item_From_The_List = obj_List_Of_Snake_Parts_Handler.get_One_Piece_From_The_Snake_Pieces_List(i);
                #endregion
                //--
                #region calculate And set for the snake head
                if (i == 0)
                {
                    //--
                    int X = dic_Snake_Pieces_Locations_At_Pres_Dir[Globals.key_Col_Body_ + i];
                    int Y = next_Col_For_Snake_Head;
                    //--
                    set_The_Location_For_The_Snake_Piece(curr_Item_From_The_List, X, Y);
                    //--
                }
                #endregion
                //--
                #region calculate and set for the remaining snake pieces
                else
                {
                    //--
                    int X = dic_Snake_Pieces_Locations_At_Pres_Dir[Globals.key_Col_Body_ + (i - 1)];
                    int Y = dic_Snake_Pieces_Locations_At_Pres_Dir[Globals.key_Row_Body_ + (i - 1)];
                    //--
                    set_The_Location_For_The_Snake_Piece(curr_Item_From_The_List, X, Y);
                    //--
                }
                #endregion
                //--

            }
            #endregion
            //--
        }
        //------------------------------------------------------------------------------------
    }
}
