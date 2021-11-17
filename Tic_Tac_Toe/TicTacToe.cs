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
                Console.WriteLine(arr[i]);
            }
        }

        public void choose()
        {
            Console.WriteLine("Player 1 - Choose the letter 'X' OR 'O'");
            string l1 = Console.ReadLine();
            string p1;
            string p2;

            if (l1 == "X")
            {
                Console.WriteLine("Player 1 is using 'X'");
                Console.WriteLine("Player 2 is using 'O'");
                p1 = "X";
                p2 = "O";
            }
            else
            {
                Console.WriteLine("Player 1 is using 'O'");
                Console.WriteLine("Player 2 is using 'X'");
                p1 = "O";
                p2 = "X";
            }

        }

        public void showBoard()
        {
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", arr[1], arr[2], arr[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", arr[4], arr[5], arr[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", arr[7], arr[8], arr[9]);
        }
    }
}