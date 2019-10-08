using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CHESS;
using FluentAssertions;

namespace TestChessNet
{
    [TestClass]
    public class TestMoves_Rook
    {
        [TestMethod]
        [Description("Try to move a WHITE ROOK from SUD to NORTH")]
        public void TestMoveRook_White_North_ShouldReturnGoodBoard_AndReturnTrue()
        {
            CHESS.Game game = new CHESS.Game();
            ChessBoard board = game.ChessBoardGeneral;
            Rook rook = new Rook(Color.White);

            game.ChessBoardGeneral.Board[6, 0].PieceBoard = rook;

            Case[,] wantedBoard = new Case[,]
            {
                { new Case(new Rook(Color.Black), 0,0), new Case(new Knight(Color.Black), 0,1), new Case(new Bishop(Color.Black), 0,2), new Case(new Queen(Color.Black), 0,3), new Case(new King(Color.Black), 0,4), new Case(new Bishop(Color.Black), 0,5), new Case(new Knight(Color.Black), 0,6), new Case(new Rook(Color.Black), 0,7) },
                { new Case(new Pawn(Color.Black), 1,0), new Case(new Pawn(Color.Black), 1,1), new Case(new Pawn(Color.Black), 1,2), new Case(new Pawn(Color.Black), 1,3), new Case(new Pawn(Color.Black), 1,4), new Case(new Pawn(Color.Black), 1,5), new Case(new Pawn(Color.Black), 1,6), new Case(new Pawn(Color.Black), 1,7) },
                { new Case(new EmptyPiece(), 2, 0), new Case(new EmptyPiece(),2, 1), new Case(new EmptyPiece(),2, 2),new Case(new EmptyPiece(),2, 3), new Case(new EmptyPiece(),2, 4), new Case(new EmptyPiece(),2, 5), new Case(new EmptyPiece(),2, 6), new Case(new EmptyPiece(),2, 7) },
                { new Case(new EmptyPiece(),3, 0), new Case(new EmptyPiece(),3, 1), new Case(new EmptyPiece(),3, 2),new Case(new EmptyPiece(),3, 3), new Case(new EmptyPiece(),3, 4), new Case(new EmptyPiece(),3, 5), new Case(new EmptyPiece(),3, 6), new Case(new EmptyPiece(),3, 7) },
                { new Case(new Rook(Color.White),4, 0), new Case(new EmptyPiece(),4, 1), new Case(new EmptyPiece(),4, 2),new Case(new EmptyPiece(),4, 3), new Case(new EmptyPiece(),4, 4), new Case(new EmptyPiece(),4, 5), new Case(new EmptyPiece(),4, 6), new Case(new EmptyPiece(),4, 7) },
                { new Case(new EmptyPiece(),5, 0), new Case(new EmptyPiece(),5, 1), new Case(new EmptyPiece(),5, 2),new Case(new EmptyPiece(),5, 3), new Case(new EmptyPiece(),5, 4), new Case(new EmptyPiece(),5, 5), new Case(new EmptyPiece(),5, 6), new Case(new EmptyPiece(),5, 7) },
                { new Case(new EmptyPiece(), 6,0), new Case(new Pawn(Color.White), 6,1), new Case(new Pawn(Color.White), 6,2), new Case(new Pawn(Color.White), 6,3), new Case(new Pawn(Color.White), 6,4), new Case(new Pawn(Color.White), 6,5), new Case(new Pawn(Color.White), 6,6), new Case(new Pawn(Color.White), 6,7) },
                { new Case(new Rook(Color.White), 7,0), new Case(new Knight(Color.White), 7,1), new Case(new Bishop(Color.White), 7,2), new Case(new King(Color.White), 7,3), new Case(new Queen(Color.White), 7,4), new Case(new Bishop(Color.White), 7,5), new Case(new Knight(Color.White), 7,6), new Case(new Rook(Color.White), 7,7) },
            };

            bool ret = game.MakeTurn(game.ChessBoardGeneral.Board[6, 0], new int[] { 4, 0 });
            game.ChessBoardGeneral.Board.Should().BeEquivalentTo(wantedBoard);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        [Description("Try to move a WHITE ROOK from NORTH to SUD")]
        public void TestMoveRook_White_South_ShouldReturnGoodBoard_AndReturnTrue()
        {
            CHESS.Game game = new CHESS.Game();
            ChessBoard board = game.ChessBoardGeneral;
            Rook rook = new Rook(Color.White);

            game.ChessBoardGeneral.Board[3, 0].PieceBoard = rook;

            Case[,] wantedBoard = new Case[,]
            {
                { new Case(new Rook(Color.Black), 0,0), new Case(new Knight(Color.Black), 0,1), new Case(new Bishop(Color.Black), 0,2), new Case(new Queen(Color.Black), 0,3), new Case(new King(Color.Black), 0,4), new Case(new Bishop(Color.Black), 0,5), new Case(new Knight(Color.Black), 0,6), new Case(new Rook(Color.Black), 0,7) },
                { new Case(new Pawn(Color.Black), 1,0), new Case(new Pawn(Color.Black), 1,1), new Case(new Pawn(Color.Black), 1,2), new Case(new Pawn(Color.Black), 1,3), new Case(new Pawn(Color.Black), 1,4), new Case(new Pawn(Color.Black), 1,5), new Case(new Pawn(Color.Black), 1,6), new Case(new Pawn(Color.Black), 1,7) },
                { new Case(new EmptyPiece(), 2, 0), new Case(new EmptyPiece(),2, 1), new Case(new EmptyPiece(),2, 2),new Case(new EmptyPiece(),2, 3), new Case(new EmptyPiece(),2, 4), new Case(new EmptyPiece(),2, 5), new Case(new EmptyPiece(),2, 6), new Case(new EmptyPiece(),2, 7) },
                { new Case(new EmptyPiece(),3, 0), new Case(new EmptyPiece(),3, 1), new Case(new EmptyPiece(),3, 2),new Case(new EmptyPiece(),3, 3), new Case(new EmptyPiece(),3, 4), new Case(new EmptyPiece(),3, 5), new Case(new EmptyPiece(),3, 6), new Case(new EmptyPiece(),3, 7) },
                { new Case(new EmptyPiece(),4, 0), new Case(new EmptyPiece(),4, 1), new Case(new EmptyPiece(),4, 2),new Case(new EmptyPiece(),4, 3), new Case(new EmptyPiece(),4, 4), new Case(new EmptyPiece(),4, 5), new Case(new EmptyPiece(),4, 6), new Case(new EmptyPiece(),4, 7) },
                { new Case(new Rook(Color.White),5, 0), new Case(new EmptyPiece(),5, 1), new Case(new EmptyPiece(),5, 2),new Case(new EmptyPiece(),5, 3), new Case(new EmptyPiece(),5, 4), new Case(new EmptyPiece(),5, 5), new Case(new EmptyPiece(),5, 6), new Case(new EmptyPiece(),5, 7) },
                { new Case(new Pawn(Color.White), 6,0), new Case(new Pawn(Color.White), 6,1), new Case(new Pawn(Color.White), 6,2), new Case(new Pawn(Color.White), 6,3), new Case(new Pawn(Color.White), 6,4), new Case(new Pawn(Color.White), 6,5), new Case(new Pawn(Color.White), 6,6), new Case(new Pawn(Color.White), 6,7) },
                { new Case(new Rook(Color.White), 7,0), new Case(new Knight(Color.White), 7,1), new Case(new Bishop(Color.White), 7,2), new Case(new King(Color.White), 7,3), new Case(new Queen(Color.White), 7,4), new Case(new Bishop(Color.White), 7,5), new Case(new Knight(Color.White), 7,6), new Case(new Rook(Color.White), 7,7) },
            };

            bool ret = game.MakeTurn(game.ChessBoardGeneral.Board[3, 0], new int[] { 5, 0 });
            game.ChessBoardGeneral.Board.Should().BeEquivalentTo(wantedBoard);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        [Description("Try to move a WHITE ROOK from WEST to EAST")]
        public void TestMoveRook_White_East_ShouldReturnGoodBoard_AndReturnTrue()
        {
            CHESS.Game game = new CHESS.Game();
            ChessBoard board = game.ChessBoardGeneral;
            Rook rook = new Rook(Color.White);

            game.ChessBoardGeneral.Board[4, 0].PieceBoard = rook;

            Case[,] wantedBoard = new Case[,]
            {
                { new Case(new Rook(Color.Black), 0,0), new Case(new Knight(Color.Black), 0,1), new Case(new Bishop(Color.Black), 0,2), new Case(new Queen(Color.Black), 0,3), new Case(new King(Color.Black), 0,4), new Case(new Bishop(Color.Black), 0,5), new Case(new Knight(Color.Black), 0,6), new Case(new Rook(Color.Black), 0,7) },
                { new Case(new Pawn(Color.Black), 1,0), new Case(new Pawn(Color.Black), 1,1), new Case(new Pawn(Color.Black), 1,2), new Case(new Pawn(Color.Black), 1,3), new Case(new Pawn(Color.Black), 1,4), new Case(new Pawn(Color.Black), 1,5), new Case(new Pawn(Color.Black), 1,6), new Case(new Pawn(Color.Black), 1,7) },
                { new Case(new EmptyPiece(), 2, 0), new Case(new EmptyPiece(),2, 1), new Case(new EmptyPiece(),2, 2),new Case(new EmptyPiece(),2, 3), new Case(new EmptyPiece(),2, 4), new Case(new EmptyPiece(),2, 5), new Case(new EmptyPiece(),2, 6), new Case(new EmptyPiece(),2, 7) },
                { new Case(new EmptyPiece(),3, 0), new Case(new EmptyPiece(),3, 1), new Case(new EmptyPiece(),3, 2),new Case(new EmptyPiece(),3, 3), new Case(new EmptyPiece(),3, 4), new Case(new EmptyPiece(),3, 5), new Case(new EmptyPiece(),3, 6), new Case(new EmptyPiece(),3, 7) },
                { new Case(new EmptyPiece(),4, 0), new Case(new EmptyPiece(),4, 1), new Case(new Rook(Color.White),4, 2),new Case(new EmptyPiece(),4, 3), new Case(new EmptyPiece(),4, 4), new Case(new EmptyPiece(),4, 5), new Case(new EmptyPiece(),4, 6), new Case(new EmptyPiece(),4, 7) },
                { new Case(new EmptyPiece(),5, 0), new Case(new EmptyPiece(),5, 1), new Case(new EmptyPiece(),5, 2),new Case(new EmptyPiece(),5, 3), new Case(new EmptyPiece(),5, 4), new Case(new EmptyPiece(),5, 5), new Case(new EmptyPiece(),5, 6), new Case(new EmptyPiece(),5, 7) },
                { new Case(new Pawn(Color.White), 6,0), new Case(new Pawn(Color.White), 6,1), new Case(new Pawn(Color.White), 6,2), new Case(new Pawn(Color.White), 6,3), new Case(new Pawn(Color.White), 6,4), new Case(new Pawn(Color.White), 6,5), new Case(new Pawn(Color.White), 6,6), new Case(new Pawn(Color.White), 6,7) },
                { new Case(new Rook(Color.White), 7,0), new Case(new Knight(Color.White), 7,1), new Case(new Bishop(Color.White), 7,2), new Case(new King(Color.White), 7,3), new Case(new Queen(Color.White), 7,4), new Case(new Bishop(Color.White), 7,5), new Case(new Knight(Color.White), 7,6), new Case(new Rook(Color.White), 7,7) },
            };

            bool ret = game.MakeTurn(game.ChessBoardGeneral.Board[4, 0], new int[] { 4, 2 });
            game.ChessBoardGeneral.Board.Should().BeEquivalentTo(wantedBoard);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        [Description("Try to move a WHITE ROOK from EAST to WEST")]
        public void TestMoveRook_White_West_ShouldReturnGoodBoard_AndReturnTrue()
        {
            CHESS.Game game = new CHESS.Game();
            ChessBoard board = game.ChessBoardGeneral;
            Rook rook = new Rook(Color.White);

            game.ChessBoardGeneral.Board[4, 2].PieceBoard = rook;

            Case[,] wantedBoard = new Case[,]
            {
                { new Case(new Rook(Color.Black), 0,0), new Case(new Knight(Color.Black), 0,1), new Case(new Bishop(Color.Black), 0,2), new Case(new Queen(Color.Black), 0,3), new Case(new King(Color.Black), 0,4), new Case(new Bishop(Color.Black), 0,5), new Case(new Knight(Color.Black), 0,6), new Case(new Rook(Color.Black), 0,7) },
                { new Case(new Pawn(Color.Black), 1,0), new Case(new Pawn(Color.Black), 1,1), new Case(new Pawn(Color.Black), 1,2), new Case(new Pawn(Color.Black), 1,3), new Case(new Pawn(Color.Black), 1,4), new Case(new Pawn(Color.Black), 1,5), new Case(new Pawn(Color.Black), 1,6), new Case(new Pawn(Color.Black), 1,7) },
                { new Case(new EmptyPiece(), 2, 0), new Case(new EmptyPiece(),2, 1), new Case(new EmptyPiece(),2, 2),new Case(new EmptyPiece(),2, 3), new Case(new EmptyPiece(),2, 4), new Case(new EmptyPiece(),2, 5), new Case(new EmptyPiece(),2, 6), new Case(new EmptyPiece(),2, 7) },
                { new Case(new EmptyPiece(),3, 0), new Case(new EmptyPiece(),3, 1), new Case(new EmptyPiece(),3, 2),new Case(new EmptyPiece(),3, 3), new Case(new EmptyPiece(),3, 4), new Case(new EmptyPiece(),3, 5), new Case(new EmptyPiece(),3, 6), new Case(new EmptyPiece(),3, 7) },
                { new Case(new Rook(Color.White),4, 0), new Case(new EmptyPiece(),4, 1), new Case(new EmptyPiece(),4, 2),new Case(new EmptyPiece(),4, 3), new Case(new EmptyPiece(),4, 4), new Case(new EmptyPiece(),4, 5), new Case(new EmptyPiece(),4, 6), new Case(new EmptyPiece(),4, 7) },
                { new Case(new EmptyPiece(),5, 0), new Case(new EmptyPiece(),5, 1), new Case(new EmptyPiece(),5, 2),new Case(new EmptyPiece(),5, 3), new Case(new EmptyPiece(),5, 4), new Case(new EmptyPiece(),5, 5), new Case(new EmptyPiece(),5, 6), new Case(new EmptyPiece(),5, 7) },
                { new Case(new Pawn(Color.White), 6,0), new Case(new Pawn(Color.White), 6,1), new Case(new Pawn(Color.White), 6,2), new Case(new Pawn(Color.White), 6,3), new Case(new Pawn(Color.White), 6,4), new Case(new Pawn(Color.White), 6,5), new Case(new Pawn(Color.White), 6,6), new Case(new Pawn(Color.White), 6,7) },
                { new Case(new Rook(Color.White), 7,0), new Case(new Knight(Color.White), 7,1), new Case(new Bishop(Color.White), 7,2), new Case(new King(Color.White), 7,3), new Case(new Queen(Color.White), 7,4), new Case(new Bishop(Color.White), 7,5), new Case(new Knight(Color.White), 7,6), new Case(new Rook(Color.White), 7,7) },
            };

            bool ret = game.MakeTurn(game.ChessBoardGeneral.Board[4, 2], new int[] { 4, 0 });
            game.ChessBoardGeneral.Board.Should().BeEquivalentTo(wantedBoard);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        [Description("Try to move a WHITE ROOK and EAT a BLACK PAWN")]
        public void TestMovePawn_White_InitialPosition_EatOp_ShouldUpdateBoard_AndReturnTrue()
        {
            CHESS.Game game = new CHESS.Game();
            Rook rook = new Rook(Color.White);
            game.ChessBoardGeneral.Board[5, 0].PieceBoard = rook;

            Case[,] wantedBoard = new Case[,]
            {
                { new Case(new Rook(Color.Black), 0,0), new Case(new Knight(Color.Black), 0,1), new Case(new Bishop(Color.Black), 0,2), new Case(new Queen(Color.Black), 0,3), new Case(new King(Color.Black), 0,4), new Case(new Bishop(Color.Black), 0,5), new Case(new Knight(Color.Black), 0,6), new Case(new Rook(Color.Black), 0,7) },
                { new Case(new Rook(Color.White), 1,0), new Case(new Pawn(Color.Black), 1,1), new Case(new Pawn(Color.Black), 1,2), new Case(new Pawn(Color.Black), 1,3), new Case(new Pawn(Color.Black), 1,4), new Case(new Pawn(Color.Black), 1,5), new Case(new Pawn(Color.Black), 1,6), new Case(new Pawn(Color.Black), 1,7) },
                { new Case(new EmptyPiece(), 2, 0), new Case(new EmptyPiece(),2, 1), new Case(new EmptyPiece(),2, 2),new Case(new EmptyPiece(),2, 3), new Case(new EmptyPiece(),2, 4), new Case(new EmptyPiece(),2, 5), new Case(new EmptyPiece(),2, 6), new Case(new EmptyPiece(),2, 7) },
                { new Case(new EmptyPiece(),3, 0), new Case(new EmptyPiece(),3, 1), new Case(new EmptyPiece(),3, 2),new Case(new EmptyPiece(),3, 3), new Case(new EmptyPiece(),3, 4), new Case(new EmptyPiece(),3, 5), new Case(new EmptyPiece(),3, 6), new Case(new EmptyPiece(),3, 7) },
                { new Case(new EmptyPiece(),4, 0), new Case(new EmptyPiece(),4, 1), new Case(new EmptyPiece(),4, 2),new Case(new EmptyPiece(),4, 3), new Case(new EmptyPiece(),4, 4), new Case(new EmptyPiece(),4, 5), new Case(new EmptyPiece(),4, 6), new Case(new EmptyPiece(),4, 7) },
                { new Case(new EmptyPiece(),5, 0), new Case(new EmptyPiece(),5, 1), new Case(new EmptyPiece(),5, 2),new Case(new EmptyPiece(),5, 3), new Case(new EmptyPiece(),5, 4), new Case(new EmptyPiece(),5, 5), new Case(new EmptyPiece(),5, 6), new Case(new EmptyPiece(),5, 7) },
                { new Case(new Pawn(Color.White), 6,0), new Case(new Pawn(Color.White), 6,1), new Case(new Pawn(Color.White), 6,2), new Case(new Pawn(Color.White), 6,3), new Case(new Pawn(Color.White), 6,4), new Case(new Pawn(Color.White), 6,5), new Case(new Pawn(Color.White), 6,6), new Case(new Pawn(Color.White), 6,7) },
                { new Case(new Rook(Color.White), 7,0), new Case(new Knight(Color.White), 7,1), new Case(new Bishop(Color.White), 7,2), new Case(new King(Color.White), 7,3), new Case(new Queen(Color.White), 7,4), new Case(new Bishop(Color.White), 7,5), new Case(new Knight(Color.White), 7,6), new Case(new Rook(Color.White), 7,7) },
            };

            bool ret = game.MakeTurn(game.ChessBoardGeneral.Board[5, 0], new int[] { 1, 0 });
            game.ChessBoardGeneral.Board.Should().BeEquivalentTo(wantedBoard);
            Assert.IsTrue(ret);
        }
    }
}
