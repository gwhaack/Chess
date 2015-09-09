using Chess.Enums;
using System;

namespace Chess.Models
{
    public class Square
    {
        public readonly Column Column;
        public readonly int Row;
        private readonly SquareColor _color;
        public SquareColor Color
        {
            get { return _color; }
        }
        public string Id
        {
            get
            {
                return GetId(Column, Row);
            }
        }
        public Piece Piece { get; set; }

        public Square(Column column, int row)
        {
            Column = column;
            Row = row;
            _color = (row + (int) column) % 2 == 0
                ? SquareColor.Dark
                : SquareColor.Light;
        }

        public static string GetId(Column column, int row)
        {
            return String.Format("{0}{1}", column, row);
        }
    }
}
