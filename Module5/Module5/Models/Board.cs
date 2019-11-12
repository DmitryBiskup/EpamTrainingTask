using System;
using System.Linq;
using System.Text;
using EpamGame.Enums;
using EpamGame.Structs;

namespace EpamGame.Models
{
    public class Board
    {
        private readonly MineBoardElement[] _mines = new MineBoardElement[GameSettings.CountOfMines];
        private readonly BoardElement[,] _boardElements;
        private readonly PlayerBoardElement _player;
        private readonly int _boardLength;

        public Board(int boardLength)
        {
            _boardLength = boardLength;
            _boardElements = new BoardElement[_boardLength, _boardLength];
            _player = new PlayerBoardElement(new Coordinates(0, 0));

            SeedPlayerOnTheBoard();
            SeedQueenOnTheBoard();
            GenerateMineCoordinates();
            SeedGameElementsOnTheBoard();
        }

        public bool MovePlayer(MoveDirection direction)
        {
            var gameIsContinue = true;

            Coordinates currentPlayerCoordinates = _player.ElementCoordinates;
            Coordinates newPlayerCoordinates = currentPlayerCoordinates + Coordinates.GetStepByMoveDirection(direction);

            BoardElement targetBoardElement = _boardElements[newPlayerCoordinates.X, newPlayerCoordinates.Y];

            switch (targetBoardElement)
            {
                case MineBoardElement mine:
                    {
                        int damageToPlayer = mine.GetExplosionDamage();
                        gameIsContinue = _player.PlayerTakeDamage(damageToPlayer);
                        Console.WriteLine($"Mina explodes and damages you {damageToPlayer}");

                        if (!gameIsContinue)
                            Console.WriteLine("You died");

                        break;
                    }

                case QueenBoardElement queen:
                    {
                        queen.SayThanksToPrince();
                        gameIsContinue = false;

                        break;
                    }
            }

            _player.Move(newPlayerCoordinates);

            _boardElements[currentPlayerCoordinates.X, currentPlayerCoordinates.Y] = new EmptyBoardElement(currentPlayerCoordinates);
            _boardElements[newPlayerCoordinates.X, newPlayerCoordinates.Y] = _player;

            return gameIsContinue;
        }

        public void RenderBoard()
        {
            Console.Clear();

            var builder = new StringBuilder();

            for (int i = 0; i < _boardLength; i++)
            {
                builder.Append($"{Environment.NewLine}");

                for (int j = 0; j < _boardLength; j++)
                {
                    string boardElementSymbol = _boardElements[i, j].RenderElement();
                    builder.Append($"{boardElementSymbol} ");
                }
            }

            string renderedBoard = builder.ToString();
            Console.WriteLine(renderedBoard);
        }

        private void SeedPlayerOnTheBoard()
        {
            _boardElements[_player.ElementCoordinates.X, _player.ElementCoordinates.Y] = _player;
        }

        private void SeedQueenOnTheBoard()
        {
            var queenStartCoordinates = new Coordinates(_boardLength - 1, _boardLength - 1);
            _boardElements[queenStartCoordinates.X, queenStartCoordinates.Y] = new QueenBoardElement(queenStartCoordinates);
        }

        private void SeedGameElementsOnTheBoard()
        {
            for (int x = 0; x < _boardLength; x++)
            {
                for (int y = 0; y < _boardLength; y++)
                {
                    if (_boardElements[x, y] != null)
                        continue;

                    var currentCoordinates = new Coordinates(x, y);

                    MineBoardElement mine = _mines.FirstOrDefault(currentMine => currentMine.ElementCoordinates == currentCoordinates);

                    _boardElements[x, y] = mine == null ? new EmptyBoardElement(currentCoordinates) : (BoardElement)mine;
                }
            }
        }

        private void GenerateMineCoordinates()
        {
            for (int i = 0; i < _mines.Length; i++)
            {
                Coordinates coordinates;

                do
                {
                    coordinates = Coordinates.CreateRandomCoordinates();
                }
                while (!ValidateMineCoordinates(coordinates));

                _mines[i] = new MineBoardElement(coordinates);
            }
        }

        private bool ValidateMineCoordinates(Coordinates targetCoordinates)
        {
            return ValidateMineCoordinatesIsUnique(targetCoordinates) && ValidateAvailableCoordinates(targetCoordinates);
        }

        private bool ValidateAvailableCoordinates(Coordinates targetCoordinates)
        {
            BoardElement boardElement = _boardElements[targetCoordinates.X, targetCoordinates.Y];
            return boardElement == null;
        }

        private bool ValidateMineCoordinatesIsUnique(Coordinates coordinates)
        {
            var existedMines = _mines.Where(mine => mine != null);
            return existedMines.All(x => x.ElementCoordinates != coordinates);
        }
    }
}
