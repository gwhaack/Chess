namespace Chess.Models
{
    public class Move
    {
        public Piece Piece { get; set; }
        public Square From { get; set; }
        public Square To { get; set; }
        public Piece Captured { get; set; }
    }
}
