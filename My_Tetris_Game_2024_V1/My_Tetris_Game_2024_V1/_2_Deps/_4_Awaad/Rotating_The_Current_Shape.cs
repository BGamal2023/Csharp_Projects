using My_Tetris_Game_2024_V1.__Globals;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Tetris_Game_2024_V1._2_Deps._4_Awaad
{
    internal class Rotating_The_Current_Shape
    {

        public static List<My_Rect_For_Shapes> rotate_The_Curr_Shape(List<My_Rect_For_Shapes> currFrame)
        {
            List<My_Rect_For_Shapes> the_Choosen_Shape=currFrame;
            Globals.E_shapeType curr_Shape_Type = currFrame[0].shapeType;
            int old_Rotation = currFrame[0].shapeRotation;
            int nextRotation = old_Rotation + 1;

            if (nextRotation > 4)
            {
                nextRotation = 1;
              
            }
            Debug.WriteLine("nextRotationn= " + nextRotation);




           

            switch (curr_Shape_Type)
            {
                case Globals.E_shapeType.I:


                    if (nextRotation == 1)
                    {
                        the_Choosen_Shape = I_Shape.rotation_1;
                        
                        /*Debug.WriteLine("Case 1");
                        Debug.WriteLine("The choosen shape rotation inside if = " + the_Choosen_Shape[0].shapeRotation);
                       */ 
                        
                   //  Debug.WriteLine("the I_shape rotation 1= " + I_Shape.rotation_1[0].shapeRotation);
                    }else if (nextRotation == 2)
                    {
                        the_Choosen_Shape = I_Shape.rotation_2;
                        Debug.WriteLine("Case 2");
                    }else if (nextRotation == 3)
                    {
                        the_Choosen_Shape = I_Shape.rotation_3;
                        Debug.WriteLine("Case 3");
                    } else if (nextRotation == 4)
                    {
                        the_Choosen_Shape = I_Shape.rotation_4;
                        Debug.WriteLine("Case 4");
                    }
                   








                /*    switch (nextRotation)
                    {
                        case 1:
                            the_Choosen_Shape = I_Shape.rotation_1;
                            Debug.WriteLine("Case 1");
                            break;
                        case 2: 
                            the_Choosen_Shape = I_Shape.rotation_2;
                            Debug.WriteLine("Case 2");

                            break;
                        case 3: 
                            
                            the_Choosen_Shape = I_Shape.rotation_3;
                            Debug.WriteLine("Case 3");

                            break;
                        case 4:
                            the_Choosen_Shape = I_Shape.rotation_4;
                            Debug.WriteLine("Case 4");

                            break;
                    }*/

                    break;
                    //bug# 10 fill the rest
                case Globals.E_shapeType.O: break;
                case Globals.E_shapeType.T: break;
                case Globals.E_shapeType.S: break;
                case Globals.E_shapeType.L: break;


            }

            Debug.WriteLine("the sent choosen shape rotation= " + the_Choosen_Shape[0].shapeRotation);
            return the_Choosen_Shape;
        }
    }
}
