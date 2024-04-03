using My_Tetris_Game_2024_V1.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace My_Tetris_Game_2024_V1._2_Deps._2_Canvas_Area_Handler
{
    internal class Canvas_Block
    {
        //----------------------------------------------------------------------------
        int col;
        int row;
        Brushes color;
        //----------------------------------------------------------------------------
        public Canvas_Block(int col, int row, Brushes color)
        {
            this.col = col;
            this.row = row;
            this.color = color;
        }
        //----------------------------------------------------------------------------
        public Canvas_Block(int col, int row)
        {
            this.col = col;
            this.row = row;
          
        }
        //----------------------------------------------------------------------------
        public Canvas_Block() { }
        //----------------------------------------------------------------------------
        public int getCol() { return col; }
        //----------------------------------------------------------------------------
        public int getRow() { return row; }
        //----------------------------------------------------------------------------
        public Brushes getColor() { return color; }
        //----------------------------------------------------------------------------
        public void setCol(int col) { this.col = col; }
        //----------------------------------------------------------------------------
        public void setRow(int row) { this.row = row; }
        //----------------------------------------------------------------------------
        public void setColor(Brushes color) { this.color = color; }
        //----------------------------------------------------------------------------
        public void creat_The_Canvas_Area()
        {
            Canvas_Block cavasBlock_0 = new Canvas_Block(7, 0);
            Canvas_Block cavasBlock_1 = new Canvas_Block(8, 0);
            Canvas_Block cavasBlock_2 = new Canvas_Block(9, 0);
            Canvas_Block cavasBlock_3 = new Canvas_Block(7, 1);
            Canvas_Block cavasBlock_4 = new Canvas_Block(8, 1);
            Canvas_Block cavasBlock_5 = new Canvas_Block(9, 1);
            Canvas_Block cavasBlock_6 = new Canvas_Block(7, 2);
            Canvas_Block cavasBlock_7 = new Canvas_Block(8, 2);
            Canvas_Block cavasBlock_8 = new Canvas_Block(9, 2);
            Globals.dic_Canvas_Blocks.Add(0, cavasBlock_0);
            Globals.dic_Canvas_Blocks.Add(1, cavasBlock_1);
            Globals.dic_Canvas_Blocks.Add(2, cavasBlock_2);
            Globals.dic_Canvas_Blocks.Add(3, cavasBlock_3);
            Globals.dic_Canvas_Blocks.Add(4, cavasBlock_4);
            Globals.dic_Canvas_Blocks.Add(5, cavasBlock_5);
            Globals.dic_Canvas_Blocks.Add(6, cavasBlock_6);
            Globals.dic_Canvas_Blocks.Add(7, cavasBlock_7);
            Globals.dic_Canvas_Blocks.Add(8, cavasBlock_8);
        }



    }


}
