using Chess.Enums;
using Chess.Models;
using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Chess.Tests
{
    [ExcludeFromCodeCoverage]
    public class BoardTests
    {
        [Fact]
        [Trait("Chess", "Models")]
        public void Index_a1()
        {
            var board = new Board();
            Assert.Equal(board["a1"].Id, "a1");
        }

        [Fact]
        [Trait("Chess", "Models")]
        public void Index_h8()
        {
            var board = new Board();
            Assert.Equal(board["h8"].Id, "h8");
        }

        [Fact]
        [Trait("Chess", "Models")]
        public void Index_z0_Null()
        {
            var board = new Board();
            Assert.Throws<ArgumentOutOfRangeException>(() => board["z0"]);
        }

        [Fact]
        [Trait("Chess", "Models")]
        public void Index_i1_Null()
        {
            var board = new Board();
            Assert.Throws<ArgumentOutOfRangeException>(() => board["i1"]);
        }

        [Fact]
        [Trait("Chess", "Models")]
        public void Index_a0_Null()
        {
            var board = new Board();
            Assert.Throws<ArgumentOutOfRangeException>(() => board["a0"]);
        }

        [Fact]
        [Trait("Chess", "Models")]
        public void Index_h9_Null()
        {
            var board = new Board();
            Assert.Throws<ArgumentOutOfRangeException>(() => board["h9"]);
        }
    }
}
