using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Tetris_Game_2024.A_2_Deps.A_4_Rotating_Shape_Handler
{
    internal class Class1
    {

        /// fill initial case
        /// i have 4 cases 0 , 1 ,2 ,3 
        /// every up press increase case ++1
        /// switch for every case 
        /// case 0 .....fill (0 1 4 7) 
        /// case 1......fill (3 4 5 6)
        /// case 2......fill (1 4 7 8)
        /// case 3......fill (2 3 4 5)
        /// cols 7 8 9  rows 0 1 2 .....
        /// 

        ///1- create 4 rectangles 
        ///2- set there positions as case0




        /// requirements:_
        /// 4 cases every case represent different cols and rows
        /// case 1 = 7,0 ...7,1 .... 8,1 .... 9,1 
        /// case 2=  8,0 ...8,1.....8,2 ......9,0
        /// case 3= 7,1 .... 8,1....9,1 ......9,2
        /// case 4= 8,0 .... 8,1 ...8,2.....7,2
        /// case 1 dictionary ....dicti<int ,int []> case1_l_block
        /// 

        /// 1 variable changing form 0 to 3 then be 0 again wiht up strike 
        /// every time i will check this number and deliver it to switch case .....
        Dictionary<int, int[][]> casese_1_L_Block=new Dictionary<int, int[][]>();

    }
}
