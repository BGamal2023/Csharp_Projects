using My_Tetris_Game_2024.__Globals;
using My_Tetris_Game_2024.A_2_Deps.A_0_MainWindow_Handler;
using My_Tetris_Game_2024.A_2_Deps.A_1_GamaArea_Handler;
using My_Tetris_Game_2024.A_2_Deps.A_5_Tetris_Blocks_Handler;
using My_Tetris_Game_2024.A_2_Deps.A_7_Canvas_Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace My_Tetris_Game_2024.A_1_General_Manager
{
    internal class General_Manager_V1
    {
        //------------------------------------------------------------------------------------
        #region The Fields
        public MainWindow_Handler obj_MainWindow_Handler=new MainWindow_Handler();
        public GameArea_Handler obj_GameArea_Handler=new GameArea_Handler();
        public Creating_The_Canvas_Blocks obj_Creating_The_Canvas_Blocks=new Creating_The_Canvas_Blocks();
        private Selector_Shapes obj_Selector_Shapes=new Selector_Shapes();

        #endregion

        //------------------------------------------------------------------------------------
        public void initialize_Window(MainWindow mWindow, Grid gameArea)
        {
            //--
            obj_MainWindow_Handler.handle_mainWindow(mWindow);
            //--
            obj_GameArea_Handler.handle_GameArea(gameArea);
            //--
        }
        //------------------------------------------------------------------------------------
        public void initialize_The_Game(DispatcherTimer gameTimer, Grid gameArea)
        {
            //--
            obj_Creating_The_Canvas_Blocks.create_The_Canvas_Blocks();
            //--
            obj_GameArea_Handler.initialize_First_Shape(gameArea);
            //-
        }
        //------------------------------------------------------------------------------------
        public void Tick(DispatcherTimer gameTimer, Grid gameArea)
        {
            update(gameArea);
            /// move the canvas block
            /// fill at new position

        }

        private void update(Grid gameArea)
        {
            //--
            if(Globals.isCollision==true)
            {
                obj_Selector_Shapes.detect_The_Shape_That_Should_Be_Drawen();
                /// draw the shape 
            }
            /// get the required shape.
            

            /// update the positions only in the container dictionary (the container class)
            /// then draw it again
            //--

            Globals.reqShape++;
            Globals.does_I_Shape_Selected = false;
            Globals.does_J_Shape_Selected=false;
            Globals.does_O_Shape_Selected = false;
            Globals.does_T_Shape_Selected = false;
            Globals.does_S_Shape_Selected = false;
            Globals.does_L_Shape_Selected = false;
            Globals.does_Z_Shape_Selected= false;

        }
    }  
}
