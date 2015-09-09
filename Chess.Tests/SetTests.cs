using Chess.Enums;
using Chess.Models;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Xunit;

namespace Chess.Tests
{
    [ExcludeFromCodeCoverage]
    public class SetTests
    {
        [Fact]
        [Trait("Chess", "Models")]
        public void Ctor()
        {
            var color = PieceColor.Black;
            var set = new Set(color);

            var pieces = set.Pieces.ToList();
            Assert.Equal(16, pieces.Count);
            foreach (var piece in pieces)
            {
                Assert.Equal(color, piece.Color);
            }
        }
    }
}
