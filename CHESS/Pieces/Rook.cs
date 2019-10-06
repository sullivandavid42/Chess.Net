﻿using System;
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
            return board;
        }
    }
}