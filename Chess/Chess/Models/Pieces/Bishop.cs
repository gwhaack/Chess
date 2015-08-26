using Chess.Enums;

namespace Chess.Models.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Square square, PieceColor color)
            : base(square, color)
        {
            MovementDirection = MovementDirection.Bishop;
            CaptureDirection = MovementDirection;
        }
    }
}
