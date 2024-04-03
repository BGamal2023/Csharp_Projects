
using My_Tetris_Game_2024.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace My_Tetris_Game_2024.A_2_Deps.A_6_Creating_Rect
{
    internal class Creating_Rect
    {
        //--------------------------------------------------------------------------------------
        public Rectangle create_Rec(Grid gameArea,Brush color,int col,int row)
        {
            //--
            Rectangle rec = new Rectangle()
            {
                Width = Globals.mainWindow_Width,
                Height = Globals.block_piece_Hight,
                Fill = color,
                Stroke = Brushes.Black,
                StrokeThickness = 1
            };
            //--
            gameArea.Children.Add(rec);
            //--
            Grid.SetColumn(rec, col);
            Grid.SetRow(rec, row);
            //--
            return rec;
            //--
        }
        //------------------------------------------------------------------------------------------

    }

}
