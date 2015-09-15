using Chess.Enums;
using System.Collections.Generic;

namespace Chess.Models
{
    /// <summary>
    /// A chess piece. 
    /// </summary>
    public class Piece
    {
        /// <summary>
        /// <see cref="PieceType"/>
        /// </summary>
        public PieceType Type
        {
            get { return _type; }
        }
        private readonly PieceType _type;

        /// <summary>
        /// <see cref="PieceColor"/>
        /// </summary>
        public PieceColor Color
        {
            get { return _color; }
        }
        private readonly PieceColor _color;

        /// <summary>
        /// Current square.
        /// </summary>
        public Square Square { get; set; }

        /// <summary>
        /// All legal moves for this piece.
        /// </summary>
        public IList<Move> Moves { get; set; }

        /// <summary>
        /// All squares attacked by this piece.
        /// </summary>
        public IList<Square> Attacked { get; set; }

        /// <summary>
        /// True if this piece has moved at all.
        /// </summary>
        public bool Moved { get; set; }

        /// <summary>
        /// True if this piece has been captured.
        /// </summary>
        public bool Captured
        {
            get { return Square == null; }
        }

        /// <summary>
        /// Instantiate <see cref="Piece"/>
        /// </summary>
        /// <param name="type"><see cref="Type"/></param>
        /// <param name="color"><see cref="Color"/></param>
        public Piece(PieceType type, PieceColor color)
        {
            _type = type;
            _color = color;

            Moves = new List<Move>();
            Attacked = new List<Square>();
        }
    }
}
