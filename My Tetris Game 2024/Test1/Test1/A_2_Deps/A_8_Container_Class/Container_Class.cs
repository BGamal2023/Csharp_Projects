using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace My_Tetris_Game_2024.A_2_Deps.A_8_Container_Class
{
    internal class Container_Class
    {

        //-------------------------------------------------------------
        private Rectangle one_Piece_Of_Shape;
        private int currCol;
        private int currRow;
        //--------------------------------------------------------------
        public Container_Class(Rectangle one_Piece_Of_Shape, int currCol, int currRow)
        {
            this.one_Piece_Of_Shape = one_Piece_Of_Shape;
            this.currCol = currCol; 
            this.currRow = currRow; 
        }
        //--------------------------------------------------------------
        public Rectangle get_one_Piece_Of_Shape()
        {
            return one_Piece_Of_Shape;  
        }
        //--------------------------------------------------------------
        public int get_curr_Col()
        {
            return currCol;
        }
        //--------------------------------------------------------------
        public int get_curr_Row() { return currRow; }
        //--------------------------------------------------------------
       
    }

}
