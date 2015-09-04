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
        public void Ctor_a1()
        {
            int row = 1;
            var column = Column.a;
            var color = SquareColor.Dark;
            string id = "a1";

            var square = new Square(column, row);

            Assert.Equal(row, square.Row);
            Assert.Equal(column, square.Column);
            Assert.Equal(color, square.Color);
            Assert.Equal(id, square.Id);
        }

        [Fact]
        public void Ctor_h7()
        {
            var column = Column.h;
            int row = 7;
            var color = SquareColor.Light;
            string id = "h7";

            var square = new Square(column, row);

            Assert.Equal(column, square.Column);
            Assert.Equal(row, square.Row);
            Assert.Equal(color, square.Color);
            Assert.Equal(id, square.Id);
        }
    }
}
