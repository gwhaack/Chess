using Chess.Enums;
using Chess.Models;
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

            Equal(new PieceState { PieceType = PieceType.Rook, SquareId = "a1" }, state.WhiteRookA);
            Equal(new PieceState { PieceType = PieceType.Knight, SquareId = "b1" }, state.WhiteKnightB);
            Equal(new PieceState { PieceType = PieceType.Bishop, SquareId = "c1" }, state.WhiteBishopC);
            Equal(new PieceState { PieceType = PieceType.Queen, SquareId = "d1" }, state.WhiteQueen);  
            Equal(new PieceState { PieceType = PieceType.King, SquareId = "e1" }, state.WhiteKing);   
            Equal(new PieceState { PieceType = PieceType.Bishop, SquareId = "f1" }, state.WhiteBishopF);
            Equal(new PieceState { PieceType = PieceType.Knight, SquareId = "g1" }, state.WhiteKnightG);
            Equal(new PieceState { PieceType = PieceType.Rook, SquareId = "h1" }, state.WhiteRookH);

            Equal(new PieceState { PieceType = PieceType.Pawn, SquareId = "a2" }, state.WhitePawnA);  
            Equal(new PieceState { PieceType = PieceType.Pawn, SquareId = "b2" }, state.WhitePawnB);  
            Equal(new PieceState { PieceType = PieceType.Pawn, SquareId = "c2" }, state.WhitePawnC);  
            Equal(new PieceState { PieceType = PieceType.Pawn, SquareId = "d2" }, state.WhitePawnD);  
            Equal(new PieceState { PieceType = PieceType.Pawn, SquareId = "e2" }, state.WhitePawnE);  
            Equal(new PieceState { PieceType = PieceType.Pawn, SquareId = "f2" }, state.WhitePawnF);  
            Equal(new PieceState { PieceType = PieceType.Pawn, SquareId = "g2" }, state.WhitePawnG);  
            Equal(new PieceState { PieceType = PieceType.Pawn, SquareId = "h2" }, state.WhitePawnH);

            Equal(new PieceState { PieceType = PieceType.Rook, SquareId = "a8" }, state.BlackRookA);  
            Equal(new PieceState { PieceType = PieceType.Knight, SquareId = "b8" }, state.BlackKnightB);
            Equal(new PieceState { PieceType = PieceType.Bishop, SquareId = "c8" }, state.BlackBishopC);
            Equal(new PieceState { PieceType = PieceType.Queen, SquareId = "d8" }, state.BlackQueen);  
            Equal(new PieceState { PieceType = PieceType.King, SquareId = "e8" }, state.BlackKing);   
            Equal(new PieceState { PieceType = PieceType.Bishop, SquareId = "f8" }, state.BlackBishopF);
            Equal(new PieceState { PieceType = PieceType.Knight, SquareId = "g8" }, state.BlackKnightG);
            Equal(new PieceState { PieceType = PieceType.Rook, SquareId = "h8" }, state.BlackRookH);

            Equal(new PieceState { PieceType = PieceType.Pawn, SquareId = "a7" }, state.BlackPawnA);  
            Equal(new PieceState { PieceType = PieceType.Pawn, SquareId = "b7" }, state.BlackPawnB);  
            Equal(new PieceState { PieceType = PieceType.Pawn, SquareId = "c7" }, state.BlackPawnC);  
            Equal(new PieceState { PieceType = PieceType.Pawn, SquareId = "d7" }, state.BlackPawnD);  
            Equal(new PieceState { PieceType = PieceType.Pawn, SquareId = "e7" }, state.BlackPawnE);  
            Equal(new PieceState { PieceType = PieceType.Pawn, SquareId = "f7" }, state.BlackPawnF);  
            Equal(new PieceState { PieceType = PieceType.Pawn, SquareId = "g7" }, state.BlackPawnG);  
            Equal(new PieceState { PieceType = PieceType.Pawn, SquareId = "h7" }, state.BlackPawnH);
        }

        private void Equal(PieceState expected, PieceState actual)
        {
            Assert.Equal(expected.PieceType, actual.PieceType);
            Assert.Equal(expected.SquareId, actual.SquareId);
        }
    }
}
