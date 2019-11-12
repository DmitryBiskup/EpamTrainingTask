using EpamGame.Structs;

namespace EpamGame.Models
{
    public abstract class BoardElement
    {
        public Coordinates ElementCoordinates { get; protected set; }
        protected abstract string BoardSymbol { get; }

        protected BoardElement(Coordinates coordinates)
        {
            ElementCoordinates = coordinates;
        }

        public string RenderElement()
        {
            return BoardSymbol;
        }
    }
}
