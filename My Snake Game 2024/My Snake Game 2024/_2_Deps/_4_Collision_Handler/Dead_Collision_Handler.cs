using My_Snake_Game_2024.__Globals;
using My_Snake_Game_2024._2_Deps._9_List_Of_Snake_Pieces_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace My_Snake_Game_2024._2_Deps._4_Collision_Handler
{
    internal class Dead_Collision_Handler
    {
        //-------------------------------------------------------------------------------------------------
        #region The Fields
        private List_Of_Snake_Pieces_Handler obj_List_Of_Snake_Parts_Handler = new List_Of_Snake_Pieces_Handler();
        #endregion
        //-------------------------------------------------------------------------------------------------
        public void detect_The_Dead_Collision()
        {
            //--
            #region get current snakeHead Col and Row
            UIElement SnakeHead = obj_List_Of_Snake_Parts_Handler.get_One_Piece_From_The_Snake_Pieces_List(0);
            int curCol_SnakeHead = Grid.GetColumn(SnakeHead);
            int curRow_SnakeHead=Grid.GetRow(SnakeHead);
            #endregion
            //--
            int listCount = obj_List_Of_Snake_Parts_Handler.get_The_Count_Of_The_Snake_Pieces();
            //--
            #region check if the snakhead col and row match any of its body col and row 
            for (int i=1; i < listCount; i++)
            {
                //--
                var currItem=obj_List_Of_Snake_Parts_Handler.get_One_Piece_From_The_Snake_Pieces_List(i);
                //--
                if ( curCol_SnakeHead == Grid.GetColumn(currItem) &&  curRow_SnakeHead == Grid.GetRow(currItem) )
                {
                    Globals.isDeadCollisionOccurued = true;
                }
                //--
            }
            #endregion
            //--
        }
        //-------------------------------------------------------------------------------------------------
    }
}
