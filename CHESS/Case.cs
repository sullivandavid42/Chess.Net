using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHESS
{
    public class Case
    {

        public Piece PieceBoard
        {
            get; set;
        }

        public int CoordX
        {
            get; set;
        }

        public int CoordY
        {
            get; set;
        }

        public Case(Piece piece, int x, int y)
        {
            PieceBoard = piece;
            CoordX = x;
            CoordY = y;
        }

        public Case(int x, int y)
        {
            PieceBoard = null;
            CoordX = x;
            CoordY = y;
        }

        public int[] XYCoords()
        {
            int[] xyCoord = new int[] { CoordX, CoordY };
            return xyCoord;
        }
    }
}
