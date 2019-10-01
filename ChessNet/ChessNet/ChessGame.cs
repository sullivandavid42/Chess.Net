using System;
using System.Collections.Generic;

namespace ChessNet
{
    public class ChessGame
    {
        bool _isDrawn = false;
        
        public Player GameTurn
        {
            get;
            protected set;
        }

        public ChessGame()
        {
            GameTurn = Player.White;

            Piece kw = pieceMapping['K'];
            Piece kb = pieceMapping['k'];
            Piece qw = pieceMapping['Q'];
            Piece qb = pieceMapping['q'];
            Piece rw = pieceMapping['R'];
            Piece rb = pieceMapping['r'];
            Piece nw = pieceMapping['N'];
            Piece nb = pieceMapping['n'];
            Piece bw = pieceMapping['B'];
            Piece bb = pieceMapping['b'];
            Piece pw = pieceMapping['P'];
            Piece pb = pieceMapping['p'];
            Piece o = null;

            Board = new Piece[8][]
            {
                new[] { rb, nb, bb, qb, kb, bb, nb, rb },
                new[] { pb, pb, pb, pb, pb, pb, pb, pb },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { pw, pw, pw, pw, pw, pw, pw, pw },
                new[] { rw, nw, bw, qw, kw, bw, nw, rw }
            };
        }

        protected Piece[][] Board;

        private Dictionary<char, Piece> pieceMapping = new Dictionary<char, Piece>()
        {
            { 'K', new Pieces.King(Player.White) },
            { 'k', new Pieces.King(Player.Black) },
            { 'Q', new Pieces.Queen(Player.White) },
            { 'q', new Pieces.Queen(Player.Black) },
            { 'R', new Pieces.Rook(Player.White) },
            { 'r', new Pieces.Rook(Player.Black) },
            { 'B', new Pieces.Bishop(Player.White) },
            { 'b', new Pieces.Bishop(Player.Black) },
            { 'N', new Pieces.Knight(Player.White) },
            { 'n', new Pieces.Knight(Player.Black) },
            { 'P', new Pieces.Pawn(Player.White) },
            { 'p', new Pieces.Pawn(Player.Black) },
        };
    }
}
