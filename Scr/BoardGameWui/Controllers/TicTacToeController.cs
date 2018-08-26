using BoardGameWui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameEngine;

namespace BoardGameWui.Controllers
{
    public class TicTacToeController : Controller
    {
        GameModelCopy GameModelCopy = new GameModelCopy();
        GameLogic gameLogic = new GameLogic();
        // GET: TicTacToe
        public ActionResult Index()
        {
            return View(GameModelCopy);
        }

        public ActionResult ButtonPress(string ButtonPressed)
        {
           
            //Active player chooses tile
            for (int i =0; i<GameModel.GameBoard.Count; i++)
            {
                if ( ButtonPressed == GameModel.GameBoard[i].Position.ToString())
                {
                    GameModel.GameBoard[i].BoardSymbol = GameModel.Player;
                }
            }
          
             //Drawcheck
            if (gameLogic.IsDraw(GameModelCopy.GameBoardCopy))
            {
                GameModel.Turn = "DRAW";
                GameModel.Player = null;
                return Redirect("~/TicTacToe/Index");
            }
            //wincheck
            if (gameLogic.WinCheck(GameModelCopy.GameBoardCopy))
            {
                GameModel.Turn = "Is THE WINNER";
                return Redirect("~/TicTacToe/Index");
            }
            if (GameModel.Player == "O") GameModel.Player = "X";
            else if (GameModel.Player == "X") GameModel.Player = "O";
            return Redirect("~/TicTacToe/Index");
        }
        public ActionResult ResetGame()
        {
            for (int i = 0; i<9; i++)
            {
                GameModel.GameBoard[i].BoardSymbol = null;
            }
            GameModel.Player = "X";
            GameModel.Turn = "'s turn to play";
            return Redirect("~/TicTacToe/Index");
        }

    }
}