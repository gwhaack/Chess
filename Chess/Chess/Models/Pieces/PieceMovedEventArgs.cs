using System;

namespace Chess.Models.Pieces
{
    public class PieceMovedEventArgs : EventArgs
    {
        public Square OldSquare { get; set; }
        public Square NewSquare { get; set; }
    }
}
