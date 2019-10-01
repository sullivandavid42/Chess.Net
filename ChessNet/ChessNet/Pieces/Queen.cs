using System;
using System.Collections.Generic;
using System.Text;

namespace ChessNet.Pieces
{
    class Queen : Piece
    {
        public override Player Owner
        {
            get; set;
        }

        public Queen() : this(Player.None) { }

        public Queen(Player owner)
        {
            Owner = owner;
        }
    }
}
