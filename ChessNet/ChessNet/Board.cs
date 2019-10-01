using System;
using System.Collections.Generic;
using System.Text;

namespace ChessNet
{
    class Board
    {
        private Chessboard chessboard;

        public Board()
        {

        }

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
