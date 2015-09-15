using Chess.Enums;

namespace Chess.Models
{
    /// <summary>
    /// A chess move.
    /// </summary>
    public class Move
    {
        /// <summary>
        /// Piece that moved.
        /// </summary>
        public Piece Piece { get; set; }

        /// <summary>
        /// Original square.
        /// </summary>
        public Square From { get; set; }

        /// <summary>
        /// Destination square.
        /// </summary>
        public Square To { get; set; }

        /// <summary>
        /// Piece captured on the move.
        /// </summary>
        public Piece Captured { get; set; }

        /// <summary>
        /// True if this move put the opposing king in check.
        /// </summary>
        public bool Check { get; set; }

        /// <summary>
        /// True if this move put the opposing king in checkmate.
        /// </summary>
        public bool Checkmate { get; set; }

        /// <summary>
        /// True if this was the moving piece's first move of the game.
        /// </summary>
        public bool FirstMove { get; set; }

        /// <summary>
        /// True if this move was a pawn en passant capture.
        /// </summary>
        public bool EnPassant { get; set; }

        /// <summary>
        /// Direction of the castle, null if the move was not a castle.
        /// </summary>
        public CastleDirection? CastleDirection { get; set; }

        /// <summary>
        /// Piece the pawn was promoted to, null if the move did not result in a pawn promotion.
        /// </summary>
        public PieceType? PromotedType { get; set; }
    }
}
