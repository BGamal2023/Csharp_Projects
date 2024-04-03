using My_Tetris_Game_2024.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace My_Tetris_Game_2024.A_2_Deps.A_5_Tetris_Shapes_Handler
{
    internal class L_Shape
    {
        private int no_Of_Blocks_In_L_Shape = 4;
        private int[] numbers_Of_Canvas_Blocks_For_L_Shape_0 = new int[4];
        private int[] numbers_Of_Canvas_Blocks_For_L_Shape_1 = new int[4];
        private int[] numbers_Of_Canvas_Blocks_For_L_Shape_2 = new int[4];
        private int[] numbers_Of_Canvas_Blocks_For_L_Shape_3 = new int[4];
        private Dictionary<int ,Rectangle> dic_L_shapes_Blocks= new Dictionary<int ,Rectangle>();

        public int [] get_No_Of_Cols_And_Rows_For_L_Blocks_Shape_0()
        {
            /// shape 0 will be in blocks numbers :- 1 4 7 8
            numbers_Of_Canvas_Blocks_For_L_Shape_0[0] = 1;
            numbers_Of_Canvas_Blocks_For_L_Shape_0[1] = 4;
            numbers_Of_Canvas_Blocks_For_L_Shape_0[2] = 7;
            numbers_Of_Canvas_Blocks_For_L_Shape_0[3] = 8;
            return numbers_Of_Canvas_Blocks_For_L_Shape_0;
            
        }
        //------------------------------------------------------------------------
        public int[] get_No_Of_Cols_And_Rows_For_L_Blocks_Shape_1()
        {
            /// shape 0 will be in blocks numbers :- 2 3 4 5
            numbers_Of_Canvas_Blocks_For_L_Shape_1[0] = 2;
            numbers_Of_Canvas_Blocks_For_L_Shape_1[1] = 3;
            numbers_Of_Canvas_Blocks_For_L_Shape_1[2] = 4;
            numbers_Of_Canvas_Blocks_For_L_Shape_1[3] = 5;
            return numbers_Of_Canvas_Blocks_For_L_Shape_1;

        }
        //------------------------------------------------------------------------
        public int[] get_No_Of_Cols_And_Rows_For_L_Blocks_Shape_2()
        {
            /// shape 0 will be in blocks numbers :- 0 1 4 7
            numbers_Of_Canvas_Blocks_For_L_Shape_2[0] = 0;
            numbers_Of_Canvas_Blocks_For_L_Shape_2[1] = 1;
            numbers_Of_Canvas_Blocks_For_L_Shape_2[2] = 4;
            numbers_Of_Canvas_Blocks_For_L_Shape_2[3] = 7;
            return numbers_Of_Canvas_Blocks_For_L_Shape_2;

        }
        //------------------------------------------------------------------------
        public int[] get_No_Of_Cols_And_Rows_For_L_Blocks_Shape_3()
        {
            /// shape 0 will be in blocks numbers :- 3 4 5 6
            numbers_Of_Canvas_Blocks_For_L_Shape_3[0] = 3;
            numbers_Of_Canvas_Blocks_For_L_Shape_3[1] = 4;
            numbers_Of_Canvas_Blocks_For_L_Shape_3[2] = 5;
            numbers_Of_Canvas_Blocks_For_L_Shape_3[3] = 6;
            return numbers_Of_Canvas_Blocks_For_L_Shape_3;

        }
        //------------------------------------------------------------------------
        public Dictionary<int , Rectangle> get_List_Of_L_Shapes_Blocks()
        {
            dic_L_shapes_Blocks.Clear();
            for (int i=0;i<no_Of_Blocks_In_L_Shape;i++)
            {
                Rectangle rec = new Rectangle()
                {
                    Width = Globals.block_piece_Width,
                    Height = Globals.block_piece_Hight,
                    Fill = Brushes.Green,
                    Stroke = Brushes.Black,
                    StrokeThickness = 1
                };
                dic_L_shapes_Blocks.Add(i, rec);
            }

            return dic_L_shapes_Blocks; 
           
        }
        //------------------------------------------------------------------------
    }
}
