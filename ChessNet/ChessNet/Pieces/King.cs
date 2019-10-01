using System;
using System.Collections.Generic;
using System.Text;

namespace ChessNet.Pieces
{
    class King : Piece
    {
        public override Player Owner
        {
            get; set;
        }

        public King() : this(Player.None) { }

        public King(Player owner)
        {
            Owner = owner;
        }
    }
}
