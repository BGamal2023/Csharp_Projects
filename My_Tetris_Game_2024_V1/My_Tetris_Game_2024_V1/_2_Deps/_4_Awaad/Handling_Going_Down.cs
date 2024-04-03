using My_Tetris_Game_2024_V1.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace My_Tetris_Game_2024_V1._2_Deps._4_Awaad
{
    internal class Handling_Going_Down
    {


        public static  void handle_Going_Down(List<My_Rect_For_Shapes> currFrame, List<My_Rect_For_Shapes> the_Choosen_Shape, Grid gameArea)
        {
            foreach (My_Rect_For_Shapes i_My_Rect in currFrame)
            {
                i_My_Rect.row++;
            }

            draw_again(the_Choosen_Shape, gameArea);
        }

        //-----------------------------------------------------------------------------------------
       public static void draw_again(List<My_Rect_For_Shapes> the_Choosen_Shape ,Grid gameArea)
        {
            //! bug# 10 remove the clear
            
            gameArea.Children.Clear();


            foreach (My_Rect_For_Shapes i_My_Rect in the_Choosen_Shape)
            {
                Rectangle i_Rect = new Rectangle()
                {
                    Width = Globals.block_piece_Width,
                    Height = Globals.block_piece_Hight,
                };
                if (i_My_Rect.filled == true)
                {
                    i_Rect = new Rectangle()
                    {
                        Width = Globals.block_piece_Width,
                        Height = Globals.block_piece_Hight,
                        Fill = new SolidColorBrush(Colors.Red),

                    };
                }



                try
                {
                    gameArea.Children.Add(i_Rect);

                    Grid.SetColumn(i_Rect, i_My_Rect.col);
                    Grid.SetRow(i_Rect, i_My_Rect.row);
                }
                catch (Exception ex)
                {

                }

            }
        }
    }
}
