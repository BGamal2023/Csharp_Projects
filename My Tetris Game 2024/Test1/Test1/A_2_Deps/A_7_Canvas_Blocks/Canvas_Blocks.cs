using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace My_Tetris_Game_2024.A_2_Deps.A_7_Canvas_Blocks
{
    internal class Canvas_Blocks
    {
        //----------------------------------------------------------------------------
        int col;
        int row;
        Brushes color;
        //----------------------------------------------------------------------------
        public Canvas_Blocks(int col, int row, Brushes color)
        {
            this.col = col;
            this.row = row;
            this.color = color;
        }
        //----------------------------------------------------------------------------
        public Canvas_Blocks(int col, int row)
        {
            this.col = col;
            this.row = row;
          
        }
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



    }


}
