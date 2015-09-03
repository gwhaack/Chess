using Chess.Enums;
using System;

namespace Chess.Models
{
    public class Square
    {
        public const string Columns = "abcdefgh";

        public readonly int Row;
        public readonly int Column;
        private readonly SquareColor _color;
        public SquareColor Color
        {
            get { return _color; }
        }
        public string Id
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
            _color = (row + column) % 2 == 0
                    ? SquareColor.Dark
                    : SquareColor.Light;
        }
    }
}
