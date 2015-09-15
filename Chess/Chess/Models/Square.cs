using Chess.Enums;
using System;

namespace Chess.Models
{
    /// <summary>
    /// A square on a chess board.
    /// </summary>
    public class Square
    {
        /// <summary>
        /// <see cref="Enums.File"/>
        /// </summary>
        public File File
        {
            get { return _file; }
        }
        private readonly File _file;

        /// <summary>
        /// 1 through 8 (i.e. row).
        /// </summary>
        public int Rank
        {
            get { return _rank; }
        }
        private readonly int _rank;
        
        /// <summary>
        /// <see cref="SquareColor"/>
        /// </summary>
        public SquareColor Color
        {
            get { return _color; }
        }
        private readonly SquareColor _color;

        /// <summary>
        /// {File}{Rank}, e.g. a1, h8
        /// </summary>
        public string Id
        {
            get
            {
                return GetId(File, Rank);
            }
        }

        /// <summary>
        /// Piece on this square.
        /// </summary>
        public Piece Piece { get; set; }

        /// <summary>
        /// Create a square with the specified file and rank.
        /// </summary>
        /// <param name="file"><see cref="File"/></param>
        /// <param name="rank"><see cref="Rank"/></param>
        public Square(File file, int rank)
        {
            _file = file;
            _rank = rank;
            _color = (rank + (int) file) % 2 == 0
                ? SquareColor.Dark
                : SquareColor.Light;
        }

        /// <summary>
        /// Generate square ID from file and rank.
        /// </summary>
        /// <param name="file"><see cref="File"/></param>
        /// <param name="rank"><see cref="Rank"/></param>
        /// <returns></returns>
        public static string GetId(File file, int rank)
        {
            return String.Format("{0}{1}", file, rank);
        }
    }
}
