using My_Snake_Game_2024.__Globals;
using My_Snake_Game_2024._2_Deps._8_Create_Rectangle;
using My_Snake_Game_2024._2_Deps._9_List_Of_Snake_Pieces_Handler;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace My_Snake_Game_2024._2_Deps._3_Snake_Food_Handler
{
    internal class Creation_Random_X_And_Y
    {
        //-------------------------------------------------------------------------
        #region Fields
        List_Of_Snake_Pieces_Handler obj_List_Of_Snake_Parts_Handler = new List_Of_Snake_Pieces_Handler();
        List<int[]> li_Of_Snake_Parts_Cols_And_Rows = new List<int[]>();
        #endregion
        //-------------------------------------------------------------------------
        public int[] get_Random_Row_And_Col_For_Snake_Food(Grid gameArea)
        {
            //--
            List<int[]> li_Of_Cols_And_Rows_Occupied_By_The_Snake = get_The_Locations_Occupied_By_The_Snake();
            //--
            #region create 2 int random numbers
            var ran_Obj_For_Col = new Random();
            var ran_Obj_For_Row = new Random();
            int next_Food_Col = ran_Obj_For_Col.Next(0, Globals.No_Of_gameArea_Cols);
            int next_Food_Row = ran_Obj_For_Row.Next(0, Globals.No_Of_gameArea_Rows);
            #endregion
            //--
            bool isMatching=check_For_Matching(li_Of_Cols_And_Rows_Occupied_By_The_Snake,next_Food_Row, next_Food_Col);
            //--
            if (isMatching)
            {
                return get_Random_Row_And_Col_For_Snake_Food(gameArea);
            }
            else
            {
                return new int[] { next_Food_Row, next_Food_Col };
            }
            //--
            
        }
        //-------------------------------------------------------------------------
        private List<int[]> get_The_Locations_Occupied_By_The_Snake()
        {
            //--
            li_Of_Snake_Parts_Cols_And_Rows.Clear();
            //--
            int counts_Snake_Body = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_The_Snake_Pieces();
            //--
            for (int i = 0; i < counts_Snake_Body; i++)
            {
                var snake_Part = obj_List_Of_Snake_Parts_Handler.get_One_Piece_From_The_Snake_Pieces_List(i);
                int snake_Part_Col = Grid.GetColumn(snake_Part);
                int snake_Part_Row = Grid.GetRow(snake_Part);
                int[] arr_One_Snake_Part_Cols_And_Rows = new int[] { snake_Part_Row, snake_Part_Col };
                li_Of_Snake_Parts_Cols_And_Rows.Add(arr_One_Snake_Part_Cols_And_Rows);
            }
            //--
            return li_Of_Snake_Parts_Cols_And_Rows;
            //--
        }
        //-------------------------------------------------------------------------
        private bool check_For_Matching(List<int[]> li_Of_Cols_And_Rows_Occupied_By_The_Snake,int next_Food_Row,int next_Food_Col)
        {
            //--
            bool isMatching = false;
            for (int j = 0; j < li_Of_Cols_And_Rows_Occupied_By_The_Snake.Count; j++)
            {
                int[] arr_One_Snake_Part_Cols_And_Rows = li_Of_Cols_And_Rows_Occupied_By_The_Snake[j];
                if (next_Food_Row == arr_One_Snake_Part_Cols_And_Rows[0] && next_Food_Col == arr_One_Snake_Part_Cols_And_Rows[1])
                {
                    isMatching = true;
                    break;
                }
                else
                {

                }

            }
            return isMatching;
        }
        //-------------------------------------------------------------------------
    }
}
