using Chess.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess.Models
{
    /// <summary>
    /// A chess board.
    /// </summary>
    public class Board
    {
        public const int Size = 8;
        private Square[,] _squares;

        /// <summary>
        /// All squares on the board.
        /// </summary>
        public IEnumerable<Square> Squares
        {
            get { return _squares.Cast<Square>(); }
        }

        /// <summary>
        /// Instantiate <see cref="Board"/>
        /// </summary>
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

        /// <summary>
        /// Retrieve a specific square.
        /// </summary>
        /// <param name="squareId"><see cref="Square.Id"/></param>
        /// <returns>The specified square.</returns>
        public Square this[string squareId]
        {
            get
            {
                // Parse input
                ValidateInput(squareId);
                var file = GetFileInput(squareId);
                int rank = GetRankInput(squareId);

                // Translate from chess coordinates to array coordinates
                return _squares[rank - 1, (int) file - 1];
            }
            private set
            {
                // Parse input
                ValidateInput(squareId);
                var file = GetFileInput(squareId);
                int rank = GetRankInput(squareId);

                // Translate from chess coordinates to array coordinates
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

        private static File GetFileInput(string squareId)
        {
            string fileInput = squareId.Substring(0, 1).ToLower();
            File file;
            if (!Enum.TryParse(fileInput, out file))
                throw new ArgumentOutOfRangeException("squareId", "File must be a letter between a and h, inclusive.");
            return file;
        }

        private static int GetRankInput(string squareId)
        {
            string rankInput = squareId.Substring(1, 1);
            int rank;
            if (!Int32.TryParse(rankInput, out rank) || rank < 1 || rank > Size)
                throw new ArgumentOutOfRangeException("squareId", "Rank must be a number between 1 and 8, inclusive.");
            return rank;
        }

        #endregion
    }
}
