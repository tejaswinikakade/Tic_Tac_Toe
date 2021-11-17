using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Tic_Tac_ToeGame
    {
        char[] arr = new char[10];

        public void Board()
        {
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = ' ';
            }
        }
    }
}


        