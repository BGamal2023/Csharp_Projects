using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Tetris_Game_2024.__Globals;

namespace Tetris_Game_2024.A_2_Dep.A_3_Assets_Images_Handler
{
    internal class Assets_Images_Handler
    {
        //----------------------------------------------------------------------------------------------
        public void get_All_Blocks_Images_From_Assets_Folder_And_Add_Them_To_The_Dictionary()
        {
            //--
            var uri1 = new System.Uri("E:\\Programming\\12_C#\\Csharp_Projects\\Tetris_Game_2024\\Tetris_Game_2024\\Assets\\Block-I.png");
            var uri2 = new System.Uri("E:\\Programming\\12_C#\\Csharp_Projects\\Tetris_Game_2024\\Tetris_Game_2024\\Assets\\Block-J.png");
            var uri3 = new System.Uri("E:\\Programming\\12_C#\\Csharp_Projects\\Tetris_Game_2024\\Tetris_Game_2024\\Assets\\Block-L.png");
            var uri4 = new System.Uri("E:\\Programming\\12_C#\\Csharp_Projects\\Tetris_Game_2024\\Tetris_Game_2024\\Assets\\Block-O.png");
            var uri5 = new System.Uri("E:\\Programming\\12_C#\\Csharp_Projects\\Tetris_Game_2024\\Tetris_Game_2024\\Assets\\Block-S.png");
            var uri6 = new System.Uri("E:\\Programming\\12_C#\\Csharp_Projects\\Tetris_Game_2024\\Tetris_Game_2024\\Assets\\Block-T.png");
            var uri7 = new System.Uri("E:\\Programming\\12_C#\\Csharp_Projects\\Tetris_Game_2024\\Tetris_Game_2024\\Assets\\Block-Z.png");
            //--
            var stringUri_1= uri1.AbsoluteUri;
            var stringUri_2= uri2.AbsoluteUri;
            var stringUri_3 = uri3.AbsoluteUri;
            var stringUri_4 = uri4.AbsoluteUri;
            var stringUri_5 = uri5.AbsoluteUri;
            var stringUri_6 = uri6.AbsoluteUri;
            var stringUri_7 = uri7.AbsoluteUri;
            //--

            string Block_I_Name = "Body_I";
            string Block_J_Name = "Body_J";
            string Block_L_Name = "Body_L";
            string Block_O_Name = "Body_O";
            string Block_S_Name = "Body_S";
            string Block_T_Name = "Body_T";
            string Block_Z_Name = "Body_Z";
            //--
            Image Block_I = new Image
            {
                Width = 100,
                Height = 100,
                Name = Block_I_Name,
                Source = new BitmapImage(new Uri(stringUri_1)),
            };
            Image Block_J= new Image
            {
                Width = 100,
                Height = 100,
                Name = Block_I_Name,
                Source = new BitmapImage(new Uri(stringUri_2)),
            };
            Image Block_L = new Image
            {
                Width = 100,
                Height = 100,
                Name = Block_I_Name,
                Source = new BitmapImage(new Uri(stringUri_3)),
            };
            Image Block_O = new Image
            {
                Width = 100,
                Height = 100,
                Name = Block_I_Name,
                Source = new BitmapImage(new Uri(stringUri_4)),
            };
            Image Block_S = new Image
            {
                Width = 100,
                Height = 100,
                Name = Block_I_Name,
                Source = new BitmapImage(new Uri(stringUri_5)),
            };
            Image Block_T = new Image
            {
                Width = 100,
                Height = 100,
                Name = Block_I_Name,
                Source = new BitmapImage(new Uri(stringUri_6)),
            };
            Image Block_Z = new Image
            {
                Width = 100,
                Height = 100,
                Name = Block_I_Name,
                Source = new BitmapImage(new Uri(stringUri_7)),
            };
            //--
            Globals.li_Of_Blocks_Images.Add(Block_I_Name, Block_I);
            Globals.li_Of_Blocks_Images.Add(Block_J_Name, Block_J);
            Globals.li_Of_Blocks_Images.Add(Block_L_Name, Block_L);
            Globals.li_Of_Blocks_Images.Add(Block_O_Name, Block_O);
            Globals.li_Of_Blocks_Images.Add(Block_S_Name, Block_S);
            Globals.li_Of_Blocks_Images.Add(Block_T_Name, Block_T);
            Globals.li_Of_Blocks_Images.Add(Block_Z_Name, Block_Z);
            //--
        }
        //----------------------------------------------------------------------------------------------
  
      
}
}
