   M S B A M L   `   `   `  ����K  GTetris_Game_2024, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Tetris_Game_2024Tetris_Game_2024  5   	   !    Tetris_Game_2024.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Tetris_Game_2024     5   	   -   5          � Title$  Tetris��5   	   $	��600��6   $	��800��6%    � WindowStartupLocation$ CenterScreen=�5	   
   $	��600��5
   
   $	��600��6   
�������$��Segoe UI Light)�5   	   $��28(�6%   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5    
   (� $��1��5!      $��1��5"      $��0,0,0,20q�5#      .��5$      � -   5         �Name$ gameArea��5$      ���#101010$	��250��5&      $	��500��5'       � ShowGridLines$
 True��5(      5)      5*      �� 5+   
   $��1��6   $��1��5,      $��Center=�5-      $
��Left=�5.      .+�50      �� $
��Next��6    �� TextAlignment$ Center=�51      �� 52      -   5         ��Name$ 	nextImage��52      $��20q�53      $	��125��54      57      58      5;      