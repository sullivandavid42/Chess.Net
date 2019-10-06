using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHESS
{
    class Pawn : Piece
    {
        public Pawn(Color color)
        {
            Color = color;
            SetColor();
            IsInitialPos = true;
        }

        protected override void SetColor()
        {
            if (this.Color == Color.White)
                Letter = 'P';
            else if (this.Color == Color.Black)
                Letter = 'p';
            else
                Letter = 'o';
        }

        public override char Letter
        {
            get;
            set;
        }

        public override Color Color
        {
            get;
            set;
        }

        public bool IsInitialPos
        {
            get;
            set;
        }

        public override ChessBoard MovePiece(ChessBoard board, int[] coord, int[] desiredCoord)
        {
            Dictionary<int, int> availablePos = new Dictionary<int, int>();

            if (this.Color == Color.White)
            {
                if (board.IsCaseEmpty(coord[0] - 1, coord[1]))
                    availablePos.Add(coord[0] - 1, coord[1]);

                if (!board.IsCaseEmpty(coord[0] - 1, coord[1]) &&
                    board.GetCaseAtPos(coord[0] - 1, coord[1]).PieceBoard.Color == Color.Black)
                    availablePos.Add(coord[0] - 1, coord[1]);

                if (this.IsInitialPos) // - 2 || Ennemy piece at - 2
                {
                    if (board.IsCaseEmpty(coord[0] - 2, coord[1]))
                        availablePos.Add(coord[0] - 2, coord[1]);

                    if (!board.IsCaseEmpty(coord[0] - 2, coord[1]) &&
                        board.GetCaseAtPos(coord[0] - 2, coord[1]).PieceBoard.Color == Color.Black)
                        availablePos.Add(coord[0] - 2, coord[1]);
                }
            }
            else // If Color.Black
            {
                if (board.IsCaseEmpty(coord[0] + 1, coord[1]))
                    availablePos.Add(coord[0] + 1, coord[1]);

                if (!board.IsCaseEmpty(coord[0] + 1, coord[1]) &&
                    board.GetCaseAtPos(coord[0] + 1, coord[1]).PieceBoard.Color == Color.White)
                    availablePos.Add(coord[0] + 1, coord[1]);

                if (this.IsInitialPos) // + 2 || Ennemy piece at + 2
                {
                    if (board.IsCaseEmpty(coord[0] + 2, coord[1]))
                        availablePos.Add(coord[0] + 2, coord[1]);

                    if (!board.IsCaseEmpty(coord[0] + 2, coord[1]) &&
                        board.GetCaseAtPos(coord[0] + 2, coord[1]).PieceBoard.Color == Color.White)
                        availablePos.Add(coord[0] + 2, coord[1]);
                }
            }

            if (ContainsKeyValue(availablePos, desiredCoord[0], desiredCoord[1]))
            {
                Piece tmpPiece = board.GetCaseAtPos(coord[0], coord[1]).PieceBoard;
                board.Board[coord[0], coord[1]].PieceBoard = new EmptyPiece();
                board.Board[desiredCoord[0], desiredCoord[1]].PieceBoard = tmpPiece;
                return board;
            }
            return null;
        }
    }
}
