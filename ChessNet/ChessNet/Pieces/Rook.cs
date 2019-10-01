using System;
using System.Collections.Generic;
using System.Text;

namespace ChessNet.Pieces
{
    class Rook : Piece
    {
        public override Player Owner
        {
            get; set;
        }

        public Rook() : this(Player.None) { }

        public Rook(Player owner)
        {
            Owner = owner;
        }
    }
}
