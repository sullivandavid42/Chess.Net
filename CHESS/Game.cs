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
            this.MakeATurn();
            ChessBoardGeneral.PrintChessBoard();
        }

        public void MakeATurn()
        {
            if (ChessBoardGeneral.Board[3, 0].PieceBoard.Color == Trait)
            {
                // Copy the right board to a tmp
                ChessBoard boardTmp = ChessBoardGeneral;
                // First move the piece on the tmp board, and assign it to a new board
                // Just to test
                ChessBoard newBoardTmp = ChessBoardGeneral.Board[3, 0].PieceBoard.MovePiece(boardTmp, ChessBoardGeneral.Board[3, 0].XYCoords(), new int[] { 3, 6 });

                if (newBoardTmp != null)
                {
                    ChessBoardGeneral = newBoardTmp;
                    this.UpdateTrait();
                }
                else
                    MakeATurn();


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
