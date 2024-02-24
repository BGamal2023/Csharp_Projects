using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Controls;
using My_Snake_Game_2024.__Globals;
using System.Windows.Media;
using My_Snake_Game_2024.My_Libs.My_Lib_1.Globals;
using My_Snake_Game_2024._2_Deps._8_Create_Rectangle;


namespace My_Snake_Game_2024._2_Deps._9_List_Of_Snake_Pieces_Handler
{
    internal class List_Of_Snake_Pieces_Handler
    {
        private static List<Rectangle> list_Of_The_Snake_Pieces = new List<Rectangle>();
        private Creating_Rect obj_Creating_Rect=new Creating_Rect();
        //---------------------------------------------------------------------------------------------
        public void add_To_The_Snake_Pieces_List(Rectangle rect)
        {
            list_Of_The_Snake_Pieces.Add(rect);
        }
        //---------------------------------------------------------------------------------------------
        public List<Rectangle> get_The_Snake_Pieces_List()
        {
          return  list_Of_The_Snake_Pieces;
        }
        //---------------------------------------------------------------------------------------------
        public int get_Col(int i)
        {
            return Grid.GetColumn(list_Of_The_Snake_Pieces[i]);
        }
        //---------------------------------------------------------------------------------------------
        public int get_Row(int i)
        {
            return Grid.GetRow(list_Of_The_Snake_Pieces[i]);
        }
        //---------------------------------------------------------------------------------------------
        public int get_The_Count_Of_The_Snake_Pieces()
        {
            return list_Of_The_Snake_Pieces.Count;
        }
        //---------------------------------------------------------------------------------------------
        public Rectangle get_The_Last_Piece_In_The_Snake()
        {
            return list_Of_The_Snake_Pieces[^1];
        }
        //---------------------------------------------------------------------------------------------
        public Rectangle get_One_Piece_From_The_Snake_Pieces_List(int i)
        {
            return list_Of_The_Snake_Pieces[i];
        }
 

    }
}
