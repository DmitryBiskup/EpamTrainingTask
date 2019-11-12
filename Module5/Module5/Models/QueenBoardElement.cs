using System;
using EpamGame.Constants;
using EpamGame.Structs;

namespace EpamGame.Models
{
    public class QueenBoardElement : BoardElement
    {
        protected override string BoardSymbol { get; } = ElementSymbols.QueenSymbol;

        public QueenBoardElement(Coordinates coordinates) : base(coordinates)
        {

        }

        public void SayThanksToPrince()
        {
            var rand = new Random();
            string line = $"Thank you, you saved me!";

            while (!Console.KeyAvailable)
            {
                foreach (char letter in line)
                {
                    Console.ForegroundColor = (ConsoleColor)rand.Next(16);
                    Console.Write(letter);
                }
                Console.Write('\r');
            }
        }
    }
}
