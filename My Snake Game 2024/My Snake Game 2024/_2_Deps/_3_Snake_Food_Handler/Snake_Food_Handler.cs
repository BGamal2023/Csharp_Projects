using My_Snake_Game_2024.__Globals;
using My_Snake_Game_2024._2_Deps._1_Snake_Body_Handler;
using My_Snake_Game_2024._2_Deps._8_Create_Rectangle;
using My_Snake_Game_2024._2_Deps._9_List_Of_Snake_Pieces_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace My_Snake_Game_2024._2_Deps._3_Snake_Food_Handler
{
    internal class Snake_Food_Handler
    {
        //-------------------------------------------------------------------------
        #region Fields
        Creating_Rect obj_Creating_Rect = new Creating_Rect();
        List_Of_Snake_Pieces_Handler obj_List_Of_Snake_Parts_Handler=new List_Of_Snake_Pieces_Handler();
        List<int[]> li_Of_Snake_Parts_Cols_And_Rows = new List<int[]>();
        #endregion
        //-------------------------------------------------------------------------
        public void feed_The_Snake(Grid gameArea)
        {
            //--
            int[] arr_Of_Next_Food_Col_and_Row = get_The_Random_Row_And_Col_For_Snake_Food(gameArea);
            //--
            var snakeFood=create_Food_Retangle(gameArea, arr_Of_Next_Food_Col_and_Row[0], arr_Of_Next_Food_Col_and_Row[1]);
            //--
            Globals.list_Snake_Food.Add(snakeFood);
            //--
            Globals.isFoodCollisionOccurred = false;
            //--
        }
        //-------------------------------------------------------------------------
        private int[] get_The_Random_Row_And_Col_For_Snake_Food(Grid gameArea)
        {
            //--
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
            ///-    /// 1- create 2 random numbers.
            //--
            var ran_Obj_For_Col = new Random();
            var ran_Obj_For_Row = new Random();
            int next_Food_Col = ran_Obj_For_Col.Next(0, Globals.No_Of_gameArea_Cols);
            int next_Food_Row = ran_Obj_For_Row.Next(0, Globals.No_Of_gameArea_Rows); ;
            //--
            ///-2- check for mathcing .
            //--
            bool isMatching=false;
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
            //--

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
        //-------------------------------------------------------------------------
        private Rectangle create_Food_Retangle(Grid gameArea,int X,int Y)
        {
            var snakeFood = obj_Creating_Rect.create_Rec(
                 gameArea,
                 Globals.snake_Food_Color,
                 Y,
                 X
                 );
            return snakeFood;
        }
        //-------------------------------------------------------------------------
        public void eat_Snake_Food(Grid gameArea)
        {
            gameArea.Children.Remove(Globals.list_Snake_Food[0]);
            Globals.list_Snake_Food.Clear();
        }
        //-------------------------------------------------------------------------
    }
}
