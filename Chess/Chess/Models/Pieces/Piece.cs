using Chess.Enums;
using Chess.Exceptions;
using Chess.Models;
using System;
using System.Collections.Generic;

namespace Chess.Models.Pieces
{
    public abstract class Piece
    {
        PieceColor Color { get; set; }
        Square Square { get; set; }
        public bool Captured { get; set; }
        public MovementDirection MovementDirection { get; set; }
        public MovementDistance MovementDistance { get; set; }
        public MovementDirection CaptureDirection { get; set; }
        public virtual void Move(Square newSquare)
        {
            var oldSquare = Square;
            Square = newSquare;
            if (Moved != null)
            {
                var pieceMovedEventArgs = new PieceMovedEventArgs
                {
                    OldSquare = oldSquare,
                    NewSquare = newSquare,
                };
                Moved(this, pieceMovedEventArgs);
            }
        }

        protected Piece(Square square, PieceColor color)
        {
            Square = square;
            Color = color;
        }

        public delegate void MovedEventHandler(Piece sender, PieceMovedEventArgs e);
        public event MovedEventHandler Moved;
    }
}
