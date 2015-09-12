using Chess.Enums;
using Chess.Models;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Chess.Tests
{
    [ExcludeFromCodeCoverage]
    public class SquareTests
    {
        [Fact]
        [Trait("Chess", "Models")]
        public void Ctor_a1()
        {
            int rank = 1;
            var file = File.a;
            var color = SquareColor.Dark;
            string id = "a1";

            var square = new Square(file, rank);

            Assert.Equal(rank, square.Rank);
            Assert.Equal(file, square.File);
            Assert.Equal(color, square.Color);
            Assert.Equal(id, square.Id);
        }

        [Fact]
        [Trait("Chess", "Models")]
        public void Ctor_h7()
        {
            var file = File.h;
            int rank = 7;
            var color = SquareColor.Light;
            string id = "h7";

            var square = new Square(file, rank);

            Assert.Equal(file, square.File);
            Assert.Equal(rank, square.Rank);
            Assert.Equal(color, square.Color);
            Assert.Equal(id, square.Id);
        }
    }
}
