using System;
using System.Collections.Generic;
using System.Text;

namespace ChessNet.Pieces
{
    class Knight : Piece
    {
        public override Player Owner
        {
            get; set;
        }

        public Knight() : this(Player.None) { }

        public Knight(Player owner)
        {
            Owner = owner;
        }
    }
}
