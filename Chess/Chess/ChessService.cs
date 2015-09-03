using Chess.Enums;
using Chess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class ChessService
    {
        private ChessBoard ChessBoard;

        public void NewGame()
        {
            ChessBoard = new ChessBoard();
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    var square = new Square(row, col);
                    if (row > 2 && row < 7)
                    {
                        ChessBoard.Squares[row, col] = square;
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
                    ChessBoard[row, col] = square;
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
                    return LegalBishopMoves(currentSquare);
                case PieceType.King:
                    return LegalKingMoves(currentSquare);
                case PieceType.Knight:
                    return LegalKnightMoves(currentSquare);
                case PieceType.Pawn:
                    return LegalPawnMoves(currentSquare);
                case PieceType.Queen:
                    return LegalQueenMoves(currentSquare);
                case PieceType.Rook:
                    return LegalRookMoves(currentSquare);
                default:
                    return new List<Square>();
            }
        }

        private IList<Square> LegalBishopMoves(Square currentSquare, PieceColor currentColor)
        {
            var legalMoves = new List<Square>();
            Square current = currentSquare;
            while(true)
            {
                var next = NextSquare(currentSquare, Direction.UpperLeft);
                if (next == null) break;
                if (next.Piece == null || next.Piece.Color != currentColor)
                {
                    legalMoves.Add(next);
                    current = next;
                    continue;
                }
            }
        }

        private IList<Square> LegalKingMoves(Square currentSquare)
        {

        }

        private IList<Square> LegalKnightMoves(Square currentSquare)
        {

        }

        private IList<Square> LegalPawnMoves(Square currentSquare)
        {

        }

        private IList<Square> LegalQueenMoves(Square currentSquare)
        {

        }

        private IList<Square> LegalRookMoves(Square currentSquare)
        {

        }
        private Square NextSquare(Square start, Direction direction)
        {
            int row = start.Row;
            int column = start.Column;
            switch (direction)
            {
                case Direction.Up:
                    row += 1;
                    break;
                case Direction.Down:
                    row -= 1;
                    break;
                case Direction.Left:
                    column -= 1;
                    break;
                case Direction.Right:
                    column += 1;
                    break;
                case Direction.UpperLeft:
                    row += 1;
                    column -= 1;
                    break;
                case Direction.UpperRight:
                    row += 1;
                    column += 1;
                    break;
                case Direction.LowerLeft:
                    row -= 1;
                    column -= 1;
                    break;
                case Direction.LowerRight:
                    row -= 1;
                    column += 1;
                    break;
                default:
                    return null;
            }
            if (row > 8 || row < 0 || column > 8 || column < 0)
                return null;
            return ChessBoard[row, column];
        }
    }
}
