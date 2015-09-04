using Chess.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Chess.Models
{
    public class Set
    {
        private readonly PieceColor _color;
        public PieceColor Color
        {
            get { return _color; }
        }
        private readonly IEnumerable<Piece> _pieces;
        public IEnumerable<Piece> Pieces
        {
            get { return _pieces; }
        }

        private readonly Piece _king;
        public Piece King
        {
            get { return _king; }
        }

        private readonly Piece _queen;
        public Piece Queen
        {
            get { return _queen; }
        }

        private readonly IEnumerable<Piece> _bishops;
        public IEnumerable<Piece> Bishops
        {
            get { return _bishops; }
        }

        private readonly IEnumerable<Piece> _knights;
        public IEnumerable<Piece> Knights
        {
            get { return _knights; }
        }

        private readonly IEnumerable<Piece> _rooks;
        public IEnumerable<Piece> Rooks
        {
            get { return _rooks; }
        }

        private readonly IEnumerable<Piece> _pawns;
        public IEnumerable<Piece> Pawns
        {
            get { return _pawns; }
        }

        public Set(PieceColor color)
        {
            _color = color;
            _king = new Piece(PieceType.King, color);
            _queen = new Piece(PieceType.Queen, color);
            _bishops = Piece.Generate(PieceType.Bishop, color, 2);
            _knights = Piece.Generate(PieceType.Knight, color, 2);
            _rooks = Piece.Generate(PieceType.Rook, color, 2);
            _pawns = Piece.Generate(PieceType.Pawn, color, 8);
            var pieces = new List<Piece>
            {
                _king,
                _queen,
            };
            pieces.AddRange(_bishops);
            pieces.AddRange(_knights);
            pieces.AddRange(_rooks);
            pieces.AddRange(_pawns);
            _pieces = pieces;
        }

        public IEnumerable<Piece> CapturedPieces
        {
            get { return _pieces.Where(p => p.Captured); }
        }
    }
}
