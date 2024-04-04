using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace My_Tetris_Game_2024_V1._2_Deps._4_Awaad
{
    internal class Container_For_Down_Collisied_Frames
    {
       public  Rectangle rect;
        public int row;
        public int col;

        public Container_For_Down_Collisied_Frames(Rectangle rect, int row, int col)
        {
            this.rect = rect;
            this.row = row;
            this.col = col;
        }
    }
}
