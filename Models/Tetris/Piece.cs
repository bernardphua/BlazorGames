using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGames.Models.Tetris
{
    public class Piece
    {
        public int[][,] TetrominoPiece { get; set; }
        public string Color { get; set; }
        public int TetrominoPieceN { get;  set; }
        public int[,] ActiveTetromino { get; set; }
        public int x {get; set;}
        public int y {get; set;}

        public Piece(int[][,] tetromino, string color)
        {
            TetrominoPiece = tetromino;
            Color = color;

            TetrominoPieceN = 0;
            ActiveTetromino = TetrominoPiece[TetrominoPieceN];

            x = 3;
            y = -2;
        }
    }
}
