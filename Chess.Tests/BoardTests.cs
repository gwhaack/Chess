using Chess.Enums;
using Chess.Models;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Chess.Tests
{
    [ExcludeFromCodeCoverage]
    public class BoardTests
    {
        public void Index_a1()
        {
            var board = new Board();
            Assert.Equal(board[Column.a, 1].Id, "a1");
        }

        public void Index_h8()
        {
            var board = new Board();
            Assert.Equal(board[Column.h, 8].Id, "h8");
        }

        public void Index_00_Null()
        {
            var board = new Board();
            Assert.Null(board[0, 0]);
        }

        public void Index_01_Null()
        {
            var board = new Board();
            Assert.Null(board[0, 1]);
        }

        public void Index_a0_Null()
        {
            var board = new Board();
            Assert.Null(board[Column.a, 0]);
        }

        public void Index_h9_Null()
        {
            var board = new Board();
            Assert.Null(board[Column.h, 9]);
        }
    }
}
