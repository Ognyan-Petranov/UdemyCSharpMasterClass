using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Player
    {
        private string name;
        private string symbol;
        private bool isWinner;

        public Player(string name, string symbol)
        {
            this.Name = name;
            this.symbol = symbol;
        }

        public bool IsWinner { get => this.isWinner; set => isWinner = value; }
        
        public string Name
        {
            get => this.name;
            private set => this.name = value;
        }

        public void Play(Board board)
        {
            string input = Console.ReadLine();
            int switchArgument;

            if (int.TryParse(input, out switchArgument))
            {
                if (switchArgument >= 1 && switchArgument <= 9)
                {

                    switch (switchArgument)
                    {
                        case 1:
                            if (CheckSymbol(board.Layout[1, 1]))
                            {
                                throw new Exception("That cell has already been played! Enter new cell!");
                            }
                            board.Layout[1, 1] = this.symbol;
                            break;
                        case 2:
                            if (CheckSymbol(board.Layout[1, 5]))
                            {
                                throw new Exception("That cell has already been played! Enter new cell!");
                            }
                            board.Layout[1, 5] = this.symbol;
                            break;
                        case 3:
                            if (CheckSymbol(board.Layout[1, 9]))
                            {
                                throw new Exception("That cell has already been played! Enter new cell!");
                            }
                            board.Layout[1, 9] = this.symbol;
                            break;
                        case 4:
                            if (CheckSymbol(board.Layout[4, 1]))
                            {
                                throw new Exception("That cell has already been played! Enter new cell!");
                            }
                            board.Layout[4, 1] = this.symbol;
                            break;
                        case 5:
                            if (CheckSymbol(board.Layout[4, 5]))
                            {
                                throw new Exception("That cell has already been played! Enter new cell!");
                            }
                            board.Layout[4, 5] = this.symbol;
                            break;
                        case 6:
                            if (CheckSymbol(board.Layout[4, 9]))
                            {
                                throw new Exception("That cell has already been played! Enter new cell!");
                            }
                            board.Layout[4, 9] = this.symbol;
                            break;
                        case 7:
                            if (CheckSymbol(board.Layout[7, 1]))
                            {
                                throw new Exception("That cell has already been played! Enter new cell!");
                            }
                            board.Layout[7, 1] = this.symbol;
                            break;
                        case 8:
                            if (CheckSymbol(board.Layout[7, 5]))
                            {
                                throw new Exception("That cell has already been played! Enter new cell!");
                            }
                            board.Layout[7, 5] = this.symbol;
                            break;
                        case 9:
                            if (CheckSymbol(board.Layout[7, 9]))
                            {
                                throw new Exception("That cell has already been played! Enter new cell!");
                            }
                            board.Layout[7, 9] = this.symbol;
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                }
                else
                {
                    throw new Exception("Invalid input, please use numbers between 1 and 9!");
                }

            }
            else
            {
                throw new Exception("Invalid input, please use numbers between 1 and 9!");
            }
        }

        public bool CheckSymbol(string symbol)
        {
            return symbol == "X" || symbol == "O";
        }
    }
}
