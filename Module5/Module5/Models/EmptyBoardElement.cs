using EpamGame.Constants;
using EpamGame.Structs;

namespace EpamGame.Models
{
    public class EmptyBoardElement : BoardElement
    {
        protected override string BoardSymbol { get; } = ElementSymbols.EmptySymbol;

        public EmptyBoardElement(Coordinates coordinates) : base(coordinates)
        {

        }
    }
}
