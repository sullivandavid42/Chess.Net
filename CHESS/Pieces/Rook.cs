using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHESS
{
    class Rook : Piece
    {
        public Rook(Color color)
        {
            Color = color;
            SetColor();
        }

        protected override void SetColor()
        {
            if (this.Color == Color.White)
                Letter = 'R';
            else if (this.Color == Color.Black)
                Letter = 'r';
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

        public override ChessBoard MovePiece(ChessBoard board, int[] coord, int[] desiredCoord)
        {
            Dictionary<int, int> availablePos = new Dictionary<int, int>();

            if (Color == Color.White)
            {
                if (coord[0] != desiredCoord[0]) // If move on row
                {
                    for (int i = coord[0]; i > desiredCoord[0]; i--)
                    {
                        int y = 1;
                        if (board.IsCaseEmpty(coord[0] - y, coord[1]))
                        {
                            availablePos.Add(coord[0] - y, coord[1]);
                            y++;
                        }
                        else if (board.ContainsEnemyPiece(coord[0] - y, coord[1], Color))
                        {
                            availablePos.Add(coord[0] - y, coord[1]);
                            break;
                        }
                        else
                            break;
                    }
                }
            }

            if (ContainsKeyValue(availablePos, desiredCoord[0], desiredCoord[1]))
            {
                Piece tmpPiece = board.GetCaseAtPos(coord[0], coord[1]).PieceBoard;
                board.Board[coord[0], coord[1]].PieceBoard = new EmptyPiece();
                board.Board[desiredCoord[0], desiredCoord[1]].PieceBoard = tmpPiece;
            }
            return board;
        }
    }
}
