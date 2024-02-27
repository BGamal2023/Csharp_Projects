using My_Snake_Game_2024.__Globals;
using My_Snake_Game_2024._2_Deps._1_Snake_Body_Handler;
using My_Snake_Game_2024._2_Deps._3_Snake_Food_Handler;
using My_Snake_Game_2024._2_Deps._9_List_Of_Snake_Pieces_Handler;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace My_Snake_Game_2024._2_Deps._4_Collision_Handler
{
    internal class Food_Collision_Handler
    {
        //----------------------------------------------------------------------------------------------------------------------
        #region The Fields
        private List_Of_Snake_Pieces_Handler obj_List_Of_Snake_Parts_Handler = new List_Of_Snake_Pieces_Handler();
        #endregion
        //----------------------------------------------------------------------------------------------------------------------
        public void detect_The_Food_Collision()
        {
            //--
            #region get current col and row for food and snake head
            UIElement SnakeHead = obj_List_Of_Snake_Parts_Handler.get_One_Piece_From_The_Snake_Pieces_List(0);
            UIElement food_Rec = Globals.list_Snake_Food[0];
            int curCol_SnakeHead = Grid.GetColumn(SnakeHead);
            int curCol_food_Rec=Grid.GetColumn(food_Rec);
            int curRow_SnakeHead=Grid.GetRow(SnakeHead);
            int curRow_food_Rec = Grid.GetRow(food_Rec);
            #endregion 
            //--
            detect_The_Food_Collision_In_Right_Dir(curCol_SnakeHead, curCol_food_Rec,curRow_SnakeHead,curRow_food_Rec);
            //--
            detect_The_Food_Collision_In_Left_Dir(curCol_SnakeHead, curCol_food_Rec, curRow_SnakeHead, curRow_food_Rec);
            //--
            detect_The_Food_Collision_In_Up_Dir(curCol_SnakeHead, curCol_food_Rec, curRow_SnakeHead, curRow_food_Rec);
            //--
            detect_The_Food_Collision_In_Down_Dir(curCol_SnakeHead, curCol_food_Rec, curRow_SnakeHead, curRow_food_Rec);
            //--
        }
        //----------------------------------------------------------------------------------------------------------------------
        private void detect_The_Food_Collision_In_Right_Dir(int curCol_SnakeHead,int curCol_food_Rec,int curRow_SnakeHead, int curRow_food_Rec) {
            //--
            if (Globals.currDirection == (int)Globals.En_currentDirection.right)
            {
                //--

                bool isCollisionOccurred = (curCol_SnakeHead + 1 == curCol_food_Rec && curRow_SnakeHead == curRow_food_Rec)
                                                               ||
                                            (curCol_SnakeHead == curCol_food_Rec && curRow_SnakeHead == curRow_food_Rec);
                //--
                if (isCollisionOccurred)
                {
                    Globals.isFoodCollisionOccurred = true;

                    Globals.Score++;
                }
                //--
            }
            //--
        }
        //----------------------------------------------------------------------------------------------------------------------
        private void detect_The_Food_Collision_In_Left_Dir(int curCol_SnakeHead, int curCol_food_Rec, int curRow_SnakeHead, int curRow_food_Rec) {
            if (Globals.currDirection == (int)Globals.En_currentDirection.left)
            {
                if (
                    (curCol_SnakeHead - 1 == curCol_food_Rec && curRow_SnakeHead == curRow_food_Rec)  ||
                     (curCol_SnakeHead == curCol_food_Rec && curRow_SnakeHead == curRow_food_Rec)
                    )
                {
                    Globals.isFoodCollisionOccurred = true;
                    Globals.Score++;
                }
            }
        }
        //----------------------------------------------------------------------------------------------------------------------
        private void detect_The_Food_Collision_In_Up_Dir(int curCol_SnakeHead, int curCol_food_Rec, int curRow_SnakeHead, int curRow_food_Rec) {
            if (Globals.currDirection == (int)Globals.En_currentDirection.up)
            {
                if (
                    (curRow_SnakeHead - 1 == curRow_food_Rec&& curCol_SnakeHead==curCol_food_Rec) ||
                    (curRow_SnakeHead  == curRow_food_Rec && curCol_SnakeHead == curCol_food_Rec)
                    )
                {
                    Globals.isFoodCollisionOccurred = true;
                    Globals.Score++;
                }
            }
        }
        //----------------------------------------------------------------------------------------------------------------------
        private void detect_The_Food_Collision_In_Down_Dir(int curCol_SnakeHead, int curCol_food_Rec, int curRow_SnakeHead, int curRow_food_Rec) {

            if (Globals.currDirection == (int)Globals.En_currentDirection.down )
            {
                if (
                    (curRow_SnakeHead + 1 == curRow_food_Rec&&curCol_SnakeHead == curCol_food_Rec) ||
                    (curRow_SnakeHead == curRow_food_Rec && curCol_SnakeHead == curCol_food_Rec)
                    )
                {
                    Globals.isFoodCollisionOccurred = true;
                    Globals.Score++;
                }
            }
        }
        //----------------------------------------------------------------------------------------------------------------------

    }
}
