using My_Tetris_Game_2024_V1.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Tetris_Game_2024_V1._2_Deps._4_Awaad
{
    internal class My_Rect_For_Shapes
    {
        public int row;
        public int col;
        public bool filled;
        public Globals.E_shapeType shapeType;
        public int shapeRotation;

        public My_Rect_For_Shapes(int row, int col, bool filled, Globals.E_shapeType shapeType, int shapeRotation)
        {
            this.row = row;
            this.col = col;
            this.filled = filled;
            this.shapeType = shapeType;
            this.shapeRotation = shapeRotation;



        }
    }
}
