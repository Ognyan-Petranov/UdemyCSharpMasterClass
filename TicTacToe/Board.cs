using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Board
    {
        string[,] layout;

        public Board()
        {
            this.layout = new string[9, 11];
        }

        public string[,] Layout { get => this.layout; set => this.layout = value; }

        public void PrepareBoard()
        {
            int counter = 1;

            for (int row = 0; row < this.layout.GetLength(0); row++)
            {
                for (int col = 0; col < this.layout.GetLength(1); col++)
                {

                    if (col == 3 || col == 7)
                    {
                        layout[row, col] = "|";
                    }
                    else if (row == 2 || row == 5)
                    {
                        layout[row, col] = "_";
                    }
                    else if ((row == 1 && col == 1) || (row == 1 && col == 5) || row == 1 && col == 9)
                    {
                        layout[row, col] = counter.ToString();
                        counter++;
                    }
                    else if ((row == 4 && col == 1) || (row == 4 && col == 5) || row == 4 && col == 9)
                    {
                        layout[row, col] = counter.ToString();
                        counter++;
                    }
                    else if ((row == 7 && col == 1) || (row == 7 && col == 5) || row == 7 && col == 9)
                    {
                        layout[row, col] = counter.ToString();
                        counter++;
                    }
                    else
                    {
                        layout[row, col] = " ";
                    }
                }
            }
        }

        public void DrawBoard()
        {
            for (int row = 0; row < this.layout.GetLength(0); row++)
            {
                for (int col = 0; col < this.layout.GetLength(1); col++)
                {
                    Console.Write(layout[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}
