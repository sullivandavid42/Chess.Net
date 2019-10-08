using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHESS
{
    public class Game
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
            
            // Play a real move from user input. This is just for test cases and interoperability
            //int[,] coord = AskUserSourceDest();
            //MakeTurn(ChessBoardGeneral.Board[coord[0, 0], coord[0, 1]], new int[]
            //{
            //    coord[1, 0], coord[1, 1]
            //});
        }


        /*
         * Need to choose a right way to move, either we go with int[] or with a Case for source and dest both
         */
        public bool MakeTurn(Case source, int[] dest)
        {
            ChessBoard boardTmp = ChessBoardGeneral;

            ChessBoard newBoardTmp = ChessBoardGeneral.Board[source.CoordX, source.CoordY].PieceBoard
                .MovePiece(boardTmp, ChessBoardGeneral.Board[source.CoordX, source.CoordY].XYCoords(), dest);

            if (newBoardTmp != null)
            {
                ChessBoardGeneral = newBoardTmp;
                this.UpdateTrait();
                ChessBoardGeneral.PrintChessBoard();
                return true;
            }
            else
            {
                // MakeTurn(source, dest);
                // SHOULD ASK NEW COORD
                return false;
            }
        }


        private int[,] AskUserSourceDest()
        {
            Console.WriteLine("Enter coordinate -> 0;0/0;1  :");
            string input = Console.ReadLine();
            int[,] inputCoordinates = new int[,] {
                { (int)Char.GetNumericValue(input[0]), (int)Char.GetNumericValue(input[2]) },
                { (int)Char.GetNumericValue(input[4]), (int)Char.GetNumericValue(input[6]) }
            };

            if (inputCoordinates.Length != 3)
                return inputCoordinates;
            else
                return AskUserSourceDest();
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
