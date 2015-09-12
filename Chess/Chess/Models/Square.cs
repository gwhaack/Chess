using Chess.Enums;
using System;

namespace Chess.Models
{
    public class Square
    {
        private readonly File _file;
        private readonly int _rank;
        private readonly SquareColor _color;
        public SquareColor Color
        {
            get { return _color; }
        }
        public string Id
        {
            get
            {
                return GetId(File, Rank);
            }
        }
        public Piece Piece { get; set; }

        public int Rank
        {
            get { return _rank; }
        }

        public File File
        {
            get { return _file; }
        }

        public Square(File file, int rank)
        {
            _file = file;
            _rank = rank;
            _color = (rank + (int) file) % 2 == 0
                ? SquareColor.Dark
                : SquareColor.Light;
        }

        public static string GetId(File file, int rank)
        {
            return String.Format("{0}{1}", file, rank);
        }
    }
}
