using Chess.Enums;
using Chess.Models;
using System;
using System.Collections.Generic;

namespace Chess
{
    public class Game
    {
        private Board Board;
        private Set BlackPieces;
        private Set WhitePieces;
        private Stack<Move> Moves;
        private Stack<Move> UndoneMoves;

        public void Start()
        {
            Board = new Board();
            BlackPieces = new Set(PieceColor.Black);
            WhitePieces = new Set(PieceColor.White);

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

        public void StartFromPosition(GameState gameState)
        {
            Board = new Board();
            BlackPieces = new Set(PieceColor.Black);
            WhitePieces = new Set(PieceColor.White);

            // TODO - do something with gameState
        }

        #region State

        public bool ValidState()
        {
            foreach (var piece in WhitePieces.Pieces)
            {
                if (piece.Square == null && !piece.Captured)
                    return false;
                if (piece.Square.Piece != piece)
                    return false;
            }

            foreach (var piece in BlackPieces.Pieces)
            {
                if (piece.Square == null && !piece.Captured)
                    return false;
                if (piece.Square.Piece != piece)
                    return false;
            }

            return true;
        }

        public GameState State()
        {
            return new GameState
            {
                WhiteRookA = new PieceState(WhitePieces.RookA),
                WhiteKnightB = new PieceState(WhitePieces.KnightB),
                WhiteBishopC = new PieceState(WhitePieces.BishopC),
                WhiteQueen = new PieceState(WhitePieces.Queen),
                WhiteKing = new PieceState(WhitePieces.King),
                WhiteBishopF = new PieceState(WhitePieces.BishopF),
                WhiteKnightG = new PieceState(WhitePieces.KnightG),
                WhiteRookH = new PieceState(WhitePieces.RookH),

                WhitePawnA = new PieceState(WhitePieces.PawnA),
                WhitePawnB = new PieceState(WhitePieces.PawnB),
                WhitePawnC = new PieceState(WhitePieces.PawnC),
                WhitePawnD = new PieceState(WhitePieces.PawnD),
                WhitePawnE = new PieceState(WhitePieces.PawnE),
                WhitePawnF = new PieceState(WhitePieces.PawnF),
                WhitePawnG = new PieceState(WhitePieces.PawnG),
                WhitePawnH = new PieceState(WhitePieces.PawnH),

                BlackRookA = new PieceState(BlackPieces.RookA),
                BlackKnightB = new PieceState(BlackPieces.KnightB),
                BlackBishopC = new PieceState(BlackPieces.BishopC),
                BlackQueen = new PieceState(BlackPieces.Queen),
                BlackKing = new PieceState(BlackPieces.King),
                BlackBishopF = new PieceState(BlackPieces.BishopF),
                BlackKnightG = new PieceState(BlackPieces.KnightG),
                BlackRookH = new PieceState(BlackPieces.RookH),

                BlackPawnA = new PieceState(BlackPieces.PawnA),
                BlackPawnB = new PieceState(BlackPieces.PawnB),
                BlackPawnC = new PieceState(BlackPieces.PawnC),
                BlackPawnD = new PieceState(BlackPieces.PawnD),
                BlackPawnE = new PieceState(BlackPieces.PawnE),
                BlackPawnF = new PieceState(BlackPieces.PawnF),
                BlackPawnG = new PieceState(BlackPieces.PawnG),
                BlackPawnH = new PieceState(BlackPieces.PawnH),
            };
        }

        #endregion

        public bool Move(Piece piece, Square to)
        {
            if (piece.LegalMoves.Contains(to))
                return false;

            var captured = to.Piece;
            if (captured != null)
            {
                captured.Square = null;
            }

            var from = piece.Square;
            piece.Square = to;
            to.Piece = piece;
            from.Piece = null;

            var move = new Move
            {
                Captured = captured,
                From = from,
                To = to,
                Piece = piece,
            };
            Moves.Push(move);
            
            return true;
        }

        public bool UndoLastMove()
        {
            var move = Moves.Pop();
            if (move == null) return false;

            move.From.Piece = move.Piece;
            move.To.Piece = move.Captured;
            move.Piece.Square = move.From;

            if (move.Captured != null)
            {
                move.Captured.Square = move.To;
            }

            UndoneMoves.Push(move);
            return true;
        }

        public bool RedoMove()
        {
            var move = UndoneMoves.Pop();
            if (move == null) return false;

            if (move.Captured != null)
            {
                move.Captured.Square = null;
            }

            move.Piece.Square = move.To;
            move.To.Piece = move.Piece;
            move.From.Piece = null;

            return true;
        }

        private static void PromotePawn(ref Piece pawn, PieceType newType)
        {
            if (pawn.Type != PieceType.Pawn)
                throw new ArgumentOutOfRangeException("pawn", "Promoting piece must be a pawn");
            pawn = new Piece(newType, pawn.Color);
        }

        public void LegalMoves(ref Piece piece)
        {
            var from = piece.Square;
            switch (piece.Type)
            {
                case PieceType.Bishop:
                    piece.LegalMoves = LegalBishopMoves(from, piece.Color);
                    piece.SquaresAttacked = piece.LegalMoves;
                    break;
                case PieceType.King:
                    piece.LegalMoves = LegalKingMoves(from, piece.Color);
                    piece.SquaresAttacked = piece.LegalMoves;
                    break;
                case PieceType.Knight:
                    piece.LegalMoves = LegalKnightMoves(from, piece.Color);
                    piece.SquaresAttacked = piece.LegalMoves;
                    break;
                case PieceType.Pawn:
                    piece.LegalMoves = LegalPawnMoves(from, piece.Color);
                    piece.SquaresAttacked = LegalPawnCaptures(from, piece.Color);
                    break;
                case PieceType.Queen:
                    piece.LegalMoves = LegalQueenMoves(from, piece.Color);
                    piece.SquaresAttacked = piece.LegalMoves;
                    break;
                case PieceType.Rook:
                    piece.LegalMoves = LegalRookMoves(from, piece.Color);
                    piece.SquaresAttacked = piece.LegalMoves;
                    break;
            }
        }
        
        private IList<Square> LegalBishopMoves(Square from, PieceColor currentColor)
        {
            var legalMoves = new List<Square>();
            legalMoves.AddRange(NextLegalMoves(from, Direction.UpperLeft, currentColor));
            legalMoves.AddRange(NextLegalMoves(from, Direction.UpperRight, currentColor));
            legalMoves.AddRange(NextLegalMoves(from, Direction.LowerLeft, currentColor));
            legalMoves.AddRange(NextLegalMoves(from, Direction.LowerRight, currentColor));
            return legalMoves;
        }

        private IList<Square> LegalKingMoves(Square from, PieceColor currentColor)
        {
            var legalMoves = new List<Square>();
            foreach (Direction direction in Enum.GetValues(typeof (Direction)))
            {
                legalMoves.Add(NextLegalMove(from, direction, currentColor));
            }
            return legalMoves;
        }

        private IList<Square> LegalKnightMoves(Square from, PieceColor currentColor)
        {
            throw new NotImplementedException();
        }

        private IList<Square> LegalPawnMoves(Square from, PieceColor currentColor)
        {
            throw new NotImplementedException();
        }

        private IList<Square> LegalPawnCaptures(Square from, PieceColor currentColor)
        {
            throw new NotImplementedException();
        }

        private IList<Square> LegalQueenMoves(Square from, PieceColor currentColor)
        {
            var legalMoves = new List<Square>();
            foreach (Direction direction in Enum.GetValues(typeof(Direction)))
            {
                legalMoves.AddRange(NextLegalMoves(from, direction, currentColor));
            }
            return legalMoves;
        }

        private IList<Square> LegalRookMoves(Square from, PieceColor currentColor)
        {
            var legalMoves = new List<Square>();
            legalMoves.AddRange(NextLegalMoves(from, Direction.Up, currentColor));
            legalMoves.AddRange(NextLegalMoves(from, Direction.Down, currentColor));
            legalMoves.AddRange(NextLegalMoves(from, Direction.Left, currentColor));
            legalMoves.AddRange(NextLegalMoves(from, Direction.Right, currentColor));
            return legalMoves;
        }
        private Square NextSquare(Square from, Direction direction)
        {
            int col = (int) from.Column;
            int row = from.Row;
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

        private Square NextLegalMove(Square from, Direction direction, PieceColor currentColor)
        {
            var next = NextSquare(from, direction);
            if (next == null) return null;
            if (next.Piece == null || next.Piece.Color != currentColor)
                return next;
            return null;
        }

        private IList<Square> NextLegalMoves(Square from, Direction direction, PieceColor currentColor)
        {
            var nextLegalMoves = new List<Square>();
            var current = from;
            while (true)
            {
                var next = NextLegalMove(from, direction, currentColor);
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
