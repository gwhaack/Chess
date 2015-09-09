using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Chess.Tests
{
    [ExcludeFromCodeCoverage]
    public class GameTests
    {
        [Fact]
        [Trait("Chess", "Game")]
        public void NewGame()
        {
            var game = new Game();
            game.Start();

            var state = game.State();

            Assert.Equal("a1", state.WhiteRookA);
            Assert.Equal("b1", state.WhiteKnightB);
            Assert.Equal("c1", state.WhiteBishopC);
            Assert.Equal("d1", state.WhiteQueen);
            Assert.Equal("e1", state.WhiteKing);
            Assert.Equal("f1", state.WhiteBishopF);
            Assert.Equal("g1", state.WhiteKnightG);
            Assert.Equal("h1", state.WhiteRookH);

            Assert.Equal("a2", state.WhitePawnA);
            Assert.Equal("b2", state.WhitePawnB);
            Assert.Equal("c2", state.WhitePawnC);
            Assert.Equal("d2", state.WhitePawnD);
            Assert.Equal("e2", state.WhitePawnE);
            Assert.Equal("f2", state.WhitePawnF);
            Assert.Equal("g2", state.WhitePawnG);
            Assert.Equal("h2", state.WhitePawnH);

            Assert.Equal("a8", state.BlackRookA);
            Assert.Equal("b8", state.BlackKnightB);
            Assert.Equal("c8", state.BlackBishopC);
            Assert.Equal("d8", state.BlackQueen);
            Assert.Equal("e8", state.BlackKing);
            Assert.Equal("f8", state.BlackBishopF);
            Assert.Equal("g8", state.BlackKnightG);
            Assert.Equal("h8", state.BlackRookH);

            Assert.Equal("a7", state.BlackPawnA);
            Assert.Equal("b7", state.BlackPawnB);
            Assert.Equal("c7", state.BlackPawnC);
            Assert.Equal("d7", state.BlackPawnD);
            Assert.Equal("e7", state.BlackPawnE);
            Assert.Equal("f7", state.BlackPawnF);
            Assert.Equal("g7", state.BlackPawnG);
            Assert.Equal("h7", state.BlackPawnH);
        }
    }
}
