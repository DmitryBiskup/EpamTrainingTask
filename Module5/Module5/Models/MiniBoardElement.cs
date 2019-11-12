using System;
using EpamGame.Constants;
using EpamGame.Structs;

namespace EpamGame.Models
{
    public class MineBoardElement : BoardElement
    {
        protected override string BoardSymbol { get; } = ElementSymbols.EmptySymbol;

        public MineBoardElement(Coordinates coordinates) : base(coordinates)
        {

        }

        public int GetExplosionDamage()
        {
            Console.WriteLine("You stepped on a mine and it explodes");

            return GenerateDamage();
        }

        private static int GenerateDamage()
        {
            return new Random().Next(1, 11);
        }
    };
}
