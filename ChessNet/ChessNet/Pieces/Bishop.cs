using System;
using System.Collections.Generic;
using System.Text;

namespace ChessNet.Pieces
{
    class Bishop : Piece
    {
        public override Player Owner
        {
            get; set;
        }

        public Bishop() : this(Player.None) { }

        public Bishop(Player owner)
        {
            Owner = owner;
        }
    }
}
