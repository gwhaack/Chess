using Chess.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Chess.Models
{
    /// <summary>
    /// A complete set of chess pieces.
    /// </summary>
    public class Set
    {
        /// <summary>
        /// <see cref="PieceColor"/>
        /// </summary>
        public PieceColor Color
        {
            get { return _color; }
        }
        private readonly PieceColor _color;

        /// <summary>
        /// All pieces in the set.
        /// </summary>
        public IEnumerable<Piece> Pieces
        {
            get { return _pieces.AsReadOnly(); }
        }
        private readonly List<Piece> _pieces;

        #region Pieces

        /// <summary>
        /// The king.
        /// </summary>
        public Piece King
        {
            get { return _king; }
        }
        private readonly Piece _king;

        /// <summary>
        /// The queen.
        /// </summary>
        public Piece Queen
        {
            get { return _queen; }
        }
        private readonly Piece _queen;

        /// <summary>
        /// The rook that began on the A file.
        /// </summary>
        public Piece RookA
        {
            get { return _rookA; }
        }
        private readonly Piece _rookA;
        
        /// <summary>
        /// The rook that began on the H file.
        /// </summary>
        public Piece RookH
        {
            get { return _rookH; }
        }
        private readonly Piece _rookH;

        /// <summary>
        /// The knight that began on the B file.
        /// </summary>
        public Piece KnightB
        {
            get { return _knightB; }
        }
        private readonly Piece _knightB;
        
        /// <summary>
        /// The knight that began on the G file.
        /// </summary>
        public Piece KnightG
        {
            get { return _knightG; }
        }
        private readonly Piece _knightG;
        
        /// <summary>
        /// The bishop that began on the C file.
        /// </summary>
        public Piece BishopC
        {
            get { return _bishopC; }
        }
        private readonly Piece _bishopC;

        /// <summary>
        /// The bishop that began on the F file.
        /// </summary>
        public Piece BishopF
        {
            get { return _bishopF; }
        }
        private readonly Piece _bishopF;

        /// <summary>
        /// The pawn that began on the A file.
        /// </summary>
        public Piece PawnA
        {
            get { return _pawnA; }
        }
        private readonly Piece _pawnA;

        /// <summary>
        /// The pawn that began on the B file.
        /// </summary>
        public Piece PawnB
        {
            get { return _pawnB; }
        }
        private readonly Piece _pawnB;

        /// <summary>
        /// The pawn that began on the C file.
        /// </summary>
        public Piece PawnC
        {
            get { return _pawnC; }
        }
        private readonly Piece _pawnC;
        
        /// <summary>
        /// The pawn that began on the D file.
        /// </summary>
        public Piece PawnD
        {
            get { return _pawnD; }
        }
        private readonly Piece _pawnD;

        /// <summary>
        /// The pawn that began on the E file.
        /// </summary>
        public Piece PawnE
        {
            get { return _pawnE; }
        }
        private readonly Piece _pawnE;

        /// <summary>
        /// The pawn that began on the F file.
        /// </summary>
        public Piece PawnF
        {
            get { return _pawnF; }
        }
        private readonly Piece _pawnF;
        
        /// <summary>
        /// The pawn that began on the G file.
        /// </summary>
        public Piece PawnG
        {
            get { return _pawnG; }
        }
        private readonly Piece _pawnG;

        /// <summary>
        /// The pawn that began on the H file.
        /// </summary>
        public Piece PawnH
        {
            get { return _pawnH; }
        }
        private readonly Piece _pawnH;

        #endregion

        /// <summary>
        /// Instantiate <see cref="Set"/>
        /// </summary>
        /// <param name="color"><see cref="Color"/></param>
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
