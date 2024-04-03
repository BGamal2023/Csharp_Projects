using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Tetris_Game_2024_V1._2_Deps._4_Awaad
{
    internal class Base_Class
    {
       public int col;
        public int collision_Row;

        //-------------------------------------------
        public Base_Class(int col , int collision_Row)
        {
            this.col = col;
            this.collision_Row = collision_Row; 
        }
    }
}
