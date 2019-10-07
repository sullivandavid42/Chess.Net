using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHESS
{
    public class Rook : Piece
    {
        public Rook(Color color)
        {
            Color = color;
            SetColor();
        }

        protected override void SetColor()
        {
            if (this.Color == Color.White)
                Letter = 'R';
            else if (this.Color == Color.Black)
                Letter = 'r';
            else
                Letter = 'o';
        }

        public override char Letter
        {
            get;
            set;
        }

        public override Color Color
        {
            get;
            set;
        }
            
        public override ChessBoard MovePiece(ChessBoard board, int[] coord, int[] desiredCoord)
        {
            Dictionary<int, int> availablePos = new Dictionary<int, int>();

            Coord desCoord = new Coord { CoordX = desiredCoord[0], CoordY = desiredCoord[1] };
            List<Coord> pos = new List<Coord>();

            if (Color == Color.White)
            {
                if (coord[0] != desiredCoord[0]) // If move on row
                {
                    if (coord[0] > desiredCoord[0]) // If rook below target
                    {
                        int y = 1;
                        for (int i = coord[0]; i > desiredCoord[0]; i--)
                        {
                            if (board.IsCaseEmpty(coord[0] - y, coord[1]))
                            {
                                pos.Add(new Coord { CoordX = coord[0] - y, CoordY = coord[1] });
                                y++;
                            }
                            else if (board.ContainsEnemyPiece(coord[0] - y, coord[1], Color))
                            {
                                pos.Add(new Coord { CoordX = coord[0] - y, CoordY = coord[1] });
                                break;
                            }
                            else break;
                        }
                    }
                    else // Rook upper target
                    {
                        int y = 1;
                        for (int i = coord[0]; i < desiredCoord[0]; i++)
                        {
                            if (board.IsCaseEmpty(coord[0] + y, coord[1]))
                            {
                                pos.Add(new Coord { CoordX = coord[0] + y, CoordY = coord[1] });
                                y++;
                            }
                            else if (board.ContainsEnemyPiece(coord[0] + y, coord[1], Color))
                            {
                                pos.Add(new Coord { CoordX = coord[0] + y, CoordY = coord[1] });
                                break;
                            }
                            else
                                break;
                        }
                    }
                }
                else if (coord[1] != desiredCoord[1])
                {
                    if (coord[1] < desiredCoord[1]) // move on X right
                    {
                        int y = 1;
                        for (int i = coord[1]; i < desiredCoord[1]; i++)
                        {
                            if (board.IsCaseEmpty(coord[0], coord[1] + y))
                            {
                                pos.Add(new Coord { CoordX = coord[0], CoordY = coord[1] + y });
                                y++;
                            }
                            else if (board.ContainsEnemyPiece(coord[0], coord[1] + y, Color))
                            {
                                pos.Add(new Coord { CoordX = coord[0], CoordY = coord[1] + y });
                                break;
                            }
                            else break;
                        }
                    } else // move on X left
                    {
                        int y = 1;
                        for (int i = coord[1]; i > desiredCoord[1]; i--)
                        {
                            if (board.IsCaseEmpty(coord[0], coord[1] - y))
                            {
                                pos.Add(new Coord { CoordX = coord[0], CoordY = coord[1] - y });
                                y++;
                            }
                            else if (board.ContainsEnemyPiece(coord[0], coord[1] - y, Color))
                            {
                                pos.Add(new Coord { CoordX = coord[0], CoordY = coord[1] - y });
                                break;
                            }
                            else break;
                        }
                    }
                }
            }
            else // Color.Black
            {
                if (coord[0] != desiredCoord[0]) // If move on row
                {
                    if (coord[0] < desiredCoord[0])
                    {
                        int y = 1;
                        for (int i = coord[0]; i < desiredCoord[0]; i++)
                        {
                            if (board.IsCaseEmpty(coord[0] + y, coord[1]))
                            {
                                pos.Add(new Coord { CoordX = coord[0] + y, CoordY = coord[1] });
                                y++;
                            }
                            else if (board.ContainsEnemyPiece(coord[0] + y, coord[1], Color))
                            {
                                pos.Add(new Coord { CoordX = coord[0] + y, CoordY = coord[1] });
                                break;
                            }
                            else
                                break;
                        }
                    }
                    else
                    {
                        int y = 1;
                        for (int i = coord[0]; i > desiredCoord[0]; i--)
                        {
                            if (board.IsCaseEmpty(coord[0] - y, coord[1])) {
                                pos.Add(new Coord { CoordX = coord[0] - y, CoordY = coord[1] });
                                y++;
                            }
                            else if (board.ContainsEnemyPiece(coord[0] - y, coord[1], Color))
                            {
                                pos.Add(new Coord { CoordX = coord[0] - y, CoordY = coord[1] });
                                break;
                            }
                            else
                                break;
                        }
                    }
                }
                else if (coord[1] != desiredCoord[1])
                {
                    if (coord[1] < desiredCoord[1]) // move on X right
                    {
                        int y = 1;
                        for (int i = coord[1]; i < desiredCoord[1]; i++)
                        {
                            if (board.IsCaseEmpty(coord[0], coord[1] + y))
                            {
                                pos.Add(new Coord { CoordX = coord[0], CoordY = coord[1] + y });
                                y++;
                            }
                            else if (board.ContainsEnemyPiece(coord[0], coord[1] + y, Color))
                            { 
                                pos.Add(new Coord { CoordX = coord[0], CoordY = coord[1] + y });
                                break;
                            }
                            else break;
                        }
                    }
                    else // move on X left
                    {
                        int y = 1;
                        for (int i = coord[1]; i > desiredCoord[1]; i--)
                        {
                            if (board.IsCaseEmpty(coord[0], coord[1] - y))
                            {
                                pos.Add(new Coord { CoordX = coord[0], CoordY = coord[1] - y});
                                y++;
                            }
                            else if (board.ContainsEnemyPiece(coord[0], coord[1] - y, Color))
                            {
                                pos.Add(new Coord { CoordX = coord[0], CoordY = coord[1] - y });
                                break;
                            }
                            else break;
                        }
                    }
                }
            }

            if (ObjectContainsValue(pos, desCoord))
            {
                Piece tmpPiece = board.GetCaseAtPos(coord[0], coord[1]).PieceBoard;
                board.Board[coord[0], coord[1]].PieceBoard = new EmptyPiece();
                board.Board[desiredCoord[0], desiredCoord[1]].PieceBoard = tmpPiece;
                return board;
            }
            else
                return null;
        }
    }
}
