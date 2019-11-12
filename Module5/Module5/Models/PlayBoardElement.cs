using EpamGame.Constants;
using EpamGame.Structs;

namespace EpamGame.Models
{
    public class PlayerBoardElement : BoardElement
    {
        protected override string BoardSymbol { get; } = ElementSymbols.PlayerSymbol;
        public int PlayerHealth { get; private set; } = GameSettings.PlayerHealth;

        public PlayerBoardElement(Coordinates coordinates) : base(coordinates)
        {

        }

        public bool PlayerTakeDamage(int amountOfDamage)
        {
            PlayerHealth -= amountOfDamage;

            return PlayerHealth > 0;
        }

        public void Move(Coordinates newPlayerCoordinates)
        {
            ElementCoordinates = newPlayerCoordinates;
        }
    }
}
