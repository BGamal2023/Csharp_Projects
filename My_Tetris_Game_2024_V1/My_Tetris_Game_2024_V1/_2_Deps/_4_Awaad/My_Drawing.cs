using My_Tetris_Game_2024_V1.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
            draw_The_Reached_Collisied_Frames_Permanintly(gameArea);
            foreach (My_Rect_For_Shapes i_My_Rect in the_Choosen_Shape)
            {
                Rectangle i_Rect = new Rectangle();
                
                if (i_My_Rect.filled == true)
                {
                    i_Rect = new Rectangle()
                    {
                        Width = Globals.block_piece_Width,
                        Height = Globals.block_piece_Hight,
                        Fill = new SolidColorBrush(Colors.Red),

                    };
                    Globals.curr_frame_Rectangles.Add(i_Rect);
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
        //-----------------------
        public void draw_The_Reached_Collisied_Frames_Permanintly(Grid gameArea)
        {
            for(int i=0;i<Globals.base_Rectangles.Count;i++)
            {
                Rectangle rect = Globals.base_Rectangles[i].rect;
                int Row = Globals.base_Rectangles[i].row;
                int Col = Globals.base_Rectangles[i].col;
                gameArea.Children.Add(rect);
                Grid.SetColumn(rect, Col);
                Grid.SetRow(rect, Row);
            }
        }
    }
}
