using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameEngine;

namespace BoardGameWui.Models
{
    public static class GameModel
    {
        public static List<Board> GameBoard = new List<Board>
        {
            new Board{Position=0},
            new Board{Position=1},
            new Board{Position=2},
            new Board{Position=3},
            new Board{Position=4},
            new Board{Position=5},
            new Board{Position=6},
            new Board{Position=7},
            new Board{Position=8}
        };

        public static string Player = "X";
        public static string Turn = "'s turn to play";
    }
    public class GameModelCopy
    {
        public GameModelCopy()
        {
            GameBoardCopy = GameModel.GameBoard;
            Player = GameModel.Player;
            Turn = GameModel.Turn;
        }

        public List<Board> GameBoardCopy { get; set; }
        public string Player { get; set; }
        public string Turn { get; set; }




    }
}