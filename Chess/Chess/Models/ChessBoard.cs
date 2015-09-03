using System;
namespace Chess.Models
{
    public class ChessBoard
    {
        public Square[,] Squares { get; set; }

        public ChessBoard()
        {
            Squares = new Square[8, 8];
        }

        public Square this[int row, int column]
        {
            get { return Squares[row, column]; }
            set { Squares[row, column] = value; }
        }
    }
}
