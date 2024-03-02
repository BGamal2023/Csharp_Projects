using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Tetris_Game_2024.A_2_Dep.A_1_Creating_Shapes
{
    internal class Class1
    {
        //--------------------------------------------------------------------------------------

        private Rect create_Rec(int left, int top,int width,int height) {
        
        Rect rec=new Rect(left,top,width,height);
            
        return rec;
        }
    }
}
