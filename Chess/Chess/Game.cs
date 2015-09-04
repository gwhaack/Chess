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
        private Board ChessBoard;
        private Set BlackPieces;
        private Set WhitePieces;

        public void NewGame()
        {
            BlackPieces = new Set(PieceColor.Black);
            WhitePieces = new Set(PieceColor.White);
            ChessBoard = new Board();
            for (int col = 1; col <= 8; col++)
            {
                var column = (Column) col;
                for (int row = 1; row <= 8; row++)
                {
                    var square = new Square(column, row);
                    if (row > 2 && row < 7)
                    {
                        ChessBoard[column, row] = square;
                        continue;
                    }
                    Piece piece = null;
                    var color = row <= 2
                        ? PieceColor.White
                        : PieceColor.Black;
                    if (row == 2 || row == 7)
                    {
                        piece = new Piece(PieceType.Pawn, color)
                        {
                            Square = square,
                        };
                    }
                    else
                    {
                        if (col == 1 || col == 8)
                        {
                            piece = new Piece(PieceType.Rook, color)
                            {
                                Square = square,
                            };
                        }
                        else if (col == 2 || col == 7)
                        {
                            piece = new Piece(PieceType.Knight, color)
                            {
                                Square = square,
                            };
                        }
                        else if (col == 3 || col == 6)
                        {
                            piece = new Piece(PieceType.Bishop, color)
                            {
                                Square = square,
                            };
                        }
                        else if (col == 4)
                        {
                            piece = new Piece(PieceType.Queen, color)
                            {
                                Square = square,
                            };
                        }
                        else if (col == 5)
                        {
                            piece = new Piece(PieceType.King, color)
                            {
                                Square = square,
                            };
                        }
                    }
                    square.Piece = piece;
                    ChessBoard[column, row] = square;
                }
            }
        }

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
            if (row > 8 || row < 0 || col > 8 || col < 0)
                return null;
            return ChessBoard[(Column) col, row];
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
