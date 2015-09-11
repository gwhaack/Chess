using Chess.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess.Models
{
    public class Board
    {
        public const int Size = 8;
        private Square[,] _squares;
        public IEnumerable<Square> Squares
        {
            get { return _squares.Cast<Square>(); }
        }

        public Board()
        {
            _squares = new Square[Size, Size];
            for (int col = 1; col <= Size; col++)
            {
                for (int row = 1; row <= Size; row++)
                {
                    var column = (Column) col;
                    this[Square.GetId(column, row)] = new Square(column, row);
                }
            }
        }

        #region Index

        public Square this[string squareId]
        {
            get
            {
                ValidateInput(squareId);
                var column = GetColumnInput(squareId);
                int row = GetRowInput(squareId);

                return _squares[row - 1, (int) column - 1];
            }
            private set
            {
                ValidateInput(squareId);
                var column = GetColumnInput(squareId);
                int row = GetRowInput(squareId);

                _squares[row - 1, (int) column - 1] = value;
            }
        }

        private static void ValidateInput(string squareId)
        {
            if (String.IsNullOrWhiteSpace(squareId))
                throw new ArgumentNullException("squareId");
            if (squareId.Length != 2)
                throw new ArgumentOutOfRangeException("squareId", "Square ID must be two characters.");
        }

        private static int GetRowInput(string squareId)
        {
            string rowInput = squareId.Substring(1, 1);
            int row;
            if (!Int32.TryParse(rowInput, out row) || row < 1 || row > Size)
                throw new ArgumentOutOfRangeException("squareId", "Row must be a number between 1 and 8, inclusive.");
            return row;
        }

        private static Column GetColumnInput(string squareId)
        {
            string columnInput = squareId.Substring(0, 1).ToLower();
            Column column;
            if (!Enum.TryParse(columnInput, out column))
                throw new ArgumentOutOfRangeException("squareId", "Column must be a letter between a and h, inclusive.");
            return column;
        }

        #endregion
    }
}
