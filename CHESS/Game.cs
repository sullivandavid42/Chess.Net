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
            Trait = Color.Black;
            IsEnded = false;
            ChessBoardGeneral.PrintChessBoard();
            Console.WriteLine(ChessBoardGeneral.Board[1, 2].XYCoords()[1]);
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
                ChessBoard newBoardTmp = ChessBoardGeneral.Board[3, 0].PieceBoard.MovePiece(boardTmp, ChessBoardGeneral.Board[3, 0].XYCoords(), new int[] { 3, 6 });
                // newboard = right board

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
