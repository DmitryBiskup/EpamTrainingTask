using System;
using EpamGame.Enums;

namespace EpamGame.Structs
{
    public struct Coordinates : IEquatable<Coordinates>
    {
        public readonly int X;
        public readonly int Y;

        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Coordinates GetStepByMoveDirection(MoveDirection direction)
        {
            Coordinates stepCoordinates = default;

            switch (direction)
            {
                case MoveDirection.Top: stepCoordinates = new Coordinates(-1, 0); break;
                case MoveDirection.Right: stepCoordinates = new Coordinates(0, 1); break;
                case MoveDirection.Bottom: stepCoordinates = new Coordinates(1, 0); break;
                case MoveDirection.Left: stepCoordinates = new Coordinates(0, -1); break;
            }

            return stepCoordinates;
        }

        public static Coordinates CreateRandomCoordinates()
        {
            var rand = new Random();

            int x = rand.Next(1, GameSettings.BoardLength);
            int y = rand.Next(1, GameSettings.BoardLength);

            return new Coordinates(x, y);
        }

        public bool Equals(Coordinates other)
        {
            return X == other.X && Y == other.Y;
        }

        public static bool operator ==(Coordinates coordinates, Coordinates coordinates2)
        {
            return coordinates.Equals(coordinates2);
        }

        public static bool operator !=(Coordinates coordinates, Coordinates coordinates2)
        {
            return !coordinates.Equals(coordinates2);
        }

        public static Coordinates operator +(Coordinates coordinates, Coordinates coordinates2)
        {
            int newX = coordinates.X + coordinates2.X;
            int newY = coordinates.Y + coordinates2.Y;

            return new Coordinates(newX, newY);
        }

        public override bool Equals(object obj)
        {
            return obj is Coordinates other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }
    }
}
