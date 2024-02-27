using My_Snake_Game_2024.__Globals;
using My_Snake_Game_2024.My_Libs.My_Lib_1.Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Snake_Game_2024._2_Deps._2_Snake_Moving_Handler
{
    internal class _1_Calculation_The_Snake_Head_Locations
    {
        //------------------------------------------------------------------------------------
        #region The Main Method
        public int calculate_The_Location_For_The_Snake_Head_According_To_Selected_Dir(
            Dictionary<string, int> dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key, 
            string selected_Direction)
        {
            //--
            int next_Step_For_Snake_Head = 0;
            //--
            if (selected_Direction == Global_Directions.str_goRight)
            {
                next_Step_For_Snake_Head = get_Next_Location_For_The_Snake_Head_In_Right_Dir(dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key);
            }
            //--
            else if (selected_Direction == Global_Directions.str_goLeft)
            {
                next_Step_For_Snake_Head = get_Next_Location_For_The_Snake_Head_In_Left_Dir(dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key);
            }
            //--
            else if (selected_Direction == Global_Directions.str_goUp)
            {
                next_Step_For_Snake_Head = get_Next_Location_For_The_Snake_Head_In_Up_Dir(dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key);
            }
            //--
            else if (selected_Direction == Global_Directions.str_goDown)
            {
                next_Step_For_Snake_Head = get_Next_Location_For_The_Snake_Head_In_Down_Dir(dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key);
            }
            //--
            return next_Step_For_Snake_Head;
            //--
        }
        #endregion
        //------------------------------------------------------------------------------------
        #region The Auxilary Methods
        private int get_Next_Location_For_The_Snake_Head_In_Right_Dir(Dictionary<string, int> dic_Positions_At_Pres_Dire)
        {
            //--
            int next_Step_For_Snake_Head = dic_Positions_At_Pres_Dire[Globals.key_Col_Body_ + "0"] + 1;
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
        private int get_Next_Location_For_The_Snake_Head_In_Left_Dir(Dictionary<string, int> dic_Positions_At_Pres_Dire)
        {
            //--
            int next_Step_For_Snake_Head = dic_Positions_At_Pres_Dire[Globals.key_Col_Body_ + "0"] - 1;
            //--
            if (next_Step_For_Snake_Head < 0)
            {
                next_Step_For_Snake_Head = Globals.No_Of_gameArea_Cols - 1;
            }
            //--

            return next_Step_For_Snake_Head;

        }
        //------------------------------------------------------------------------------------
        private int get_Next_Location_For_The_Snake_Head_In_Up_Dir(Dictionary<string, int> dic_Positions_At_Pres_Dire)
        {
            //--
            int next_Step_For_Snake_Head = dic_Positions_At_Pres_Dire[Globals.key_Row_Body_ + "0"] - 1;
            //--
            if (next_Step_For_Snake_Head < 0)
            {
                next_Step_For_Snake_Head = Globals.No_Of_gameArea_Rows - 1;
            }
            //--
            return next_Step_For_Snake_Head;
            //--
        }
        //------------------------------------------------------------------------------------
        private int get_Next_Location_For_The_Snake_Head_In_Down_Dir(Dictionary<string, int> dic_Positions_At_Pres_Dire)
        {
            //--
            int next_Step_For_Snake_Head = dic_Positions_At_Pres_Dire[Globals.key_Row_Body_ + "0"] + 1;
            //--
            if (next_Step_For_Snake_Head == Globals.No_Of_gameArea_Rows)
            {
                next_Step_For_Snake_Head = 0;
            }
            //--
            return next_Step_For_Snake_Head;
            //--
        }
        #endregion
        //------------------------------------------------------------------------------------

    }
}
