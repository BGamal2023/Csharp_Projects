using My_Tetris_Game_2024.A_2_Deps.A_0_MainWindow_Handler;
using My_Tetris_Game_2024.A_2_Deps.A_1_GamaArea_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Tetris_Game_2024;
using System.Windows.Controls;
using System.Windows.Threading;
using My_Tetris_Game_2024.A_2_Deps.A_2_Creating_Blocks_Handler;
using My_Tetris_Game_2024.__Globals;
using System.Windows.Shapes;
using System.Diagnostics;
using My_Tetris_Game_2024.A_2_Deps.A_5_Tetris_Shapes_Handler;
using My_Tetris_Game_2024.A_2_Deps.A_6_Creating_Rect;
using System.Windows.Media;
using My_Tetris_Game_2024.A_2_Deps.A_7_Canvas_Blocks;
using My_Tetris_Game_2024.A_2_Deps.A_5_Tetris_Blocks_Handler;

namespace My_Tetris_Game_2024.A_1_General_Manager
{
    internal class General_Manager
    {
        //--------------------------------------------------------------------
        #region The Fields
        private MainWindow_Handler obj_MainWindow_Handler = new MainWindow_Handler();
        private GameArea_Handler obj_GameArea_Handler = new GameArea_Handler();
        private Creatig_Tetris_Blocks_Handler obj_Creatig_Tetris_Blocks_Handler=new Creatig_Tetris_Blocks_Handler();
        private L_Shape obj_L_Block=new L_Shape();
        private Creating_Rect obj_Creating_Rect=new Creating_Rect();
        private Dictionary<int, int[]> dic_L_Block_Current_Selected_Shape = new Dictionary<int, int[]>();
        //32938ujoewiuqpoiuewporuopqjwepoiropiqorit

        private Creating_The_Canvas_Blocks obj_Creating_The_Canvas_Blocks=new Creating_The_Canvas_Blocks();
        private Drawing_In_Canvas_Blocks_Area obj_Drawing_In_Canvas_Blocks_Area=new Drawing_In_Canvas_Blocks_Area();  
        private Tetris_Shapes_Manager obj_Tetris_Shapes_Manager=new Tetris_Shapes_Manager();

        //oqu020750820809280980924809wuiuqwoieuroiu
        #endregion
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
        public void initialize_The_Game(DispatcherTimer gameTimer,Grid gameArea)
        {
            //--
            obj_Creating_The_Canvas_Blocks.create_The_Canvas_Blocks();
            //--
            ///create 4 rectangles to l shpae ....get default cols and rows 
            ///control moving 
            ///and if up is pressed changle change :-
            ///     1- get the current cols and rows for the canvas block
            ///     2- change the cols and rows for the container to draw the new shape
            ///     
            ///- once the collision detected create other 4 retangles and for differnt shape for exampel 
            obj_Drawing_In_Canvas_Blocks_Area.draw_The_Req_Tetris_Shap_In_The_Canvas_Blocks(gameArea);
            //-
        }
        //--------------------------------------------------------------------
        public void Tick(DispatcherTimer gameTimer,Grid gameArea) {

            update(gameArea);
            /// move the canvas block
            /// fill at new position
            
        }
        //--------------------------------------------------------------------
        private void draw_The_Titris_Block(Grid gameArea, Dictionary<int, int[]> dic_L_Block_Current_Selected_Shape)
        {
            dic_L_Block_Current_Selected_Shape.Clear();
            for (int i = 0; i < 4; i++)
            {
                int[] col_And_row_current_Rect = dic_L_Block_Current_Selected_Shape[i];
                obj_Creating_Rect.create_Rec( gameArea, Brushes.Green, col_And_row_current_Rect[0], col_And_row_current_Rect[1]);
            }
        }
        //--------------------------------------------------------------------
        private void update(Grid gameArea)
        {
            //--
            obj_Tetris_Shapes_Manager.get_The_Required_Inner_Shape_Type_For_Current_Shown_Tetris();
            //--
            obj_Drawing_In_Canvas_Blocks_Area.draw_The_Req_Tetris_Shap_In_The_Canvas_Blocks(gameArea);

        }
        //--------------------------------------------------------------------
        private Dictionary<int, int[]> get_Selected_shape(int selected_Shape_No)
        {
            /*switch(selected_Shape_No)
            {
                case 0:
                    return obj_L_Block.fill_The_dic_L_Block_Shape_0();
                    break;
                case 1:
                    return obj_L_Block.fill_The_dic_L_Block_Shape_1();  
                    break;
                case 2:
                    return obj_L_Block.fill_The_dic_L_Block_Shape_2();
                    break;
                case 3:
                    return obj_L_Block.fill_The_dic_L_Block_Shape_3();
                    break;

                 default:
                    return obj_L_Block.fill_The_dic_L_Block_Shape_0();
                    break;
            }*/
            return null;
        }

        //-------------------------------------------------------------------------------
        public void update_The_Game()
        {
         
            
        }

    }
}
