using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHESS
{
    class Game
    {
        public ChessBoard ChessBoardGeneral
        {
            get;
            set;
        }

        public Color Trait
        {
            get;
            set;
        }

        public bool IsEnded
        {
            get; set;
        }

        public Game()
        {
            ChessBoardGeneral = new ChessBoard();
            Trait = Color.White;
            IsEnded = false;
            ChessBoardGeneral.PrintChessBoard();
            Console.WriteLine(ChessBoardGeneral.Board[1, 2].XYCoords()[1]);
            this.MakeATurn();
            ChessBoardGeneral.PrintChessBoard();
        }

        public void MakeATurn()
        {
            if (ChessBoardGeneral.Board[6, 1].PieceBoard.Color == Trait)
            {
                // Copy the right board to a tmp
                ChessBoard boardTmp = ChessBoardGeneral;
                // First move the piece on the tmp board, and assign it to a new board
                ChessBoard newBoardTmp = ChessBoardGeneral.Board[6, 1].PieceBoard.MovePiece(boardTmp, ChessBoardGeneral.Board[6, 1].XYCoords(), new int[] { 4, 1});
                // newboard = right board
                ChessBoardGeneral = newBoardTmp;

                this.UpdateTrait();

            }
        }

        public void UpdateTrait()
        {
            if (Trait == Color.White && !IsEnded)
                Trait = Color.Black;
            else if (Trait == Color.Black && !IsEnded)
                Trait = Color.White;
        }
    }
}
