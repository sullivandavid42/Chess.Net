using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHESS
{
    class Queen : Piece
    {
        public Queen(Color color)
        {
            Color = color;
            SetColor();
        }

        protected override void SetColor()
        {
            if (this.Color == Color.White)
                Letter = 'Q';
            else if (this.Color == Color.Black)
                Letter = 'q';
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
            return board;
        }
    }
}
