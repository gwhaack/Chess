using Chess.Enums;

namespace Chess.Models.Pieces
{
    public class Knight : Piece
    {
        public Knight(Square square, PieceColor color)
            : base(square, color)
        {
            MovementDirection = MovementDirection.Knight;
            CaptureDirection = MovementDirection;
        }
    }
}
