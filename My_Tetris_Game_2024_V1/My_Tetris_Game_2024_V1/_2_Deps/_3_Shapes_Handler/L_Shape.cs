using My_Tetris_Game_2024_V1.__Globals;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace My_Tetris_Game_2024_V1._2_Deps._3_Shapes_Handler
{
    class L_Shape
    {
        public static Dictionary<int , Rectangle> dic_L_Shape_Pieces= new Dictionary<int , Rectangle>();    
        //---------------------------------------------------------------------
        public void create_L_Shape()
        {
            for (int i=0; i < 4; i++)
            {
                Rectangle one_Piece_Of_Shape = new Rectangle()
                {
                    Width = Globals.block_piece_Width,
                    Height = Globals.block_piece_Hight,
                    Fill = Brushes.Green,
                    Stroke = Brushes.Black,
                    StrokeThickness = 1

                };
                dic_L_Shape_Pieces.Add(i, one_Piece_Of_Shape);
            }
           
        }
        //---------------------------------------------------------------------
        public void add_L_Shape_Pieces_To_gameArea(Grid gameArea)
        {
           //!bug #0 security here

            for (int i=0;i<dic_L_Shape_Pieces.Count;i++)
            {
                gameArea.Children.Add(dic_L_Shape_Pieces[i]);
            }

        }
        //---------------------------------------------------------------------
        public void set_Cols_And_Rows_For_The_L_Shape_Pieces()
        {
           for(int i = 0; i < dic_L_Shape_Pieces.Count; i++)
            {
              
            }
        }
    }
}
