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
            for (int file = 1; file <= Size; file++)
            {
                for (int rank = 1; rank <= Size; rank++)
                {
                    var fileEnum = (File) file;
                    this[Square.GetId(fileEnum, rank)] = new Square(fileEnum, rank);
                }
            }
        }

        #region Index

        public Square this[string squareId]
        {
            get
            {
                ValidateInput(squareId);
                var file = GetFileInput(squareId);
                int rank = GetRankInput(squareId);

                return _squares[rank - 1, (int) file - 1];
            }
            private set
            {
                ValidateInput(squareId);
                var file = GetFileInput(squareId);
                int rank = GetRankInput(squareId);

                _squares[rank - 1, (int) file - 1] = value;
            }
        }

        private static void ValidateInput(string squareId)
        {
            if (String.IsNullOrWhiteSpace(squareId))
                throw new ArgumentNullException("squareId");
            if (squareId.Length != 2)
                throw new ArgumentOutOfRangeException("squareId", "Square ID must be two characters.");
        }

        private static int GetRankInput(string squareId)
        {
            string rankInput = squareId.Substring(1, 1);
            int rank;
            if (!Int32.TryParse(rankInput, out rank) || rank < 1 || rank > Size)
                throw new ArgumentOutOfRangeException("squareId", "Rank must be a number between 1 and 8, inclusive.");
            return rank;
        }

        private static File GetFileInput(string squareId)
        {
            string fileInput = squareId.Substring(0, 1).ToLower();
            File file;
            if (!Enum.TryParse(fileInput, out file))
                throw new ArgumentOutOfRangeException("squareId", "File must be a letter between a and h, inclusive.");
            return file;
        }

        #endregion
    }
}
