using Chess.Enums;
using Chess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess
{
    /// <summary>
    /// A game of chess
    /// </summary>
    public class Game
    {
        private Board Board;
        private Set BlackPieces;
        private Set WhitePieces;
        private IEnumerable<Piece> Pieces;
        private Stack<Move> Moves;
        private Stack<Move> UndoneMoves;

        /// <summary>
        /// Start a new game.
        /// </summary>
        public void Start()
        {
            Board = new Board();
            BlackPieces = new Set(PieceColor.Black);
            WhitePieces = new Set(PieceColor.White);
            Pieces = BlackPieces.Pieces.Concat(WhitePieces.Pieces);
            Moves = new Stack<Move>();
            UndoneMoves = new Stack<Move>();

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

        /// <summary>
        /// Validate all piece/square pointers.
        /// </summary>
        /// <returns>True if all piece/square pointers match.</returns>
        public bool ValidState()
        {
            foreach (var piece in WhitePieces.Pieces)
            {
                if (piece.Square.Piece != piece)
                    return false;
            }

            foreach (var piece in BlackPieces.Pieces)
            {
                if (piece.Square.Piece != piece)
                    return false;
            }

            foreach (var square in Board.Squares)
            {
                if (square.Piece.Square == null)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Take a snapshot of the game.
        /// </summary>
        /// <returns>A GameState object.</returns>
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

        #region Move

        /// <summary>
        /// Move the specified piece to the specified square.
        /// </summary>
        /// <param name="move"><see cref="Move"/></param>
        /// <returns>False if the move is illegal.</returns>
        public bool Move(Move move)
        {
            var piece = move.Piece;
            var to = move.To;
            var from = move.From;

            // No illegal moves
            if (piece.Moves.Contains(move))
                return false;

            // Handle captures
            var captured = to.Piece;
            if (captured != null)
            {
                captured.Square = null;
            }

            // Adjust piece/square pointers
            piece.Square = to;
            to.Piece = piece;
            from.Piece = null;
           
            // Record the move
            Moves.Push(move);

            // Recalculate all possible next moves
            foreach (var p in Pieces)
            {
                var pVar = p;
                SetMoves(ref pVar);
            }
            
            return true;
        }

        /// <summary>
        /// Perform the castle move.
        /// </summary>
        /// <param name="color"><see cref="PieceColor"/></param>
        /// <param name="castleDirection"><see cref="CastleDirection"/></param>
        /// <returns>False if the castle is illegal.</returns>
        public bool Castle(PieceColor color, CastleDirection castleDirection)
        {
            // Define castling pieces
            var pieces = color == PieceColor.Black
                ? BlackPieces
                : WhitePieces;
            var king = pieces.King;

            Piece rook;
            Direction direction;
            Direction oppositeDirection;
            switch (castleDirection)
            {
                case CastleDirection.Kingside:
                    rook = pieces.RookH;
                    direction = Direction.Right;
                    oppositeDirection = Direction.Left;
                    break;
                case CastleDirection.Queenside:
                    rook = pieces.RookA;
                    direction = Direction.Left;
                    oppositeDirection = Direction.Right;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("castleDirection");
            }

            // Can't castle if either piece has moved
            if (king.Moved || rook.Moved)
                return false;

            // Can't castle if any pieces in between king and rook
            var square = NextSquare(king.Square, direction);
            while (square.Piece != rook)
            {
                if (square.Piece != null)
                    return false;
                square = NextSquare(square, direction);
            }

            // Adjust piece/square pointers
            var kingFrom = king.Square;
            var kingTo = NextSquare(kingFrom, direction, 2);
            king.Square = kingTo;
            kingTo.Piece = king;
            kingFrom.Piece = null;
            var rookFrom = king.Square;
            var rookTo = NextSquare(kingTo, oppositeDirection);
            rook.Square = rookTo;
            rookTo.Piece = rook;
            rookFrom.Piece = null;

            // Recalculate all possible next moves
            foreach (var p in Pieces)
            {
                var pVar = p;
                SetMoves(ref pVar);
            }

            return true;
        }

        /// <summary>
        /// Undo the last move.
        /// </summary>
        /// <returns>False if no moves have been made.</returns>
        public bool UndoLastMove()
        {
            // Grab last move
            var move = Moves.Pop();
            if (move == null) return false;

            // Reverse piece/square logic
            move.From.Piece = move.Piece;
            move.To.Piece = move.Captured;
            move.Piece.Square = move.From;

            // Reverse capture logic
            if (move.Captured != null)
            {
                move.Captured.Square = move.To;
            }

            // Record the undone move
            UndoneMoves.Push(move);

            // Recalculate all possible next moves
            foreach (var p in Pieces)
            {
                var pVar = p;
                SetMoves(ref pVar);
            }
            
            return true;
        }

        /// <summary>
        /// Redo the last undone move.
        /// </summary>
        /// <returns>False if no moves have been undone.</returns>
        public bool RedoMove()
        {
            // Grab last undone move
            var move = UndoneMoves.Pop();
            if (move == null) return false;

            // Redo capture logic
            if (move.Captured != null)
            {
                move.Captured.Square = null;
            }

            // Redo piece/square logic
            move.Piece.Square = move.To;
            move.To.Piece = move.Piece;
            move.From.Piece = null;

            // Record the move
            Moves.Push(move);

            // Recalculate all possible next moves
            foreach (var p in Pieces)
            {
                var pVar = p;
                SetMoves(ref pVar);
            }

            return true;
        }

        private static void PromotePawn(ref Piece pawn, PieceType newType)
        {
            if (pawn.Type != PieceType.Pawn)
                throw new ArgumentOutOfRangeException("pawn", "Promoting piece must be a pawn");
            pawn = new Piece(newType, pawn.Color);
        }

        #endregion

        #region Determine Legal Moves

        /// <summary>
        /// Set a Piece's legal moves.
        /// </summary>
        /// <param name="piece"><see cref="Piece"/></param>
        public void SetMoves(ref Piece piece)
        {
            switch (piece.Type)
            {
                case PieceType.Bishop:
                    BishopMoves(ref piece);
                    piece.Attacked = piece.Moves.Select(m => m.To).ToList();
                    break;
                case PieceType.King:
                    KingMoves(ref piece);
                    piece.Attacked = piece.Moves.Select(m => m.To).ToList();
                    break;
                case PieceType.Knight:
                    KnightMoves(ref piece);
                    piece.Attacked = piece.Moves.Select(m => m.To).ToList();
                    break;
                case PieceType.Pawn:
                    PawnMoves(ref piece);
                    PawnAttacked(ref piece);
                    break;
                case PieceType.Queen:
                    LegalQueenMoves(ref piece);
                    piece.Attacked = piece.Moves.Select(m => m.To).ToList();
                    break;
                case PieceType.Rook:
                    RookMoves(ref piece);
                    piece.Attacked = piece.Moves.Select(m => m.To).ToList();
                    break;
            }
        }
        
        private void BishopMoves(ref Piece bishop)
        {
            var moves = new List<Move>();

            moves.AddRange(NextLegalSquares(bishop.Square, Direction.UpperLeft, bishop.Color));
            moves.AddRange(NextLegalSquares(bishop.Square, Direction.UpperRight, bishop.Color));
            moves.AddRange(NextLegalSquares(bishop.Square, Direction.LowerLeft, bishop.Color));
            moves.AddRange(NextLegalSquares(bishop.Square, Direction.LowerRight, bishop.Color));

            bishop.Moves = moves;
        }

        private void KingMoves(ref Piece king)
        {
            var moves = new List<Move>();

            var opposingPieces = king.Color == PieceColor.Black
                ? WhitePieces.Pieces
                : BlackPieces.Pieces;
            foreach (Direction direction in Enum.GetValues(typeof (Direction)))
            {
                var square = NextLegalSquare(king.Square, direction, king.Color);
                if (!opposingPieces.Any(p => p.Attacked.Contains(square)))
                {
                    moves.Add(square);
                }
            }

            king.Moves = moves;
        }

        private void KnightMoves(ref Piece knight)
        {
            var moves = new List<Move>();

            var up = NextSquare(knight.Square, Direction.Up);
            var upLeft = NextLegalSquare(up, Direction.UpperLeft, knight.Color);
            if (upLeft != null) moves.Add(upLeft);
            var upRight = NextLegalSquare(up, Direction.UpperRight, knight.Color);
            if (upRight != null) moves.Add(upRight);

            var left = NextSquare(knight.Square, Direction.Left);
            var leftUp = NextLegalSquare(left, Direction.UpperLeft, knight.Color);
            if (leftUp != null) moves.Add(leftUp);
            var leftDown = NextLegalSquare(left, Direction.LowerLeft, knight.Color);
            if (leftDown != null) moves.Add(leftDown);

            var right = NextSquare(knight.Square, Direction.Right);
            var rightUp = NextLegalSquare(right, Direction.UpperRight, knight.Color);
            if (rightUp != null) moves.Add(rightUp);
            var rightDown = NextLegalSquare(right, Direction.LowerRight, knight.Color);
            if (rightDown != null) moves.Add(rightDown);

            var down = NextSquare(knight.Square, Direction.Down);
            var downLeft = NextLegalSquare(down, Direction.LowerLeft, knight.Color);
            if (downLeft != null) moves.Add(downLeft);
            var downRight = NextLegalSquare(down, Direction.LowerRight, knight.Color);
            if (downRight != null) moves.Add(downRight);

            knight.Moves = moves;
        }

        private void PawnMoves(ref Piece pawn)
        {
            var moves = new List<Move>();

            var direction = pawn.Color == PieceColor.White
                ? Direction.Up
                : Direction.Down;
            var squareOne = NextLegalSquare(pawn.Square, direction, pawn.Color);
            if (squareOne != null)
            {
                moves.Add(squareOne);
                if (!pawn.Moved)
                {
                    var squareTwo = NextLegalSquare(squareOne, direction, pawn.Color);
                    if (squareTwo != null)
                    {
                        moves.Add(squareTwo);
                    }
                }
            }

            // En passant
            int rank = pawn.Color == PieceColor.White
                ? 5
                : 4;

            if (pawn.Square.Rank == rank)
            {
                var left = NextSquare(pawn.Square, Direction.Left);
                if (left != null && left.Piece != null && left.Piece.Color != pawn.Color && left.Piece.Type == PieceType.Pawn)
                {
                    var lastMove = Moves.Peek();
                    if (lastMove.Piece == left.Piece && lastMove.FirstMove)
                    {
                        moves.Add(leftAttack);
                    }
                }

                var right = NextSquare(pawn.Square, Direction.Right);
                if (right != null && right.Piece != null && right.Piece.Color != pawn.Color && right.Piece.Type == PieceType.Pawn)
                {
                    var lastMove = Moves.Peek();
                    if (lastMove.Piece == right.Piece && lastMove.FirstMove)
                    {
                        attacked.Add(rightAttack);
                    }
                }
            }

            pawn.Moves = moves;
        }

        private void PawnAttacked(ref Piece pawn)
        {
            var attacked = new List<Square>();
            bool white = pawn.Color == PieceColor.White;

            var leftDirection = white
                ? Direction.UpperLeft
                : Direction.LowerLeft;
            var leftAttack = NextSquare(pawn.Square, leftDirection);
            if (leftAttack.Piece.Color != pawn.Color)
            {
                attacked.Add(leftAttack);
            }

            var rightDirection = white
                ? Direction.UpperRight
                : Direction.LowerRight;
            var rightAttack = NextSquare(pawn.Square, rightDirection);
            if (rightAttack.Piece.Color != pawn.Color)
            {
                attacked.Add(rightAttack);
            }

            pawn.Attacked = attacked;
        }

        private void LegalQueenMoves(ref Piece queen)
        {
            var moves = new List<Move>();

            foreach (Direction direction in Enum.GetValues(typeof(Direction)))
            {
                moves.AddRange(NextLegalSquares(queen.Square, direction, queen.Color));
            }

            queen.Moves = moves;
        }

        private void RookMoves(ref Piece rook)
        {
            var moves = new List<Move>();

            moves.AddRange(NextLegalSquares(rook.Square, Direction.Up, rook.Color));
            moves.AddRange(NextLegalSquares(rook.Square, Direction.Down, rook.Color));
            moves.AddRange(NextLegalSquares(rook.Square, Direction.Left, rook.Color));
            moves.AddRange(NextLegalSquares(rook.Square, Direction.Right, rook.Color));

            rook.Moves = moves;
        }

        private Square NextSquare(Square from, Direction direction, int distance = 1)
        {
            int file = (int) from.File;
            int rank = from.Rank;
            switch (direction)
            {
                case Direction.Up:
                    rank += distance;
                    break;
                case Direction.Down:
                    rank -= distance;
                    break;
                case Direction.Left:
                    file -= distance;
                    break;
                case Direction.Right:
                    file += distance;
                    break;
                case Direction.UpperLeft:
                    rank += distance;
                    file -= distance;
                    break;
                case Direction.UpperRight:
                    rank += distance;
                    file += distance;
                    break;
                case Direction.LowerLeft:
                    rank -= distance;
                    file -= distance;
                    break;
                case Direction.LowerRight:
                    rank -= distance;
                    file += distance;
                    break;
                default:
                    return null;
            }
            if (rank > Board.Size || rank < 0 || file > Board.Size || file < 0)
                return null;
            return Board[Square.GetId((File) file, rank)];
        }

        private Square NextLegalSquare(Square from, Direction direction, PieceColor pieceColor)
        {
            var next = NextSquare(from, direction);
            if (next == null) return null;
            if (next.Piece == null || next.Piece.Color != pieceColor)
                return next;
            return null;
        }

        private IList<Square> NextLegalSquares(Square from, Direction direction, PieceColor pieceColor)
        {
            var nextLegalSquares = new List<Square>();
            var current = from;
            while (true)
            {
                var next = NextLegalSquare(from, direction, pieceColor);
                if (next == null) break;
                if (next.Piece == null || next.Piece.Color != pieceColor)
                {
                    nextLegalSquares.Add(next);
                    current = next;
                }
                else break;
            }
            return nextLegalSquares;
        }

        #endregion
    }
}
