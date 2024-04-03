using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Tetris_Game_2024_V1._2_Deps._4_Awaad
{
    internal class Choosing_The_Next_Shape
    {
      public static  List<List<My_Rect_For_Shapes>> list_Of_All_Shapes_And_Rotations = new List<List<My_Rect_For_Shapes>>()
        {
            I_Shape.rotation_1,
            I_Shape.rotation_2,
            I_Shape.rotation_3,
            I_Shape.rotation_4,
            //--
            //! bug# 10 fill the rest of all shapes

            
        };
        public static List<My_Rect_For_Shapes> choose_The_Next_Shape()
        {
            List<My_Rect_For_Shapes> the_Choosen_Shape = new List<My_Rect_For_Shapes>();
            try
            {
                Random obj_Random = new Random();
                //! bug# 10 fix below
                //! bug# after finishing all shapes change 5 to 20
                int random_Number = obj_Random.Next(5);

                List<My_Rect_For_Shapes> random_Shape = list_Of_All_Shapes_And_Rotations[random_Number];
               

                for (int i = 0; i < random_Shape.Count; i++)
                {
                    My_Rect_For_Shapes i_MyRect_shape = random_Shape[i];
                    My_Rect_For_Shapes temp_My_Rect = new My_Rect_For_Shapes(i_MyRect_shape.row, i_MyRect_shape.col
                        , i_MyRect_shape.filled, i_MyRect_shape.shapeType, i_MyRect_shape.shapeRotation);

                    the_Choosen_Shape.Add(temp_My_Rect);

                }


                the_Choosen_Shape[0].row = -3;
                the_Choosen_Shape[0].col = 7;


                the_Choosen_Shape[1].row = -3;
                the_Choosen_Shape[1].col = 8;


                the_Choosen_Shape[2].row = -3;
                the_Choosen_Shape[2].col = 9;


                the_Choosen_Shape[3].row = -2;
                the_Choosen_Shape[3].col = 7;


                the_Choosen_Shape[4].row = -2;
                the_Choosen_Shape[4].col = 8;


                the_Choosen_Shape[5].row = -2;
                the_Choosen_Shape[5].col = 9;


                the_Choosen_Shape[6].row = -1;
                the_Choosen_Shape[6].col = 7;


                the_Choosen_Shape[7].row = -1;
                the_Choosen_Shape[7].col = 8;


                the_Choosen_Shape[8].row = -1;
                the_Choosen_Shape[8].col = 9;




                
            }
            catch (Exception ex)
            {

            }
            return the_Choosen_Shape;

        }

    }
}
