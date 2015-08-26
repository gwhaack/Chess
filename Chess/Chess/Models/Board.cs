using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Models;
using Chess.Models.Pieces;
using Chess.Enums;

namespace Chess.Models
{
    public class Board
    {
        public Square[,] Squares { get; private set; }

        public Board()
        {
            Squares = new Square[8, 8];
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    var square = new Square(row, col);
                    if (row > 2 && row < 7)
                    {
                        Squares[row, col] = square;
                        continue;
                    }
                    Piece piece = null;
                    var color = row <= 2
                        ? PieceColor.White
                        : PieceColor.Black;
                    if (row == 2 || row == 7)
                        piece = new Pawn(square, color);
                    else
                    {
                        if (col == 1 || col == 8)
                            piece = new Rook(square, color);
                        else if (col == 2 || col == 7)
                            piece = new Knight(square, color);
                        else if (col == 3 || col == 6)
                            piece = new Bishop(square, color);
                        else if (col == 4)
                            piece = new Queen(square, color);
                        else if (col == 5)
                            piece = new King(square, color);
                    }
                    square.Piece = piece;
                    Squares[row, col] = square;

                }
            }
        }
    }
}
