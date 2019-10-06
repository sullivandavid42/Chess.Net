using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHESS
{
    public abstract class Piece
    {

        public Piece()
        {
            Letter = 'o';
        }

        public abstract char Letter
        {
            get;
            set;
        }

        protected abstract void SetColor();

        public abstract Color Color
        {
            get;
            set;
        }

        public abstract ChessBoard MovePiece(ChessBoard board, int[] coord, int[] desiredCoord);

        public bool ContainsKeyValue(Dictionary<int, int> dictionary, int expectedKey, int expectedValue)
        {
            return dictionary.TryGetValue(expectedKey, out int actualValue) &&
                   actualValue == expectedValue;
        }

    }
}
