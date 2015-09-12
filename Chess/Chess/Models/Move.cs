using Chess.Enums;

namespace Chess.Models
{
    public class Move
    {
        public Piece Piece { get; set; }
        public Square From { get; set; }
        public Square To { get; set; }
        public Piece Captured { get; set; }
        public bool FirstMove { get; set; }
        public bool Castle { get; set; }
        public PieceType PromotedType { get; set; }
    }
}
