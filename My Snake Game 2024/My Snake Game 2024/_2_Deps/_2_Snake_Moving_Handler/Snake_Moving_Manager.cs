using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using static System.Runtime.InteropServices.JavaScript.JSType;
using My_Snake_Game_2024.__Globals;
using My_Snake_Game_2024.My_Libs.My_Lib_1.Globals;
using My_Snake_Game_2024._2_Deps._1_Snake_Body_Handler;
using System.Windows.Shapes;
using My_Snake_Game_2024._2_Deps._9_List_Of_Snake_Pieces_Handler;

namespace My_Snake_Game_2024._2_Deps._2_Snake_Moving_Handler
{
    internal class Snake_Moving_Manager
    {
        //------------------------------------------------------------------------------------
        #region The Fields
        Globals globals = new Globals();
        private List_Of_Snake_Pieces_Handler obj_List_Of_Snake_Parts_Handler=new List_Of_Snake_Pieces_Handler();
        #endregion
        //------------------------------------------------------------------------------------
        #region Main Method
        public void move_The_Snake_To_The_Selected_Dir(string selected_Dir)
        {
            //--
            Dictionary<string, int> dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key =
                get_The_Locations_For_All_The_Snake_Pieces_At_Pressing_The_Dir_Key();
            //--
            Change_The_Locations_For_All_The_Snake_Pieces_According_To_The_Selected_Dir(
                dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key,
                get_Next_Step_For_Snake_Head_According_To_Selected_Dir(dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key, selected_Dir),
                selected_Dir
                );
            //--
        }
        #endregion
        //------------------------------------------------------------------------------------
        #region The Auxilary Methods.
        private Dictionary<string, int> get_The_Locations_For_All_The_Snake_Pieces_At_Pressing_The_Dir_Key()
        {
            //--
            Dictionary<string, int> dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key = new Dictionary<string, int>();
            dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key.Clear();
            //--
            int listCount = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_The_Snake_Pieces();
            //--
            for (int i = 0; i < listCount; i++)
            {
                //--
                var current_item_From_The_List = obj_List_Of_Snake_Parts_Handler.get_One_Piece_From_The_Snake_Pieces_List(i);
                //--
                dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key.Add(globals.key_Col_Body_ + i, Grid.GetColumn(current_item_From_The_List));
                dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key.Add(globals.key_Row_Body_ + i, Grid.GetRow(current_item_From_The_List));
                //--
            }
            //--
            return dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key;
        }
        //------------------------------------------------------------------------------------
        private void Change_The_Locations_For_All_The_Snake_Pieces_According_To_The_Selected_Dir( 
            Dictionary<string, int> dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key, 
            int next_Col_For_Snake_Head, 
            string selected_Dir)
        {
            //--
                move_The_Snake_To_Right_Dir__If_Right_Is_Pressed(dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key, next_Col_For_Snake_Head, selected_Dir);
            //--
                move_The_Snake_To_Left_Dir_If_Left_Is_Pressed( dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key, next_Col_For_Snake_Head,selected_Dir);
            //--
                move_The_Snake_To_Up_Dir_If_The_Up_Is_Pressed( dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key, next_Col_For_Snake_Head,selected_Dir);
            //--
                move_The_Snake_To_Down_Dir_If_Down_Is_Pressed(dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key, next_Col_For_Snake_Head,selected_Dir);
            //--

        }
        //------------------------------------------------------------------------------------
        private void move_The_Snake_To_Down_Dir_If_Down_Is_Pressed( Dictionary<string, int> dic_Positions_At_Pres_Dire, int next_Col_For_Snake_Head,string selected_Dir)
        {
            //--
            if (selected_Dir == Global_Directions.str_goDown)
            {
                //--
                Globals.currDirection = (int)Globals.En_currentDirection.down;
                //--

                //--
                int listCount = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_The_Snake_Pieces();
                //--
                for (int i = 0; i < listCount; i++)
                {
                    //--
                    var curr_Item_From_The_List = obj_List_Of_Snake_Parts_Handler.get_One_Piece_From_The_Snake_Pieces_List(i);
                    //--
                    if (i == 0)
                    {
                        //--
                        int X = dic_Positions_At_Pres_Dire[globals.key_Col_Body_ + i];
                        int Y = next_Col_For_Snake_Head;
                        //--
                        set_The_Location_For_The_Snake_Piece(curr_Item_From_The_List, X, Y);
                        //--
                    }
                    //--
                    else
                    {
                        //--
                        int X = dic_Positions_At_Pres_Dire[globals.key_Col_Body_ + (i - 1)];
                        int Y = dic_Positions_At_Pres_Dire[globals.key_Row_Body_ + (i - 1)];
                        //--
                        set_The_Location_For_The_Snake_Piece(curr_Item_From_The_List, X, Y);
                        //--
                    }
                    //--

                }

                //--
            }
            //--
        }
        //------------------------------------------------------------------------------------
        private void move_The_Snake_To_Up_Dir_If_The_Up_Is_Pressed(Dictionary<string, int> dic_Positions_At_Pres_Dire, int next_Col_For_Snake_Head,string selected_Dir)
        {
            if (selected_Dir == Global_Directions.str_goUp)
            {
                //--
                Globals.currDirection = (int)Globals.En_currentDirection.up;
                //--
                //--
                int listCount = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_The_Snake_Pieces();
                //--
                for (int i = 0; i < listCount; i++)
                {
                    //--
                    var curr_Item_From_The_List = obj_List_Of_Snake_Parts_Handler.get_One_Piece_From_The_Snake_Pieces_List(i);
                    //--
                    if (i == 0)
                    {
                        //--
                        int X = dic_Positions_At_Pres_Dire[globals.key_Col_Body_ + i];
                        int Y = next_Col_For_Snake_Head;
                        //--
                        set_The_Location_For_The_Snake_Piece(curr_Item_From_The_List, X, Y);
                        //--
                    }
                    //--
                    else
                    {
                        //--
                        int X = dic_Positions_At_Pres_Dire[globals.key_Col_Body_ + (i - 1)];
                        int Y = dic_Positions_At_Pres_Dire[globals.key_Row_Body_ + (i - 1)];
                        //--
                        set_The_Location_For_The_Snake_Piece(curr_Item_From_The_List, X, Y);
                        //--
                    }
                    //--
                }
                //--
                //--
            }
        }
        //------------------------------------------------------------------------------------
        private void move_The_Snake_To_Left_Dir_If_Left_Is_Pressed(Dictionary<string, int> dic_Positions_At_Pres_Dire, int next_Col_For_Snake_Head,string selected_Dir)
        {
            if (selected_Dir == Global_Directions.str_goLeft)
            {
                //--
                Globals.currDirection = (int)Globals.En_currentDirection.left;
                //--
                //--
                int count_Of_Snake_Pieces = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_The_Snake_Pieces();
                //--
                for (int i = 0; i < count_Of_Snake_Pieces; i++)
                {
                    //--
                    var curr_Item_From_The_List = obj_List_Of_Snake_Parts_Handler.get_One_Piece_From_The_Snake_Pieces_List(i);
                    //--
                    if (i == 0)
                    {
                        //--
                        int X = next_Col_For_Snake_Head;
                        int Y = dic_Positions_At_Pres_Dire[globals.key_Row_Body_ + i];
                        //--
                        set_The_Location_For_The_Snake_Piece(curr_Item_From_The_List, X, Y);
                        //--
                    }
                    //--
                    else
                    {
                        //--
                        int X = dic_Positions_At_Pres_Dire[globals.key_Col_Body_ + (i - 1)];
                        int Y = dic_Positions_At_Pres_Dire[globals.key_Row_Body_ + (i - 1)];
                        //--
                        set_The_Location_For_The_Snake_Piece(curr_Item_From_The_List, X, Y);

                    }
                    //--
                }
                //--
                //--
            }






        }
        //------------------------------------------------------------------------------------
        private void move_The_Snake_To_Right_Dir__If_Right_Is_Pressed(Dictionary<string, int> dic_Positions_At_Pres_Dire, int next_Col_For_Snake_Head,string selected_Dir)
        {
            //--
            if (selected_Dir == Global_Directions.str_goRight)
            {
                //--
                Globals.currDirection = (int)Globals.En_currentDirection.right;
                //--
                int listCount = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_The_Snake_Pieces();
                //--
                for (int i = 0; i < listCount; i++)
                {
                    //--
                    var curr_Item_From_The_List = obj_List_Of_Snake_Parts_Handler.get_One_Piece_From_The_Snake_Pieces_List(i);
                    //--
                    if (i == 0)
                    {
                        //--
                        int X = next_Col_For_Snake_Head;
                        int Y = dic_Positions_At_Pres_Dire[globals.key_Row_Body_ + i];
                        //--
                        set_The_Location_For_The_Snake_Piece(curr_Item_From_The_List, X, Y);
                        //--
                        //! bug#10 if program work fine remove the 2 comments below.
                        ///   Grid.SetColumn(curr_Item_From_The_List, next_Col_For_Snake_Head);
                        ///  Grid.SetRow(curr_Item_From_The_List, dic_Positions_At_Pres_Left[globals.key_Row_Body_ + i]);
                    }
                    else
                    {
                        //--
                        int X = dic_Positions_At_Pres_Dire[globals.key_Col_Body_ + (i - 1)];
                        int Y = dic_Positions_At_Pres_Dire[globals.key_Row_Body_ + (i - 1)];
                        //--
                        set_The_Location_For_The_Snake_Piece(curr_Item_From_The_List, X, Y);
                        //! bug#10 if program work fine remove the 2 comments below.

                        ///   Grid.SetColumn(curr_Item_From_The_List, dic_Positions_At_Pres_Left[globals.key_Col_Body_ + (i - 1)]);
                        ///   Grid.SetRow(curr_Item_From_The_List, dic_Positions_At_Pres_Left[globals.key_Row_Body_ + (i - 1)]);
                    }
                    //--
                }
                //--
            }
            //--
        }
        //------------------------------------------------------------------------------------
        private int get_Next_Step_For_Snake_Head_According_To_Selected_Dir(Dictionary<string, int> dic_Positions_At_Pres_Dire, string selected_Direction)
        {
            //--
            int next_Step_For_Snake_Head = 0;
            //--
            if (selected_Direction == Global_Directions.str_goRight)
            {
                next_Step_For_Snake_Head = get_Next_Position_For_The_Snake_Head_In_Right_Dir(dic_Positions_At_Pres_Dire);
            }
            //--
            else if (selected_Direction == Global_Directions.str_goLeft)
            {
                next_Step_For_Snake_Head = get_Next_Position_For_The_Snake_Head_In_Left_Dir(dic_Positions_At_Pres_Dire);
            }
            //--
            else if (selected_Direction == Global_Directions.str_goUp)
            {
                next_Step_For_Snake_Head = get_Next_Position_For_The_Snake_Head_In_Up_Dir(dic_Positions_At_Pres_Dire);
             
            }
            //--
            else if (selected_Direction == Global_Directions.str_goDown)
            {
                next_Step_For_Snake_Head = get_Next_Position_For_The_Snake_Head_In_Down_Dir(dic_Positions_At_Pres_Dire);
            }
            //--
            return next_Step_For_Snake_Head;
            //--
        }
        //------------------------------------------------------------------------------------
        private void set_The_Location_For_The_Snake_Piece(Rectangle snakePart,int X,int Y)
        {
            Grid.SetColumn(snakePart,X);
            Grid.SetRow(snakePart,Y);
        }
        //------------------------------------------------------------------------------------
        private int get_Next_Position_For_The_Snake_Head_In_Right_Dir(Dictionary<string, int> dic_Positions_At_Pres_Dire)
        {
            //--
           int  next_Step_For_Snake_Head = dic_Positions_At_Pres_Dire[globals.key_Col_Body_+ "0"] +1;
            //--
            if (next_Step_For_Snake_Head == Globals.No_Of_gameArea_Rows)
            {
                next_Step_For_Snake_Head = 0;
            }
            //--
            return next_Step_For_Snake_Head;
            //--
        }
        //------------------------------------------------------------------------------------
        private int get_Next_Position_For_The_Snake_Head_In_Left_Dir(Dictionary<string, int> dic_Positions_At_Pres_Dire)
        {
            //--
           int  next_Step_For_Snake_Head = dic_Positions_At_Pres_Dire[globals.key_Col_Body_ + "0"] - 1;
            //--
            if (next_Step_For_Snake_Head <0)
            {
                next_Step_For_Snake_Head = Globals.No_Of_gameArea_Cols-1;
            }
            //--

            return next_Step_For_Snake_Head;

        }
        //------------------------------------------------------------------------------------
        private int get_Next_Position_For_The_Snake_Head_In_Up_Dir(Dictionary<string, int> dic_Positions_At_Pres_Dire)
        {
            //--
           int next_Step_For_Snake_Head = dic_Positions_At_Pres_Dire[globals.key_Row_Body_ + "0"] - 1;
            //--
            if (next_Step_For_Snake_Head < 0)
            {
                next_Step_For_Snake_Head = Globals.No_Of_gameArea_Rows-1;
            }
            //--
            return next_Step_For_Snake_Head;
            //--
        }
        //------------------------------------------------------------------------------------
        private int get_Next_Position_For_The_Snake_Head_In_Down_Dir(Dictionary<string, int> dic_Positions_At_Pres_Dire)
        {
            //--
           int  next_Step_For_Snake_Head =dic_Positions_At_Pres_Dire[globals.key_Row_Body_ + "0"] + 1;
            //--
            if (next_Step_For_Snake_Head == Globals.No_Of_gameArea_Rows)
            {
                next_Step_For_Snake_Head = 0;
            }
            //--
            return next_Step_For_Snake_Head;
            //--
        }
        //------------------------------------------------------------------------------------
        
    #endregion
    //------------------------------------------------------------------------------------
}
}
