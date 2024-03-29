﻿using My_Snake_Game_2024._1_Managers;
using My_Snake_Game_2024.My_Libs.My_Lib_1;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace My_Snake_Game_2024
{
   
    public partial class MainWindow : Window
    {
        //----------------------------------------------------------------------------------------
        #region Fields
        General_Manager obj_General_Manager = new General_Manager();
        Key_Strokes_Handler obj_Key_Strokes_Handler = new Key_Strokes_Handler();
        DispatcherTimer gameTimer = new DispatcherTimer();
        #endregion
        //----------------------------------------------------------------------------------------
        #region App Entry Point
        public MainWindow()
        {
            //--
            InitializeComponent();
            //--
            obj_General_Manager.start_The_Game(this,gameTimer);
            //--
        }
        #endregion
        //----------------------------------------------------------------------------------------
        #region Key Strokes Handling

        private void handle_The_Keys_Strokes(object sender, KeyEventArgs e)
        {
            obj_Key_Strokes_Handler.handle_The_Keys_Strokes(e);
        }
        #endregion
        //----------------------------------------------------------------------------------------
    }
}