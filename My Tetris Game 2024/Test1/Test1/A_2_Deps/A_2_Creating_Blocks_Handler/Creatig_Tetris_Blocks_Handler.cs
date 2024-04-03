using My_Tetris_Game_2024.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace My_Tetris_Game_2024.A_2_Deps.A_2_Creating_Blocks_Handler
{
    internal class Creatig_Tetris_Blocks_Handler
    {
        //-------------------------------------------------------------------------------
        #region The Fields

        #endregion
        //-------------------------------------------------------------------------------
        public void creat_Blocks(Grid gameArea)
        {
            //--
            creat_I_Block(gameArea,Globals.block_init_col,Globals.block_init_Row);
            //--
        }
        //-------------------------------------------------------------------------------
        private void creat_I_Block(Grid gameArea ,int Col,int Row)
        {
            for (int i=0;i<3;i++)
            {
                Rectangle block_Piece = new Rectangle()
                {
                    Height = Globals.block_piece_Hight,
                    Width = Globals.block_piece_Width,
                    Fill=Brushes.Yellow,
                    Stroke = Brushes.Black,
                    StrokeThickness = 1
                };

                Globals.I_Block_Dic.Add(i,block_Piece);
        
            }
        }
        //-------------------------------------------------------------------------------
        private void creat_O_Block()
        {

        }
        //-------------------------------------------------------------------------------
        private void create_Z_Block()
        {

        }
        //-------------------------------------------------------------------------------
        private void create_L_Block()
        {

        }
        //-------------------------------------------------------------------------------
        private void create_T_Block()
        {

        }
        //-------------------------------------------------------------------------------
        private void create_J_Block()
        {

        }
        //-------------------------------------------------------------------------------
        private void create_S_Block()
        {

        }
    }
}
