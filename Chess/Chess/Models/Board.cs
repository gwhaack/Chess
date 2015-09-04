using Chess.Enums;
using System;
namespace Chess.Models
{
    public class Board
    {
        private Square[,] _squares;

        public Board()
        {
            _squares = new Square[8, 8];
        }

        public Square this[Column column, int row]
        {
            get { return _squares[row - 1, (int) column - 1]; }
            set { _squares[row - 1, (int) column - 1] = value; }
        }
    }
}
