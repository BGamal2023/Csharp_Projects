﻿using My_Snake_Game_2024.__Globals;
using My_Snake_Game_2024._2_Deps._9_List_Of_Snake_Pieces_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace My_Snake_Game_2024._2_Deps._8_Create_Rectangle
{
    internal class Creating_Rect
    {
        //--------------------------------------------------------------------------------------
        public Rectangle create_Rec(Grid gameArea,Brush color,int X,int Y)
        {
            //--
            Rectangle rec = new Rectangle()
            {
                Width = Globals.snake_Width,
                Height = Globals.snake_Height,
                Fill = color,
                Stroke = Brushes.Black,
                StrokeThickness = 1
            };
            //--
            gameArea.Children.Add(rec);
            //--
            Grid.SetColumn(rec, X);
            Grid.SetRow(rec, Y);
            //--
            return rec;
            //--
        }
        //------------------------------------------------------------------------------------------

    }

}
