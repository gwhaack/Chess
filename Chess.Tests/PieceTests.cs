using Chess.Enums;
using Chess.Models;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Xunit;

namespace Chess.Tests
{
    [ExcludeFromCodeCoverage]
    public class PieceTests
    {
        [Fact]
        [Trait("Chess", "Models")]
        public void Ctor()
        {
            var type = PieceType.Bishop;
            var color = PieceColor.Black;

            var piece = new Piece(type, color);

            Assert.Equal(type, piece.Type);
            Assert.Equal(color, piece.Color);
        }
    }
}
