
using Tetris_Game_2024.My_Libs.My_Lib_1.Globals;
using System.Windows;
using System.Windows.Input;


namespace Tetris_Game_2024.My_Libs.My_Lib_1
{
    internal class Key_Strokes_Handler
    {
        //------------------------------------------------------------------------
        public void handle_The_Keys_Strokes(KeyEventArgs e)
        {
            //--
            switch (e.Key)
            {
                //--
                case Key.Up:
                    handle_The_Up_Key_Stroke();
                    break;
                //--
                case Key.Down:
                    handle_The_Down_Key_Stroke();
                    break;
                //--
                case Key.Left:
                    handle_The_Left_Key_Stroke();
                    break;
                //--
                case Key.Right:
                   handle_The_Right_Key_Stroke();
                    break;
                //--
                case Key.Space:
                //--
                   handle_The_Space_Key_Stroke();
                    break;
                //--
            }
            //--
        }
        //------------------------------------------------------------------------
        private void handle_The_Up_Key_Stroke()
        {
            if (Global_Directions.goDown == false)
            {
                //--
                Global_Directions.goUp = true;
                //--
                Global_Directions.goDown = false;
                Global_Directions.goRight = false;
                Global_Directions.goLeft = false;
                //--
            }
        }
        //------------------------------------------------------------------------
        private void handle_The_Down_Key_Stroke()
        {
            if (Global_Directions.goUp == false)
            {
                Global_Directions.goDown = true;
                Global_Directions.goUp = false;
                Global_Directions.goRight = false;
                Global_Directions.goLeft = false;
            }
        }
        //------------------------------------------------------------------------
        private void handle_The_Left_Key_Stroke()
        {
            if (Global_Directions.goRight == false)
            {
                Global_Directions.goLeft = true;
                Global_Directions.goDown = false;
                Global_Directions.goUp = false;
                Global_Directions.goRight = false;
            }
        }
        //------------------------------------------------------------------------
        private void handle_The_Right_Key_Stroke()
        {
            if (Global_Directions.goLeft == false)
            {
                Global_Directions.goRight = true;
                Global_Directions.goDown = false;
                Global_Directions.goUp = false;
                Global_Directions.goLeft = false;
            }
        }
        //------------------------------------------------------------------------
        private void handle_The_Space_Key_Stroke() { }
        //------------------------------------------------------------------------

    }
}
