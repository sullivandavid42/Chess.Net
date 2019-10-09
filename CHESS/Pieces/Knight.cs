using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHESS
{
    public class Knight : Piece
    {
        public Knight(Color color)
        {
            Color = color;
            SetColor();
        }

        protected override void SetColor()
        {
            if (this.Color == Color.White)
                Letter = 'N';
            else if (this.Color == Color.Black)
                Letter = 'n';
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
            Coord desCoord = new Coord { CoordY = desiredCoord[0], CoordX = desiredCoord[1] };
            List<Coord> pos = new List<Coord>();

            // SWW
            if (coord[0] + 1 == desiredCoord[0] && coord[1] - 2 == desiredCoord[1]) // & Check if move is legal
            {
                if (board.ContainsEnemyPiece(coord[0] + 1, coord[1] - 2, Color))
                    pos.Add(new Coord { CoordY = coord[0] + 1, CoordX = coord[1] - 2 });
            }

            // SW
            if (coord[0] + 2 == desiredCoord[0] && coord[1] - 1 == desiredCoord[1]) // & Check if move is legal
            {
                if (!board.ContainsEnemyPiece(coord[0] + 2, coord[1] - 1, Color))
                    pos.Add(new Coord { CoordY = coord[0] + 2, CoordX = coord[1] - 1 });
            }

            // NWW
            if (coord[0] - 1 == desiredCoord[0] && coord[1] - 2 == desiredCoord[1]) // & Check if move is legal
            {
                if (board.ContainsEnemyPiece(coord[0] - 1, coord[1] - 2, Color))
                    pos.Add(new Coord { CoordY = coord[0] - 1, CoordX = coord[1] - 2 });
            }

            // NW
            if (coord[0] - 2 == desiredCoord[0] && coord[1] - 1 == desiredCoord[1]) // & Check if move is legal
            {
                if (board.ContainsEnemyPiece(coord[0] - 2, coord[1] - 1, Color))
                    pos.Add(new Coord { CoordY = coord[0] - 2, CoordX = coord[1] - 1 });
            }

            // SEE
            if (coord[0] + 1 == desiredCoord[0] && coord[1] + 2 == desiredCoord[1]) // & Check if move is legal
            {
                if (board.ContainsEnemyPiece(coord[0] + 1, coord[1] + 2, Color))
                    pos.Add(new Coord { CoordY = coord[0] + 1, CoordX = coord[1] + 2 });
            }

            // SE
            if (coord[0] + 2 == desiredCoord[0] && coord[1] + 1 == desiredCoord[1]) // & Check if move is legal
            {
                if (board.ContainsEnemyPiece(coord[0] + 2, coord[1] + 1, Color))
                    pos.Add(new Coord { CoordY = coord[0] + 2, CoordX = coord[1] + 1 });
            }

            // NEE
            if (coord[0] - 1 == desiredCoord[0] && coord[1] + 2 == desiredCoord[1]) // & Check if move is legal
            {
                if (board.ContainsEnemyPiece(coord[0] - 1, coord[1] + 2, Color))
                    pos.Add(new Coord { CoordY = coord[0] - 1, CoordX = coord[1] + 2 });
            }

            // NE
            if (coord[0] - 2 == desiredCoord[0] && coord[1] + 1 == desiredCoord[1]) // & Check if move is legal
            {
                if (board.ContainsEnemyPiece(coord[0] - 2, coord[1] + 1, Color))
                    pos.Add(new Coord { CoordY = coord[0] - 2, CoordX = coord[1] + 1 });
            }

            if (ObjectContainsValue(pos, desCoord))
            {
                Piece tmpPiece = board.GetCaseAtPos(coord[0], coord[1]).PieceBoard;
                board.Board[coord[0], coord[1]].PieceBoard = new EmptyPiece();
                board.Board[desiredCoord[0], desiredCoord[1]].PieceBoard = tmpPiece;
                return board;
            }
            else
                return null;
        }
    }
}
