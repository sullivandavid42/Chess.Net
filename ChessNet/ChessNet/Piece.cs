using System;
using System.Collections.Generic;
using System.Text;

namespace ChessNet
{
    public abstract class Piece
    { 
        public abstract Player Owner
        {
            get; set;
        }

       // public abstract bool ValidateMove();
    }
}
