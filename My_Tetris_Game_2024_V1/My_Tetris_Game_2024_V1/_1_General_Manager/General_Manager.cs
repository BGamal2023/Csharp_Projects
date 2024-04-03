using My_Tetris_Game_2024_V1._2_Deps._0_MainWindow_Handler;
using My_Tetris_Game_2024_V1._2_Deps._1_GameArea_Handler;
using My_Tetris_Game_2024_V1._2_Deps._2_Canvas_Area_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace My_Tetris_Game_2024_V1._1_General_Manager
{
    class General_Manager
    {
        //------------------------------------------------------------------------------
        private Canvas_Block obj_Canvas_Block = new Canvas_Block();
        private MainWindow_Handler obj_MainWindow_Handler=new MainWindow_Handler();
        private GameArea_Handler obj_GameArea_Handler=new GameArea_Handler();


        //------------------------------------------------------------------------------
        public void main_Method() 
        { 
            obj_Canvas_Block.creat_The_Canvas_Area();

          
        }
        //------------------------------------------------------------------------------
        //--------------------------------------------------------------------
        public void initialize_Window(MainWindow mWindow, Grid gameArea)
        {
            //--
            obj_MainWindow_Handler.handle_mainWindow(mWindow);
            //--
            obj_GameArea_Handler.handle_GameArea(gameArea);
            //--
        }
        //--------------------------------------------------------------------
        public void initialize_The_Game(DispatcherTimer gameTimer, Grid gameArea)
        {
            //--
          ///  obj_Creating_The_Canvas_Blocks.create_The_Canvas_Blocks();
            //--
            ///create 4 rectangles to l shpae ....get default cols and rows 
            ///control moving 
            ///and if up is pressed changle change :-
            ///     1- get the current cols and rows for the canvas block
            ///     2- change the cols and rows for the container to draw the new shape
            ///     
            ///- once the collision detected create other 4 retangles and for differnt shape for exampel 
           /// obj_Drawing_In_Canvas_Blocks_Area.draw_The_Req_Tetris_Shap_In_The_Canvas_Blocks(gameArea);
            //-
        }
        //--------------------------------------------------------------------
    }
}
