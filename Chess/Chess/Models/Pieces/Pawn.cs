using Chess.Enums;

namespace Chess.Models.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Square square, PieceColor color)
            : base(square, color)
        {
            MovementDirection = MovementDirection.Forward;
            CaptureDirection = MovementDirection.DiagonalForward;
        }
    }
}
