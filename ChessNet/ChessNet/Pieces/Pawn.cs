using System;
using System.Collections.Generic;
using System.Text;

namespace ChessNet.Pieces
{
    class Pawn : Piece
    {
        public override Player Owner
        {
            get; set;
        }

        public Pawn() : this(Player.None) { }

        public Pawn(Player owner)
        {
            Owner = owner;
        }
    }
}
