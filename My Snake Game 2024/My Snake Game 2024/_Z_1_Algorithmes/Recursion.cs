using My_Snake_Game_2024.__Globals;
using My_Snake_Game_2024._2_Deps._9_List_Of_Snake_Pieces_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace My_Snake_Game_2024._Z_1_Algorithmes
{
    internal class Recursion
    {
        /// the idea .....bool variable befor the condition .....
        /// the condition change this bool.
        ///  then in the last of the fun make if(bool){ return (you must use return) else return what is not match)}.
        //-------------------------------------------------------------------------
        private int[] get_The_Random_Row_And_Col_For_Snake_Food(Grid gameArea)
        {
            //-------
            /// 0- get all cols and rows for the sanke.
            /// 1- create 2 random numbers.
            /// 2- check from mathcing 
            /// 3- if at least one match repeat for 1.
            /// 4- if not match ....create rectangel and set col and row.
            /// 0- get all cols and rows for the snake.
            //--
            List<int[]> li_Of_Snake_Parts_Cols_And_Rows = new List<int[]>();
            List_Of_Snake_Pieces_Handler obj_List_Of_Snake_Parts_Handler=new List_Of_Snake_Pieces_Handler();

            li_Of_Snake_Parts_Cols_And_Rows.Clear();
            int counts_Snake_Body = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_The_Snake_Pieces();
            for (int i = 0; i < counts_Snake_Body; i++)
            {
                var snake_Part = obj_List_Of_Snake_Parts_Handler.get_One_Piece_From_The_Snake_Pieces_List(i);
                int snake_Part_Col = Grid.GetColumn(snake_Part);
                int snake_Part_Row = Grid.GetRow(snake_Part);
                int[] arr_One_Snake_Part_Cols_And_Rows = new int[] { snake_Part_Row, snake_Part_Col };
                li_Of_Snake_Parts_Cols_And_Rows.Add(arr_One_Snake_Part_Cols_And_Rows);
            }
           
            //--
            var ran_Obj_For_Col = new Random();
            var ran_Obj_For_Row = new Random();
            int next_Food_Col = ran_Obj_For_Col.Next(0, Globals.No_Of_gameArea_Cols);
            int next_Food_Row = ran_Obj_For_Row.Next(0, Globals.No_Of_gameArea_Rows); ;
            //--
         
            //--
            bool isMatching = false;
            for (int j = 0; j < li_Of_Snake_Parts_Cols_And_Rows.Count; j++)
            {
                int[] arr_One_Snake_Part_Cols_And_Rows = li_Of_Snake_Parts_Cols_And_Rows[j];
                if (next_Food_Row == arr_One_Snake_Part_Cols_And_Rows[0] && next_Food_Col == arr_One_Snake_Part_Cols_And_Rows[1])
                {
                    isMatching = true;
                    break;
                }
                else
                {

                }

            }
            /// 1- bool before the condition 
            /// 2- the condition will make bool true 
            /// 3-in the last part of the method  check bool in if else .......you must must must return the method not just call it.
            //-------------the important part -----------------------------

            if (isMatching)
            {
                return get_The_Random_Row_And_Col_For_Snake_Food(gameArea);
            }
            else
            {
                return new int[] { next_Food_Row, next_Food_Col };

            }
            //--

            //----------

        }
    }
}
