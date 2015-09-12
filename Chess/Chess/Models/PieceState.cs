using Chess.Enums;
using System;

namespace Chess.Models
{
    public class PieceState
    {
        public PieceType PieceType{ get; set; }
        public string SquareId { get; set; }

        public PieceState() { }

        public PieceState(Piece piece)
        {
            PieceType = piece.Type;
            SquareId = !piece.Captured
                ? piece.Square.Id
                : String.Empty;
        }
    }
}
