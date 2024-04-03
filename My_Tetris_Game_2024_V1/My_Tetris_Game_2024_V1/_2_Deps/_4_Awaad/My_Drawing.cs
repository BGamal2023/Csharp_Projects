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
    internal class My_Drawing
    {
        public List<My_Rect_For_Shapes> collisied_frame = new List<My_Rect_For_Shapes>();
        //-----------------------
        public void draw(List<My_Rect_For_Shapes> the_Choosen_Shape, Grid gameArea)
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
        //---------------
        public void draw_The_Collisied_Frame_Permentally(List<My_Rect_For_Shapes> the_Choosen_Shape, Grid gameArea)
        {
            for (int i = 0; i < the_Choosen_Shape.Count; i++)
            {

                try
                {
                    My_Rect_For_Shapes i_Rect = the_Choosen_Shape[i];
                    collisied_frame[i].filled = i_Rect.filled;
                    collisied_frame[i].shapeType = i_Rect.shapeType;
                    collisied_frame[i].shapeRotation = i_Rect.shapeRotation;


                }
                catch (Exception e)
                {

                }

            }

            //------------------------

            foreach (My_Rect_For_Shapes i_My_Rect in collisied_frame)
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
