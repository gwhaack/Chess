using System;

namespace Chess.Enums
{
    [Flags]
    public enum MovementDirection
    {
        Forward = 1,
        Backward = 2,
        Knight = 3,
        Horizontal = 4,
        DiagonalForward = 8,
        DiagonalBackward = 16,

        Pawn = Forward,
        PawnCapture = DiagonalForward,
        Rook = Forward | Backward | Horizontal,
        Bishop = DiagonalForward | DiagonalBackward,
        King = Forward | Backward | Horizontal | DiagonalForward | DiagonalBackward,
        Queen = King,
    }
}
