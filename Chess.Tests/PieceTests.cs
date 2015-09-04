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
        public void Ctor()
        {
            var type = PieceType.Bishop;
            var color = PieceColor.Black;

            var piece = new Piece(type, color);

            Assert.Equal(type, piece.Type);
            Assert.Equal(color, piece.Color);
        }

        [Fact]
        public void Generate()
        {
            var type = PieceType.Bishop;
            var color = PieceColor.Black;
            int quantity = 10;

            var pieces = Piece.Generate(type, color, quantity).ToList();

            Assert.Equal(quantity, pieces.Count());
            foreach (var piece in pieces)
            {
                Assert.Equal(type, piece.Type);
                Assert.Equal(color, piece.Color);
            }
        }
    }
}
