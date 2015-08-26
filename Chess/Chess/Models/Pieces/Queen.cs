using Chess.Enums;

namespace Chess.Models.Pieces
{
    public class Queen : Piece
    {
        public Queen(Square square, PieceColor color)
            : base(square, color)
        {
            MovementDirection = MovementDirection.Queen;
            CaptureDirection = MovementDirection;
        }
    }
}
