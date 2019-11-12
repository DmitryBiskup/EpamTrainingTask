using System;
using System.Threading;
using EpamGame.Enums;
using EpamGame.Models;

namespace EpamGame
{
    class Program
    {
        static void Main()
        {
            Board board = new Board(GameSettings.BoardLength);

            bool gameIsContinue = true;

            do
            {
                board.RenderBoard();
                MoveDirection direction = GetNextPlayerStepDirection();

                try
                {
                    gameIsContinue = board.MovePlayer(direction);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("You tried to go out of the board. You can't do it.");
                }

                if (!gameIsContinue)
                    Console.WriteLine("Game over");

                Console.WriteLine("To repeat the game, press any button");
            } 
            while (gameIsContinue);

            Console.ReadKey();
            
            do
            {
                Main();
            }
            while (!gameIsContinue);

            Console.ReadLine();
        }

        private static MoveDirection GetNextPlayerStepDirection()
        {
            Console.WriteLine("Use the arrows on the keyboard to move");

            Console.CursorVisible = false;
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                MoveDirection direction = MoveDirection.Top;
            }
            else if(keyInfo.Key == ConsoleKey.DownArrow)
            {
                MoveDirection direction = MoveDirection.Bottom;
            }
            else if(keyInfo.Key == ConsoleKey.LeftArrow)
            {
                MoveDirection direction = MoveDirection.Left;
            }
            else if(keyInfo.Key == ConsoleKey.RightArrow)
            {
                MoveDirection direction = MoveDirection.Right;
            }

            MoveDirection moveDirection = (MoveDirection)keyInfo.Key;

            return moveDirection;
        }
    }
}
