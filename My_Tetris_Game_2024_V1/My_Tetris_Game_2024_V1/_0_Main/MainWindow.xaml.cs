using My_Tetris_Game_2024_V1.__Globals;
using My_Tetris_Game_2024_V1._1_General_Manager;
using My_Tetris_Game_2024_V1._2_Deps._4_Awaad;
using System.Diagnostics;
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

namespace My_Tetris_Game_2024_V1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //--------------------------------------------------------------------------------------
        General_Manager obj_General_Manager = new General_Manager();
        private DispatcherTimer gameTimer = new DispatcherTimer();
        private Rectangle rectangle1;
        private Rectangle rectangle2;
        private Rectangle rectangle3;
        private Rectangle rectangle4;
        private int count = 0;
        int counter_Of_Timer = 0;
        private Handling_Right_And_Left obj_Handling_Right_And_Left=new Handling_Right_And_Left();
        private My_Drawing obj_My_Drawing=new My_Drawing();
        private Handling_Down_Stroke obj_Handling_Down_Stroke=new Handling_Down_Stroke();
        private Handling_Down_Collision obj_Handling_Down_Collision=new Handling_Down_Collision();  
        //--------------------------------------------------------------------------------------
        public MainWindow()
        {
            InitializeComponent();
            //--
            obj_General_Manager.initialize_Window(this, gameArea);
            //--
            obj_General_Manager.initialize_The_Game(gameTimer, gameArea);
            //--

          /*  rectangle1 = new Rectangle()
            {
                Width = Globals.block_piece_Width,
                Height = Globals.block_piece_Hight,
                Fill = new SolidColorBrush(Colors.Red),
            };
            rectangle2 = new Rectangle()
            {
                Width = Globals.block_piece_Width,
                Height = Globals.block_piece_Hight,
                Fill = new SolidColorBrush(Colors.Red),
            };
            rectangle3 = new Rectangle()
            {
                Width = Globals.block_piece_Width,
                Height = Globals.block_piece_Hight,
                Fill = new SolidColorBrush(Colors.Red),
            };
            rectangle4 = new Rectangle()
            {
                Width = Globals.block_piece_Width,
                Height = Globals.block_piece_Hight,
                Fill = new SolidColorBrush(Colors.Red),
            };

            gameArea.Children.Add(rectangle1);
            gameArea.Children.Add(rectangle2);
            gameArea.Children.Add(rectangle3);
            gameArea.Children.Add(rectangle4);

            Grid.SetColumn(rectangle1, Globals.rect_1_Col);
            Grid.SetColumn(rectangle2, Globals.rect_2_Col);
            Grid.SetColumn(rectangle3, Globals.rect_3_Col);
            Grid.SetColumn(rectangle4, Globals.rect_4_Col);

            Grid.SetRow(rectangle1, Globals.rect_1_Row);
            Grid.SetRow(rectangle2, Globals.rect_2_Row);
            Grid.SetRow(rectangle3, Globals.rect_3_Row);
            Grid.SetRow(rectangle4, Globals.rect_4_Row);*/


            gameTimer.Interval = System.TimeSpan.FromMilliseconds(Globals.timerTick);
            gameTimer.Tick += timerTick;

            gameTimer.Start();
            /// create  4 rectangles 
            /// add them to the grid 
            /// change their position by up key stroke

        }

        private void timerTick(object? sender, EventArgs e)
        {
            /*
            Grid.SetColumn(rectangle1, Globals.rect_1_Col);
            Grid.SetColumn(rectangle2, Globals.rect_2_Col);
            Grid.SetColumn(rectangle3, Globals.rect_3_Col);
            Grid.SetColumn(rectangle4, Globals.rect_4_Col);

            Grid.SetRow(rectangle1, Globals.rect_1_Row);
            Grid.SetRow(rectangle2, Globals.rect_2_Row);
            Grid.SetRow(rectangle3, Globals.rect_3_Row);
            Grid.SetRow(rectangle4, Globals.rect_4_Row);*/


            if (counter_Of_Timer == 0)
            {

                Current_Item.fill_Next_Shape();
            }

            obj_Handling_Down_Collision.handle_Down_Collision(Current_Item.currFrame);
               
            if (Globals.D_Collision == false)
            {
                Handling_Going_Down.handle_Going_Down(Current_Item.currFrame, Current_Item.currFrame, gameArea);
                // obj_Handling_Right_And_Left.handle_Righ_And_Left_Strokes(Current_Item.currFrame);
                obj_My_Drawing.draw(Current_Item.currFrame, gameArea);
                counter_Of_Timer++;

            }
            else
            {
                Globals.D_Collision = false;
                counter_Of_Timer = 0;
                //---------------------------
                foreach (My_Rect_For_Shapes i_My_Rect in Current_Item.currFrame)
                {
                    Rectangle i_Rect = new Rectangle();

                    if (i_My_Rect.filled == true)
                    {
                        i_Rect = new Rectangle()
                        {
                            Width = Globals.block_piece_Width,
                            Height = Globals.block_piece_Hight,
                            Fill = new SolidColorBrush(Colors.Red),

                        };
                        Container_For_Down_Collisied_Frames base_rect
                            = new Container_For_Down_Collisied_Frames(i_Rect, i_My_Rect.row, i_My_Rect.col);
                        Globals.base_Rectangles.Add(base_rect);
                    }


                    //--------------------------
                  
                    /// below i am trying to catch the 4 or 3 rectangles to be staied below while new 3 get from up




                }
                //---------------------------


            }
        }

        private void handle_Key_Down_Strokes(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right)
            {
                Globals.isRIGHT = true;

                obj_Handling_Right_And_Left.handle_Righ_Strokes(Current_Item.currFrame);
                obj_My_Drawing.draw(Current_Item.currFrame, gameArea);



            }
            else if (e.Key == Key.Left)
            {
                Globals.isLEFT = true;
                obj_Handling_Right_And_Left.handle_Left_Strokes(Current_Item.currFrame);
                obj_My_Drawing.draw(Current_Item.currFrame, gameArea);


            }
            else if (e.Key== Key.Down)
            {
                obj_Handling_Down_Stroke.handle_Down_Strokes(Current_Item.currFrame);
                obj_My_Drawing.draw(Current_Item.currFrame, gameArea);

            }
        }

        private void handle_The_Key_Up_Strokes(object sender, KeyEventArgs e)
        {
           

            
            if (e.Key == Key.Up)
            {
                Current_Item.rotate();
                obj_My_Drawing.draw(Current_Item.currFrame, gameArea);

            }
            else if (e.Key == Key.Right)
            {
                Globals.isRIGHT = false;
            }
            else if (e.Key == Key.Left)
            {
                Globals.isLEFT = false;
            }
            else if(e.Key == Key.Down)
            {
                
            }
        }
        //-------------------------------------------------------------------------------------------\

    /* void draw(List<My_Rect_For_Shapes> the_Choosen_Shape)
        {
            //! bug# 10 remove the clear
            gameArea.Children.Clear();


            foreach (My_Rect_For_Shapes i_My_Rect in the_Choosen_Shape)
            {
                Rectangle i_Rect = new Rectangle()
                {
                    Width = Globals.block_piece_Width,
                    Height = Globals.block_piece_Hight,
                };
                if (i_My_Rect.filled == true)
                {
                    i_Rect = new Rectangle()
                    {
                        Width = Globals.block_piece_Width,
                        Height = Globals.block_piece_Hight,
                        Fill=new SolidColorBrush(Colors.Red),

                    };
                }
               
               

                try
                {
                    gameArea.Children.Add(i_Rect);

                    Grid.SetColumn(i_Rect, i_My_Rect.col);
                    Grid.SetRow(i_Rect, i_My_Rect.row);
                }catch (Exception ex)
                {

                }
               
            }
        }*/
    }
}