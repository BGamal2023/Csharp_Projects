using My_Tetris_Game_2024_V1.__Globals;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Tetris_Game_2024_V1._2_Deps._4_Awaad
{
    internal class Current_Item
    {
        public static List<My_Rect_For_Shapes> currFrame = new List<My_Rect_For_Shapes>();
        
        public static void rotate()
        {
            List<My_Rect_For_Shapes> chosen_Shape=  Rotating_The_Current_Shape.rotate_The_Curr_Shape(currFrame);
            Debug.WriteLine("recived choosen shape rotation = " + chosen_Shape[0].shapeRotation);
            for (int i = 0; i < chosen_Shape.Count; i++)
            {
                try
                {
                    My_Rect_For_Shapes i_Rect = chosen_Shape[i];
                    currFrame[i].filled = i_Rect.filled;
                    currFrame[i].shapeType = i_Rect.shapeType;
                    currFrame[i].shapeRotation = i_Rect.shapeRotation;
                }
                catch (Exception e) {
                }
            }
        }
        public static void fill_Next_Shape()
        {
           List<My_Rect_For_Shapes> choosenShape= Choosing_The_Next_Shape.choose_The_Next_Shape();
            currFrame = choosenShape;
        }
        /// public static List<My_Rect_For_Shapes> currShape=new List<My_Rect_For_Shapes>();

        /*
                public void fill_Curr_Shape( List<My_Rect_For_Shapes> chosen_Shape)
                {
                   currShape= chosen_Shape;
                }*/
    }

}
