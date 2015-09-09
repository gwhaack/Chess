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

        private readonly List<Piece> _pieces;
        public IReadOnlyCollection<Piece> Pieces
        {
            get { return _pieces.AsReadOnly(); }
        }

        #region Pieces

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

        private readonly Piece _rookA;
        public Piece RookA
        {
            get { return _rookA; }
        }

        private readonly Piece _rookH;
        public Piece RookH
        {
            get { return _rookH; }
        }

        private readonly Piece _knightB;
        public Piece KnightB
        {
            get { return _knightB; }
        }

        private readonly Piece _knightG;
        public Piece KnightG
        {
            get { return _knightG; }
        }

        private readonly Piece _bishopC;
        public Piece BishopC
        {
            get { return _bishopC; }
        }

        private readonly Piece _bishopF;
        public Piece BishopF
        {
            get { return _bishopF; }
        }

        private readonly Piece _pawnA;
        public Piece PawnA
        {
            get { return _pawnA; }
        }

        private readonly Piece _pawnB;
        public Piece PawnB
        {
            get { return _pawnB; }
        }

        private readonly Piece _pawnC;
        public Piece PawnC
        {
            get { return _pawnC; }
        }

        private readonly Piece _pawnD;
        public Piece PawnD
        {
            get { return _pawnD; }
        }

        private readonly Piece _pawnE;
        public Piece PawnE
        {
            get { return _pawnE; }
        }

        private readonly Piece _pawnF;
        public Piece PawnF
        {
            get { return _pawnF; }
        }

        private readonly Piece _pawnG;
        public Piece PawnG
        {
            get { return _pawnG; }
        }

        private readonly Piece _pawnH;
        public Piece PawnH
        {
            get { return _pawnH; }
        }

        #endregion

        public Set(PieceColor color)
        {
            _color = color;

            _king = new Piece(PieceType.King, color);
            _queen = new Piece(PieceType.Queen, color);
            _rookA = new Piece(PieceType.Rook, color);
            _rookH = new Piece(PieceType.Rook, color);
            _knightB = new Piece(PieceType.Knight, color);
            _knightG = new Piece(PieceType.Knight, color);
            _bishopC = new Piece(PieceType.Bishop, color);
            _bishopF = new Piece(PieceType.Bishop, color);
            _pawnA = new Piece(PieceType.Pawn, color);
            _pawnB = new Piece(PieceType.Pawn, color);
            _pawnC = new Piece(PieceType.Pawn, color);
            _pawnD = new Piece(PieceType.Pawn, color);
            _pawnE = new Piece(PieceType.Pawn, color);
            _pawnF = new Piece(PieceType.Pawn, color);
            _pawnG = new Piece(PieceType.Pawn, color);
            _pawnH = new Piece(PieceType.Pawn, color);

            _pieces = new List<Piece>
            {
                _king,
                _queen,
                _rookA,
                _rookH,
                _knightB,
                _knightG,
                _bishopC,
                _bishopF,
                _pawnA,
                _pawnB,
                _pawnC,
                _pawnD,
                _pawnE,
                _pawnF,
                _pawnG,
                _pawnH,
            };
        }
    }
}
