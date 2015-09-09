﻿using Chess.Enums;
using System.Collections.Generic;

namespace Chess.Models
{
    public class Piece
    {
        private readonly PieceType _type;
        public PieceType Type
        {
            get { return _type; }
        }
        private readonly PieceColor _color;
        public PieceColor Color
        {
            get { return _color; }
        }
        public Square Square { get; set; }
        public IList<Square> LegalMoves { get; set; }
        public bool Moved { get; set; }
        public bool Captured { get; set; }

        public Piece(PieceType type, PieceColor color)
        {
            _type = type;
            _color = color;
        }
    }
}
