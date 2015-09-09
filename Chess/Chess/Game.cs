using Chess.Enums;
using Chess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Game
    {
        private Board Board;
        private Set BlackPieces;
        private Set WhitePieces;

        public void Start()
        {
            BlackPieces = new Set(PieceColor.Black);
            WhitePieces = new Set(PieceColor.White);
            Board = new Board();

            #region White Pieces

            var a1 = Board["a1"];
            a1.Piece = WhitePieces.RookA;
            WhitePieces.RookA.Square = a1;

            var b1 = Board["b1"];
            b1.Piece = WhitePieces.KnightB;
            WhitePieces.KnightB.Square = b1;

            var c1 = Board["c1"];
            c1.Piece = WhitePieces.BishopC;
            WhitePieces.BishopC.Square = c1;

            var d1 = Board["d1"];
            d1.Piece = WhitePieces.Queen;
            WhitePieces.Queen.Square = d1;

            var e1 = Board["e1"];
            e1.Piece = WhitePieces.King;
            WhitePieces.King.Square = e1;

            var f1 = Board["f1"];
            f1.Piece = WhitePieces.BishopF;
            WhitePieces.BishopF.Square = f1;

            var g1 = Board["g1"];
            g1.Piece = WhitePieces.KnightG;
            WhitePieces.KnightG.Square = g1;

            var h1 = Board["h1"];
            h1.Piece = WhitePieces.RookH;
            WhitePieces.RookH.Square = h1;

            var a2 = Board["a2"];
            a2.Piece = WhitePieces.PawnA;
            WhitePieces.PawnA.Square = a2;

            var b2 = Board["b2"];
            b2.Piece = WhitePieces.PawnB;
            WhitePieces.PawnB.Square = b2;

            var c2 = Board["c2"];
            c2.Piece = WhitePieces.PawnC;
            WhitePieces.PawnC.Square = c2;

            var d2 = Board["d2"];
            d2.Piece = WhitePieces.PawnD;
            WhitePieces.PawnD.Square = d2;

            var e2 = Board["e2"];
            e2.Piece = WhitePieces.PawnE;
            WhitePieces.PawnE.Square = e2;

            var f2 = Board["f2"];
            f2.Piece = WhitePieces.PawnF;
            WhitePieces.PawnF.Square = f2;

            var g2 = Board["g2"];
            g2.Piece = WhitePieces.PawnG;
            WhitePieces.PawnG.Square = g2;

            var h2 = Board["h2"];
            h2.Piece = WhitePieces.PawnH;
            WhitePieces.PawnH.Square = h2;

            #endregion

            #region Black Pieces

            var a8 = Board["a8"];
            a8.Piece = BlackPieces.RookA;
            BlackPieces.RookA.Square = a8;

            var b8 = Board["b8"];
            b8.Piece = BlackPieces.KnightB;
            BlackPieces.KnightB.Square = b8;

            var c8 = Board["c8"];
            c8.Piece = BlackPieces.BishopC;
            BlackPieces.BishopC.Square = c8;

            var d8 = Board["d8"];
            d8.Piece = BlackPieces.Queen;
            BlackPieces.Queen.Square = d8;

            var e8 = Board["e8"];
            e8.Piece = BlackPieces.King;
            BlackPieces.King.Square = e8;

            var f8 = Board["f8"];
            f8.Piece = BlackPieces.BishopF;
            BlackPieces.BishopF.Square = f8;

            var g8 = Board["g8"];
            g8.Piece = BlackPieces.KnightG;
            BlackPieces.KnightG.Square = g8;

            var h8 = Board["h8"];
            h8.Piece = BlackPieces.RookH;
            BlackPieces.RookH.Square = h8;

            var a7 = Board["a7"];
            a7.Piece = BlackPieces.PawnA;
            BlackPieces.PawnA.Square = a7;

            var b7 = Board["b7"];
            b7.Piece = BlackPieces.PawnB;
            BlackPieces.PawnB.Square = b7;

            var c7 = Board["c7"];
            c7.Piece = BlackPieces.PawnC;
            BlackPieces.PawnC.Square = c7;

            var d7 = Board["d7"];
            d7.Piece = BlackPieces.PawnD;
            BlackPieces.PawnD.Square = d7;

            var e7 = Board["e7"];
            e7.Piece = BlackPieces.PawnE;
            BlackPieces.PawnE.Square = e7;

            var f7 = Board["f7"];
            f7.Piece = BlackPieces.PawnF;
            BlackPieces.PawnF.Square = f7;

            var g7 = Board["g7"];
            g7.Piece = BlackPieces.PawnG;
            BlackPieces.PawnG.Square = g7;

            var h7 = Board["h7"];
            h7.Piece = BlackPieces.PawnH;
            BlackPieces.PawnH.Square = h7;

            #endregion
        }

        #region State

        public State State()
        {
            return new State
            {
                WhiteRookA = PieceState(WhitePieces.RookA),
                WhiteKnightB = PieceState(WhitePieces.KnightB),
                WhiteBishopC = PieceState(WhitePieces.BishopC),
                WhiteQueen = PieceState(WhitePieces.Queen),
                WhiteKing = PieceState(WhitePieces.King),
                WhiteBishopF = PieceState(WhitePieces.BishopF),
                WhiteKnightG = PieceState(WhitePieces.KnightG),
                WhiteRookH = PieceState(WhitePieces.RookH),

                WhitePawnA = PawnState(WhitePieces.PawnA),
                WhitePawnB = PawnState(WhitePieces.PawnB),
                WhitePawnC = PawnState(WhitePieces.PawnC),
                WhitePawnD = PawnState(WhitePieces.PawnD),
                WhitePawnE = PawnState(WhitePieces.PawnE),
                WhitePawnF = PawnState(WhitePieces.PawnF),
                WhitePawnG = PawnState(WhitePieces.PawnG),
                WhitePawnH = PawnState(WhitePieces.PawnH),

                BlackRookA = PieceState(BlackPieces.RookA),
                BlackKnightB = PieceState(BlackPieces.KnightB),
                BlackBishopC = PieceState(BlackPieces.BishopC),
                BlackQueen = PieceState(BlackPieces.Queen),
                BlackKing = PieceState(BlackPieces.King),
                BlackBishopF = PieceState(BlackPieces.BishopF),
                BlackKnightG = PieceState(BlackPieces.KnightG),
                BlackRookH = PieceState(BlackPieces.RookH),

                BlackPawnA = PawnState(BlackPieces.PawnA),
                BlackPawnB = PawnState(BlackPieces.PawnB),
                BlackPawnC = PawnState(BlackPieces.PawnC),
                BlackPawnD = PawnState(BlackPieces.PawnD),
                BlackPawnE = PawnState(BlackPieces.PawnE),
                BlackPawnF = PawnState(BlackPieces.PawnF),
                BlackPawnG = PawnState(BlackPieces.PawnG),
                BlackPawnH = PawnState(BlackPieces.PawnH),
            };
        }

        private static string PieceState(Piece piece)
        {
            if (piece.Captured || piece.Square == null)
                return String.Empty;
            return piece.Square.Id;
        }

        private static string PawnState(Piece pawn)
        {
            var square = PieceState(pawn);
            if (pawn.Type == PieceType.Pawn || String.IsNullOrEmpty(square))
                return square;
            return String.Format("{0}_{1}", square, pawn.Type);
        }

        #endregion

        public bool Move(Piece piece, Square newSquare)
        {
            if (!LegalMoves(piece).Contains(newSquare))
                return false;

            if (newSquare.Piece != null)
                newSquare.Piece.Captured = true;
            var oldSquare = piece.Square;
            piece.Square = newSquare;
            newSquare.Piece = piece;
            oldSquare.Piece = null;
            
            return true;
        }

        private static void PromotePawn(ref Piece pawn, PieceType newType)
        {
            if (pawn.Type != PieceType.Pawn)
                throw new ArgumentOutOfRangeException("pawn", "Promoting piece must be a pawn");
            pawn = new Piece(newType, pawn.Color);
        }

        public IList<Square> LegalMoves(Piece piece)
        {
            var currentSquare = piece.Square;
            switch (piece.Type)
            {
                case PieceType.Bishop:
                    return LegalBishopMoves(currentSquare, piece.Color);
                case PieceType.King:
                    return LegalKingMoves(currentSquare, piece.Color);
                case PieceType.Knight:
                    return LegalKnightMoves(currentSquare, piece.Color);
                case PieceType.Pawn:
                    return LegalPawnMoves(currentSquare, piece.Color);
                case PieceType.Queen:
                    return LegalQueenMoves(currentSquare, piece.Color);
                case PieceType.Rook:
                    return LegalRookMoves(currentSquare, piece.Color);
                default:
                    return new List<Square>();
            }
        }
        
        private IList<Square> LegalBishopMoves(Square currentSquare, PieceColor currentColor)
        {
            var legalMoves = new List<Square>();
            legalMoves.AddRange(NextLegalMoves(currentSquare, Direction.UpperLeft, currentColor));
            legalMoves.AddRange(NextLegalMoves(currentSquare, Direction.UpperRight, currentColor));
            legalMoves.AddRange(NextLegalMoves(currentSquare, Direction.LowerLeft, currentColor));
            legalMoves.AddRange(NextLegalMoves(currentSquare, Direction.LowerRight, currentColor));
            return legalMoves;
        }

        private IList<Square> LegalKingMoves(Square currentSquare, PieceColor currentColor)
        {
            var legalMoves = new List<Square>();
            foreach (Direction direction in Enum.GetValues(typeof (Direction)))
            {
                legalMoves.Add(NextLegalMove(currentSquare, direction, currentColor));
            }
            return legalMoves;
        }

        private IList<Square> LegalKnightMoves(Square currentSquare, PieceColor currentColor)
        {
            throw new NotImplementedException();
        }

        private IList<Square> LegalPawnMoves(Square currentSquare, PieceColor currentColor)
        {
            throw new NotImplementedException();
        }

        private IList<Square> LegalQueenMoves(Square currentSquare, PieceColor currentColor)
        {
            var legalMoves = new List<Square>();
            foreach (Direction direction in Enum.GetValues(typeof(Direction)))
            {
                legalMoves.AddRange(NextLegalMoves(currentSquare, direction, currentColor));
            }
            return legalMoves;
        }

        private IList<Square> LegalRookMoves(Square currentSquare, PieceColor currentColor)
        {
            var legalMoves = new List<Square>();
            legalMoves.AddRange(NextLegalMoves(currentSquare, Direction.Up, currentColor));
            legalMoves.AddRange(NextLegalMoves(currentSquare, Direction.Down, currentColor));
            legalMoves.AddRange(NextLegalMoves(currentSquare, Direction.Left, currentColor));
            legalMoves.AddRange(NextLegalMoves(currentSquare, Direction.Right, currentColor));
            return legalMoves;
        }
        private Square NextSquare(Square start, Direction direction)
        {
            int col = (int) start.Column;
            int row = start.Row;
            switch (direction)
            {
                case Direction.Up:
                    row += 1;
                    break;
                case Direction.Down:
                    row -= 1;
                    break;
                case Direction.Left:
                    col -= 1;
                    break;
                case Direction.Right:
                    col += 1;
                    break;
                case Direction.UpperLeft:
                    row += 1;
                    col -= 1;
                    break;
                case Direction.UpperRight:
                    row += 1;
                    col += 1;
                    break;
                case Direction.LowerLeft:
                    row -= 1;
                    col -= 1;
                    break;
                case Direction.LowerRight:
                    row -= 1;
                    col += 1;
                    break;
                default:
                    return null;
            }
            if (row > Board.Size || row < 0 || col > Board.Size || col < 0)
                return null;
            var column = (Column) col;
            return Board[Square.GetId(column, row)];
        }

        private Square NextLegalMove(Square currentSquare, Direction direction, PieceColor currentColor)
        {
            var next = NextSquare(currentSquare, direction);
            if (next == null) return null;
            if (next.Piece == null || next.Piece.Color != currentColor)
                return next;
            return null;
        }

        private IList<Square> NextLegalMoves(Square currentSquare, Direction direction, PieceColor currentColor)
        {
            var nextLegalMoves = new List<Square>();
            var current = currentSquare;
            while (true)
            {
                var next = NextLegalMove(currentSquare, direction, currentColor);
                if (next == null) break;
                if (next.Piece == null || next.Piece.Color != currentColor)
                {
                    nextLegalMoves.Add(next);
                    current = next;
                }
                else break;
            }
            return nextLegalMoves;
        }
    }
}
