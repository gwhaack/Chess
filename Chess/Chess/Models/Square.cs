using Chess.Enums;
using Chess.Models.Pieces;
using System;

namespace Chess.Models
{
    public class Square
    {
        public const string Columns = "abcdefgh";

        public readonly int Row;
        public readonly int Column;
        public SquareColor Color
        {
            get
            {
                return (Row + Column) % 2 == 0
                    ? SquareColor.Dark
                    : SquareColor.Light;
            }
        }
        public string Name
        {
            get
            {
                return String.Format("{0}{1}", Columns[Column], Row);
            }
        }
        public Piece Piece { get; set; }

        public Square(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
