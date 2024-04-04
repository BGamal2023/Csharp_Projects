using My_Tetris_Game_2024_V1.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace My_Tetris_Game_2024_V1._2_Deps._4_Awaad
{
    internal class Handling_Down_Collision
      
    {
        public static List<Base_Class> list_of_All_Cols_And_Thier_Collision_Row = new List<Base_Class>()
        {
            new Base_Class(0,Globals.No_Of_gameArea_Rows),
            new Base_Class(1,Globals.No_Of_gameArea_Rows),
            new Base_Class(2,Globals.No_Of_gameArea_Rows),
            new Base_Class(3,Globals.No_Of_gameArea_Rows),
            new Base_Class(4,Globals.No_Of_gameArea_Rows),
            new Base_Class(5,Globals.No_Of_gameArea_Rows),
            new Base_Class(6,Globals.No_Of_gameArea_Rows),
            new Base_Class(7,Globals.No_Of_gameArea_Rows),
            new Base_Class(8,Globals.No_Of_gameArea_Rows),
            new Base_Class(9,Globals.No_Of_gameArea_Rows),
            new Base_Class(10,Globals.No_Of_gameArea_Rows),
            new Base_Class(11,Globals.No_Of_gameArea_Rows),
            new Base_Class(12,Globals.No_Of_gameArea_Rows),
            new Base_Class(13,Globals.No_Of_gameArea_Rows),
            new Base_Class(14,Globals.No_Of_gameArea_Rows),
            new Base_Class(15,Globals.No_Of_gameArea_Rows),
            new Base_Class(16,Globals.No_Of_gameArea_Rows),
            new Base_Class(17,Globals.No_Of_gameArea_Rows)
            
        };
       /// for every col update collision row 
       /// start collision row by defalut for all cols is (max num of rows)
       /// every tick get curframe get from every rect its col and its row 
       /// then compare list of all cols and thier collision rows 
       /// if for example col10 has collision row 10 and from curr faram col 10 has row 5 take it then col10 now has collision row=5
       


        /// how to detect collision 
        /// every tick go and compare currframe col and row then compare if any curr frame col contain collison row -1 then stop s
        int collission_Row;
        

        //------------------------------------------------------------------------------------
        public void handle_Down_Collision(List<My_Rect_For_Shapes> currFrame)
        {
           
            
                foreach (My_Rect_For_Shapes i_My_Rect in currFrame)
                {

                if (Globals.base_Rectangles.Count == 0)
                {
                    //----
                    if (i_My_Rect.filled)
                    {

                        if (i_My_Rect.row == Globals.No_Of_gameArea_Rows - 2)
                        {
                            Globals.D_Collision = true;
                        }
                    }

                    //---
                }
                else
                {
                    if (i_My_Rect.filled)
                    {
                        for (int i = 0; i < Globals.base_Rectangles.Count; i++)
                        {

                            if (i_My_Rect.col == Globals.base_Rectangles[i].col && i_My_Rect.row + 1 == Globals.base_Rectangles[i].row)
                            {
                                Globals.D_Collision = true;
                            }
                            else
                            {
                                if (i_My_Rect.row == Globals.No_Of_gameArea_Rows - 2)
                                {
                                    Globals.D_Collision = true;
                                }
                            }
                        }

                    }
                }

            }


        }
        //----------------------------------------------------------------------------------------
        public void update_List_of_Cols_and_Thier_Collision_rows(List<My_Rect_For_Shapes> currFrame)
        {
            if (Globals.D_Collision == true)
            {

                foreach (My_Rect_For_Shapes i_My_Rect in currFrame)
                {
                    if (list_of_All_Cols_And_Thier_Collision_Row[i_My_Rect.col].collision_Row > i_My_Rect.row)
                    {
                        list_of_All_Cols_And_Thier_Collision_Row[i_My_Rect.col].collision_Row = i_My_Rect.row;
                    }
                }
            }
        }

    }
}
