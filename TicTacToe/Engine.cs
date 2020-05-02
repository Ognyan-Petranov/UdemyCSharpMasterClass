using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Engine
    {
        Player firstPlayer;
        Player secondPlayer;
        Board playBoard;

        public Engine()
        {
            firstPlayer = new Player("Player One", "O");
            secondPlayer = new Player("Player Two", "X");
            playBoard = new Board();
        }

        public void Run()
        {
            while (true)
            {
                playBoard.PrepareBoard();
                playBoard.DrawBoard();

                Controller controller = new Controller();
                controller.Play(this.playBoard, this.firstPlayer, this.secondPlayer);
                controller.ResetGame(this.playBoard, this.firstPlayer, this.secondPlayer);
            }
        }
    }
}
