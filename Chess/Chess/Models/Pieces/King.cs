using Chess.Enums;

namespace Chess.Models.Pieces
{
    public class King : Piece
    {
        public King(Square square, PieceColor color)
            : base(square, color)
        {
            MovementDirection = MovementDirection.King;
            CaptureDirection = MovementDirection;
        }
    }
}
