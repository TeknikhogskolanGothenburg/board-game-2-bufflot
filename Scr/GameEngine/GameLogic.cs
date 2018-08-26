using System;
using System.Collections.Generic;
using System.Text;



namespace GameEngine
{


    public class Board
    {
        public int Position { get; set; }
        public string BoardSymbol { get; set; }
    }

    public class GameLogic
    {
        //drawcheck
        public bool IsDraw(List<Board> tiles)
        {
            int count = 0;
            for (int i = 0; i < 9; i++)
            {
                if (tiles[i].BoardSymbol != null)
                {
                    count++;
                }
            }
            if (count < 9)
            {
                return false;
            }
            else return true;
        }
        //wincheck metoder
        public bool WinCheck(List<Board> tiles)
        {
            
            return Diagonal(tiles) || Horizontal(tiles) || Vertical(tiles);
        }

        public bool Diagonal(List<Board> tiles)
        {
            if  (tiles[4].BoardSymbol == null)
            {
                return false;
            }
                else return (((tiles[0].BoardSymbol == tiles[4].BoardSymbol) && (tiles[0].BoardSymbol == tiles[8].BoardSymbol)))
                         || (((tiles[4].BoardSymbol == tiles[2].BoardSymbol) && (tiles[4].BoardSymbol == tiles[6].BoardSymbol)));

        }


        public bool Horizontal(List<Board> tiles)
        {
            if ((tiles[0].BoardSymbol != null && tiles[0].BoardSymbol == tiles[1].BoardSymbol) && (tiles[0].BoardSymbol == tiles[2].BoardSymbol))
            {
                return true;
            }

            else if ((tiles[3].BoardSymbol != null && tiles[3].BoardSymbol == tiles[4].BoardSymbol) && (tiles[3].BoardSymbol == tiles[5].BoardSymbol))
            {
                return true;
            }

            else if ((tiles[6].BoardSymbol != null && tiles[6].BoardSymbol == tiles[7].BoardSymbol) && (tiles[6].BoardSymbol == tiles[8].BoardSymbol))
            {
                return true;
            }
            else return false;
            
        }

        public bool Vertical(List<Board> tiles)
        {
            if ((tiles[0].BoardSymbol != null && tiles[0].BoardSymbol == tiles[3].BoardSymbol) && (tiles[0].BoardSymbol == tiles[6].BoardSymbol))
            {
                return true;
            }

            else if ((tiles[1].BoardSymbol != null && tiles[1].BoardSymbol == tiles[4].BoardSymbol) && (tiles[1].BoardSymbol == tiles[7].BoardSymbol))
            {
                return true;
            }

            else if ((tiles[2].BoardSymbol != null && tiles[2].BoardSymbol == tiles[5].BoardSymbol) && (tiles[2].BoardSymbol == tiles[8].BoardSymbol))
            {
                return true;
            }
            else return false;
        }
        // Snyggare wincheck kod!!
        //if ((tiles[0].BoardSymbol == null) && (tiles[1].BoardSymbol != null) && (tiles[2].BoardSymbol != null))
        //{
        //    return false;
        //}
        //    else return (((tiles[0].BoardSymbol == tiles[3].BoardSymbol) && (tiles[0].BoardSymbol == tiles[6].BoardSymbol)))
        //             || (((tiles[1].BoardSymbol == tiles[4].BoardSymbol) && (tiles[1].BoardSymbol == tiles[7].BoardSymbol)))
        //             || (((tiles[2].BoardSymbol == tiles[5].BoardSymbol) && (tiles[2].BoardSymbol == tiles[8].BoardSymbol)));


        //{

        //    public bool IsGameOver { get; private set; }

        //    public bool IsDraw { get; private set; }



        //    private readonly int[] field = new int[9];

        //    private int movesLeft = 9;

        //public TicTacToe()
        //{
        //    for (int i = 0; i < field.Length; i++)
        //    {
        //        field[i] = -1;
        //    }
        //}


    }
}
