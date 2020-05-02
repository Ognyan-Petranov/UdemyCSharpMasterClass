using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Controller
    {
        public Controller()
        {
        }

        public void Play(Board board, Player one, Player two)
        {
            int counter = 0;

            while (true)
            {
                try
                {
                    Console.Write("Player one: Chose your field! ");
                    one.Play(board);
                    ApplyChanges(board);
                    counter++;
                    if (CheckForWinner(board))
                    {
                        one.IsWinner = true;
                        break;
                    }
                    if (counter == 9)
                    {
                        counter = 0;
                        break;
                    }
                    Console.Write("Player two: Chose your field! ");
                    two.Play(board);
                    ApplyChanges(board);
                    counter++;
                    if (CheckForWinner(board))
                    {
                        two.IsWinner = true;
                        break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message); ;
                }
            }
            if (one.IsWinner)
            {
                Console.WriteLine("We have a winner! Player One Won the game!");
            }
            else if (two.IsWinner)
            {
                Console.WriteLine("We have a winner! Player Two Won the game!");
            }
            else
            {
                Console.WriteLine("No winner!");
            }
        }

        public void ResetGame(Board board, Player one, Player two)
        {
            one.IsWinner = false;
            two.IsWinner = false;

            Console.Write("Press any key to continue!");
            Console.ReadKey();

            Console.Clear();
            board.PrepareBoard();
            board.DrawBoard();
            this.Play(board, one, two);

        }
        private void ApplyChanges(Board board)
        {
            Console.Clear();
            board.DrawBoard();
        }

        private bool CheckForWinner(Board board)
        {
            if (board.Layout[1, 1] == board.Layout[1, 5] && board.Layout[1, 1] == board.Layout[1, 9]
                        || board.Layout[4, 1] == board.Layout[4, 5] && board.Layout[4, 1] == board.Layout[4, 9]
                        || board.Layout[7, 1] == board.Layout[7, 5] && board.Layout[7, 1] == board.Layout[7, 9]
                        || board.Layout[1, 1] == board.Layout[4, 5] && board.Layout[1, 1] == board.Layout[7, 9]
                        || board.Layout[1, 9] == board.Layout[4, 5] && board.Layout[1, 9] == board.Layout[7, 1]
                        || board.Layout[1, 1] == board.Layout[4, 1] && board.Layout[1, 1] == board.Layout[7, 1]
                        || board.Layout[1, 5] == board.Layout[4, 5] && board.Layout[1, 5] == board.Layout[7, 5]
                        || board.Layout[1, 9] == board.Layout[4, 9] && board.Layout[1, 9] == board.Layout[7, 9])
            {
                return true;
            }
            return false;
        }
    }
}
