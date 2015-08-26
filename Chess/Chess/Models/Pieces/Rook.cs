using Chess.Enums;

namespace Chess.Models.Pieces
{
    public class Rook : Piece
    {
        public Rook(Square square, PieceColor color)
            : base(square, color)
        {
            MovementDirection = MovementDirection.Rook;
            CaptureDirection = MovementDirection;
        }
    }
}
