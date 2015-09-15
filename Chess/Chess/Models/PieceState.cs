using Chess.Enums;
using System;

namespace Chess.Models
{
    /// <summary>
    /// Snapshot of a piece.
    /// </summary>
    public class PieceState
    {
        /// <summary>
        /// <see cref="PieceType"/>
        /// </summary>
        public PieceType PieceType{ get; set; }

        /// <summary>
        /// <see cref="Square.Id"/>
        /// </summary>
        public string SquareId { get; set; }

        /// <summary>
        /// Allow empty constructor.
        /// </summary>
        public PieceState() { }

        /// <summary>
        /// Generate PieceState from a Piece.
        /// </summary>
        /// <param name="piece"><see cref="Piece"/></param>
        public PieceState(Piece piece)
        {
            PieceType = piece.Type;
            SquareId = !piece.Captured
                ? piece.Square.Id
                : String.Empty;
        }
    }
}
