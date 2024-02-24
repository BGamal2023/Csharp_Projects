using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Reflection.Emit;
using My_Snake_Game_2024.__Globals;
using My_Snake_Game_2024._2_Deps._1_Snake_Body_Handler;
using My_Snake_Game_2024._2_Deps._2_Snake_Moving_Handler;
using My_Snake_Game_2024._2_Deps._3_Snake_Food_Handler;
using My_Snake_Game_2024._2_Deps._4_Collision_Handler;
using My_Snake_Game_2024._2_Deps._7_Player_Score_Handler;
using My_Snake_Game_2024.My_Libs.My_Lib_1.Globals;
using Label = System.Windows.Controls.Label;
using My_Snake_Game_2024._2_Deps._5_Game_Levels_Handler;
using My_Snake_Game_2024._2_Deps._A_10_Game_Area_Handler;
using My_Snake_Game_2024;
using My_Snake_Game_2024._2_Deps._9_List_Of_Snake_Pieces_Handler;


namespace My_Snake_Game_2024._1_Managers

{
    internal class General_Manager
    {
        //------------------------------------------------------------------------------------
        #region Fields
        private Snake_Body_Handler obj_Snake_Body_Handler =new Snake_Body_Handler();
        private Snake_Moving_Handler obj_Snake_Moving_Handler=new Snake_Moving_Handler();
        private Snake_Food_Handler obj_Snake_Food_Handler=new Snake_Food_Handler();
        private Food_Collision_Handler obj_Food_Collision_Handler=new Food_Collision_Handler();
        private Dead_Collision_Handler obj_Dead_Collision_Handler=new Dead_Collision_Handler();
        private Score_Handler obj_Score_Handler=new Score_Handler();
        private Game_Level_Handler obj_Game_Level_Handler=new Game_Level_Handler();
        private Game_Area_Handler obj_Game_Area_Handler = new Game_Area_Handler();
        private List_Of_Snake_Pieces_Handler obj_List_Of_Snake_Parts_Handler=new List_Of_Snake_Pieces_Handler();
        #endregion
        //------------------------------------------------------------------------------------
        #region Main_Method
        public void start_The_Game(MainWindow mainWindow,DispatcherTimer gameTimer)
        {
            //--
            Grid gameArea = draw_The_Grid_Cols_And_Rows_And_Add_The_First_Snake_Part_And_Food(mainWindow);
            //--
            handle_The_Snake_In_The_gameArea(gameTimer, gameArea);
            //--
        }


        #endregion
        //------------------------------------------------------------------------------------
        #region Auxilary Methods
        private Grid draw_The_Grid_Cols_And_Rows_And_Add_The_First_Snake_Part_And_Food(MainWindow mainwindow)
        {
            //--
            Grid gameArea = obj_Game_Area_Handler.handle_The_Game_Area(mainwindow);
            //--
            add_The_Snake_Head_To_The_gameArea(gameArea);
            //--
            obj_Snake_Food_Handler.feed_The_Snake_V1(gameArea);
            //--
            return gameArea;
            //--
        }
        //------------------------------------------------------------------------------------
        private void handle_The_Snake_In_The_gameArea(DispatcherTimer gameTimer,Grid gameArea)
        {
            create_And_Start_The_Timer_That_Will_Cyclically_Call_The_Snake_Handling_Methods(gameTimer,gameArea);
        }
        //------------------------------------------------------------------------------------
        private void create_And_Start_The_Timer_That_Will_Cyclically_Call_The_Snake_Handling_Methods(
            DispatcherTimer gameTimer, Grid gameArea)
        {
            //--
            #region define The Timer Tick Callback(the method that the timer will cyclically call).
            gameTimer.Tick += (sender, e) =>{ timer_Tick_Callback(sender, e, gameArea, gameTimer);};
            #endregion
            //--
            #region Set Timer Interval(The Game Speed).
            gameTimer.Interval = TimeSpan.FromMilliseconds(Globals.timerTick);
            #endregion
            //--
            #region Start The Timer
            gameTimer.Start();
            #endregion
            //--
        }
        //------------------------------------------------------------------------------------
        private void timer_Tick_Callback(
            object? sender, 
            EventArgs e, 
            Grid gameArea,
            DispatcherTimer gameTimer )
        {
            //--
          check_Dead_Collision(gameTimer);
            //--
            move_The_Snake();
            //--
            feed_The_Snake(gameArea);
            //--
            check_Food_Collision();
            //--
           /// update_Player_Score( scoreValue);
           /// update_Player_Healthy(playerHealth);
           /// update_The_Game_Level(level,gameTimer);
        }
        //------------------------------------------------------------------------------------
        private void add_The_Snake_Head_To_The_gameArea(Grid gameArea)
        {   
            obj_Snake_Body_Handler.add_The_Head_Of_The_Snake_To_The_List_Of_Snake_Parts(
                gameArea);
        }
        //------------------------------------------------------------------------------------
        private void move_The_Snake()
        {
            //--
            if (Global_Directions.goRight)
            {
                obj_Snake_Moving_Handler.move_The_Snake_To_The_Selected_Dir(Global_Directions.str_goRight);
            }
            //--
            else if (Global_Directions.goLeft)
            {
                obj_Snake_Moving_Handler.move_The_Snake_To_The_Selected_Dir(Global_Directions.str_goLeft);
            }
            //--
            else if (Global_Directions.goUp)
            {
                obj_Snake_Moving_Handler.move_The_Snake_To_The_Selected_Dir(Global_Directions.str_goUp);
            }
            //--
            else if (Global_Directions.goDown)
            {
                obj_Snake_Moving_Handler.move_The_Snake_To_The_Selected_Dir(Global_Directions.str_goDown);
            }
            //--
            else
            {
                obj_Snake_Moving_Handler.move_The_Snake_To_The_Selected_Dir(Global_Directions.str_goRight);
            }
            //--

       
        }
        //------------------------------------------------------------------------------------
        private void check_Food_Collision()
        {
            obj_Food_Collision_Handler.detect_The_Food_Collision();
        }
        //------------------------------------------------------------------------------------
        private void feed_The_Snake(Grid gameArea)
        {
            //--
            if (Globals.isFoodCollisionOccurred == true)
            {   //--
                obj_Snake_Food_Handler.eat_Snake_Food(gameArea);
                //--
                obj_Snake_Body_Handler.add_New_Part_To_Body_Of_The_Snake(gameArea);
                //--
                obj_Snake_Food_Handler.feed_The_Snake_V1(gameArea);
                //--
                Globals.isFoodCollisionOccurred = false;
                //--
            }
            //--
        }
        //------------------------------------------------------------------------------------
        private void check_Dead_Collision(DispatcherTimer gameTimer)
        {
            //--
            obj_Dead_Collision_Handler.detect_The_Dead_Collision();
            //--
            end_The_Game(gameTimer);
            //--
        }
        //------------------------------------------------------------------------------------
        private void end_The_Game(DispatcherTimer gameTimer)
        {
            //--
            if (Globals.isDeadCollisionOccurued == true)
            {
                Globals.playerHealth--;
                Globals.isDeadCollisionOccurued =false;
            }
            //--
            if (Globals.playerHealth == 0)
            {
                gameTimer.Stop();
                MessageBox.Show("Game Over");
            }
            //--
        }
        //------------------------------------------------------------------------------------
        private void update_Player_Score(Label scoreValue)
        {
            //--
            obj_Score_Handler.update_Player_Sore(scoreValue);
            //--
        }
        //------------------------------------------------------------------------------------
        private void update_Player_Healthy(Label player_Healthy)
        {
            //--
            player_Healthy.Content = Globals.playerHealth;
            //--
        }
        //------------------------------------------------------------------------------------
        private void update_The_Game_Level(Label levelValue,DispatcherTimer gameTimer)
        {
            //--
            levelValue.Content = Globals.Level;
            //--
            obj_Game_Level_Handler.update_Game_Level(gameTimer);
            //--
        }
        #endregion
        //------------------------------------------------------------------------------------

    }





}

    
    


