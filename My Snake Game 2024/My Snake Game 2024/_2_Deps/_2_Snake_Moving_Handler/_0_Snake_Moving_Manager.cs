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
    internal class _0_Snake_Moving_Manager
    {
        //------------------------------------------------------------------------------------
        #region The Fields
        private Globals Globals = new Globals();
        private List_Of_Snake_Pieces_Handler obj_List_Of_Snake_Parts_Handler=new List_Of_Snake_Pieces_Handler();
        private _1_Calculation_The_Snake_Head_Locations obj_1_Snake_Head_Moving_Employee=new _1_Calculation_The_Snake_Head_Locations();
        private _2_Calculation_The_Other_Snake_Pieces_Locations obj_2_Snake_Body_Moving_Employee = new _2_Calculation_The_Other_Snake_Pieces_Locations();
        #endregion
        //------------------------------------------------------------------------------------
        #region Main Method
        public void move_The_Snake_To_The_Selected_Dir(string selected_Dir)
        {
            //--
            Dictionary<string, int> dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key =
                get_The_Locations_For_All_The_Snake_Pieces_At_Pressing_The_Dir_Key();
            //--
            int calculated_Location_For_The_Snake_Head_According_to_Selected_Dir =
                obj_1_Snake_Head_Moving_Employee.calculate_The_Location_For_The_Snake_Head_According_To_Selected_Dir(
                    dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key, selected_Dir);
            //--
            obj_2_Snake_Body_Moving_Employee.calculate_The_Locations_For_The_Remaining_Snake_Pieces_According_To_The_Selected_Dir(
                dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key,
                calculated_Location_For_The_Snake_Head_According_to_Selected_Dir,
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
                dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key.Add(Globals.key_Col_Body_ + i, Grid.GetColumn(current_item_From_The_List));
                dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key.Add(Globals.key_Row_Body_ + i, Grid.GetRow(current_item_From_The_List));
                //--
            }
            //--
            return dic_The_Locations_Of_The_Snake_Pieces_At_Pressing_The_Dir_Key;
        }
        #endregion
        //------------------------------------------------------------------------------------
}
}
