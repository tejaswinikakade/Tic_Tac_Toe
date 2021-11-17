using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Tic_Tac_ToeGame game = new Tic_Tac_ToeGame();
            game.Board();
            game.choose();
            game.showBoard();
        }
    }
}