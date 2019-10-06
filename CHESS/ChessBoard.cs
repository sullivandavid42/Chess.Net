using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHESS
{
    public class ChessBoard
    {

        public Case[,] Board
        {
            get;
            set;
        }

        public ChessBoard()
        {
            Board = InitBoard();
        }

        private Case[,] InitBoard()
        {
            Case[,] board = new Case[,]
            {
                { new Case(new Rook(Color.Black), 0,0), new Case(new Knight(Color.Black), 0,1), new Case(new Bishop(Color.Black), 0,2), new Case(new Queen(Color.Black), 0,3), new Case(new King(Color.Black), 0,4), new Case(new Bishop(Color.Black), 0,5), new Case(new Knight(Color.Black), 0,6), new Case(new Rook(Color.Black), 0,7) },
                { new Case(new Pawn(Color.Black), 1,0), new Case(new Pawn(Color.Black), 1,1), new Case(new Pawn(Color.Black), 1,2), new Case(new Pawn(Color.Black), 1,3), new Case(new Pawn(Color.Black), 1,4), new Case(new Pawn(Color.Black), 1,5), new Case(new Pawn(Color.Black), 1,6), new Case(new Pawn(Color.Black), 1,7) },
                { new Case(new EmptyPiece(), 2, 0), new Case(new EmptyPiece(),2, 1), new Case(new EmptyPiece(),2, 2),new Case(new EmptyPiece(),2, 3), new Case(new EmptyPiece(),2, 4), new Case(new EmptyPiece(),2, 5), new Case(new EmptyPiece(),2, 6), new Case(new EmptyPiece(),2, 7) },
                { new Case(new Rook(Color.White),3, 0), new Case(new EmptyPiece(),3, 1), new Case(new EmptyPiece(),3, 2),new Case(new EmptyPiece(),3, 3), new Case(new EmptyPiece(),3, 4), new Case(new EmptyPiece(),3, 5), new Case(new EmptyPiece(),3, 6), new Case(new EmptyPiece(),3, 7) },
                { new Case(new EmptyPiece(),4, 0), new Case(new EmptyPiece(),4, 1), new Case(new EmptyPiece(),4, 2),new Case(new EmptyPiece(),4, 3), new Case(new EmptyPiece(),4, 4), new Case(new EmptyPiece(),4, 5), new Case(new EmptyPiece(),4, 6), new Case(new EmptyPiece(),4, 7) },
                { new Case(new EmptyPiece(),5, 0), new Case(new EmptyPiece(),5, 1), new Case(new EmptyPiece(),5, 2),new Case(new EmptyPiece(),5, 3), new Case(new EmptyPiece(),5, 4), new Case(new EmptyPiece(),5, 5), new Case(new EmptyPiece(),5, 6), new Case(new EmptyPiece(),5, 7) },
                { new Case(new Pawn(Color.White), 6,0), new Case(new Pawn(Color.White), 6,1), new Case(new Pawn(Color.White), 6,2), new Case(new Pawn(Color.White), 6,3), new Case(new Pawn(Color.White), 6,4), new Case(new Pawn(Color.White), 6,5), new Case(new Pawn(Color.White), 6,6), new Case(new Pawn(Color.White), 6,7) },
                { new Case(new Rook(Color.White), 7,0), new Case(new Knight(Color.White), 7,1), new Case(new Bishop(Color.White), 7,2), new Case(new King(Color.White), 7,3), new Case(new Queen(Color.White), 7,4), new Case(new Bishop(Color.White), 7,5), new Case(new Knight(Color.White), 7,6), new Case(new Rook(Color.White), 7,7) },
            };
            return board;
        }

        public void PrintChessBoard()
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j ++)
                {
                    if (Board[i, j].PieceBoard != null && j > 0)
                        Console.Write("| " + Board[i, j].PieceBoard.Letter + " ");
                    else if (Board[i, j].PieceBoard != null && j == 0)
                        Console.Write(" " + Board[i, j].PieceBoard.Letter + " ");
                }
                Console.Write(Environment.NewLine);
            }
        }

        public Case GetCaseAtPos(int x, int y)
        {
            return this.Board[x, y];
        }

        public bool IsCaseEmpty(int x, int y)
        {
            Case tmpCase = GetCaseAtPos(x, y);
            if (tmpCase.PieceBoard != null)
            {
                if (tmpCase.PieceBoard.Color == Color.White || tmpCase.PieceBoard.Color == Color.Black)
                    return false;
                else
                    return true;
            }
            else
                return true;
        }

        public bool ContainsEnemyPiece(int x, int y, Color actualColor)
        {
            Case tmpCase = GetCaseAtPos(x, y);

            if (tmpCase.PieceBoard.Color == actualColor || tmpCase.PieceBoard.Color == Color.None)
                return false;
            else
                return true;

        }
    }
}
