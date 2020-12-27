using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGames.Models.Tetris
{
    public class Tetromino
    {
        public readonly int[][,] I = new int[4][,]
        {
            new int[,] {
                            {0, 0, 0, 0},
                            {1, 1, 1, 1},
                            {0, 0, 0, 0},
                            {0, 0, 0, 0}
                       },
            new int[,] {
                            { 0, 0, 1, 0},
                            { 0, 0, 1, 0},
                            { 0, 0, 1, 0},
                            { 0, 0, 1, 0}
                       },
            new int[,] {
                            { 0, 0, 0, 0},
                            { 0, 0, 0, 0},
                            { 1, 1, 1, 1},
                            { 0, 0, 0, 0}
                       },
            new int[,]{
                            { 0, 1, 0, 0},
                            { 0, 1, 0, 0},
                            { 0, 1, 0, 0},
                            { 0, 1, 0, 0}
                      }
        };
        
        public readonly int[][,] J = new int[4][,]
        {
            new int[,] {
                            { 1, 0, 0},
                            { 1, 1, 1},
                            { 0, 0, 0}
                       },
            new int[,] {
                            { 0, 1, 1 },
                            { 0, 1, 0 },
                            { 0, 1, 0 }
                       },
            new int[,] {
                            { 0, 0, 0 },
                            { 1, 1, 1 },
                            { 0, 0, 1 }
                       },
            new int[,]{
                            { 0, 1, 0 },
                            { 0, 1, 0 },
                            { 1, 1, 0 }
                      }
        };
        
        public readonly int[][,] L = new int[4][,]
        {
            new int[,] {
                            { 0, 0, 1},
                            { 1, 1, 1},
                            { 0, 0, 0}
                   },
            new int[,] {
                            { 0, 1, 0 },
                            { 0, 1, 0 },
                            { 0, 1, 1 }
                   },
            new int[,] {
                            { 0, 0, 0 },
                            { 1, 1, 1 },
                            { 1, 0, 0 }
                   },
            new int[,] {
                            { 1, 1, 0 },
                            { 0, 1, 0 },
                            { 0, 1, 0 }
                       }
        };
        
        public readonly int[][,] O = new int[1][,]
        {
            new int[,] {
                            { 0, 0, 0, 0 },
                            { 0, 1, 1, 0 },
                            { 0, 1, 1, 0 },
                            { 0, 0, 0, 0 }
                       }
        };
        
        public readonly int[][,] S = new int[4][,]
        {
            new int[,] {
                            { 0, 1, 1},
                            { 1, 1, 0},
                            { 0, 0, 0}
                   },
            new int[,] {
                            { 0, 1, 0 },
                            { 0, 1, 1 },
                            { 0, 0, 1 }
                   },
            new int[,] {
                            { 0, 0, 0 },
                            { 0, 1, 1 },
                            { 1, 1, 0 }
                   },
            new int[,] {
                            { 1, 0, 0 },
                            { 1, 1, 0 },
                            { 0, 1, 0 }
                       }
        };
        
        public readonly int[][,] T = new int[4][,]
        {
            new int[,] {
                            { 0, 1, 0},
                            { 1, 1, 1},
                            { 0, 0, 0}
                   },
            new int[,] {
                            { 0, 1, 0 },
                            { 0, 1, 1 },
                            { 0, 1, 0 }
                   },
            new int[,] {
                            { 0, 0, 0 },
                            { 1, 1, 1 },
                            { 0, 1, 0 }
                   },
            new int[,] {
                            { 0, 1, 0 },
                            { 1, 1, 0 },
                            { 0, 1, 0 }
                       }
        };
        
        public readonly int[][,] Z = new int[4][,]
        {
            new int[,] {
                            { 1, 1, 0},
                            { 0, 1, 1},
                            { 0, 0, 0}
                   },
            new int[,] {
                            { 0, 0, 1 },
                            { 0, 1, 1 },
                            { 0, 1, 0 }
                   },
            new int[,] {
                            { 0, 0, 0 },
                            { 1, 1, 0 },
                            { 0, 1, 1 }
                   },
            new int[,] {
                            { 0, 1, 0 },
                            { 1, 1, 0 },
                            { 1, 0, 0 }
                       }
        };

       

        public Tetromino()
        {
           
        }

    }
}

