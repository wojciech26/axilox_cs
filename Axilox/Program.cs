using System;

namespace Axilox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] gameBoard = new int[9, 9];
            boardGeneration(gameBoard);
            ShowBoard(gameBoard);
        }




        public static int[,] boardGeneration(int[,] board)
        {
            Random rnd = new Random();
            int[,] gameBoard = board;

            
            for ( int i = 0;i<1;i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    gameBoard[i,j] = j;
                }
            }

            for (int j = 0; j < 1; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    gameBoard[i, j] = i;
                }
            }


            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {          
                    gameBoard[i, j] = rnd.Next(1, 9);
                    //Console.Write(" {0} ", gameBoard[i, j]);
                }
                //Console.WriteLine();
            }

            return gameBoard;
        }

        public static void ShowBoard(int[,] board)
        {
            int[,] gameBoard = board;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (i == 0 || j == 0) { Console.ForegroundColor = ConsoleColor.Green; }
                    else
                    {
                        Console.ResetColor();
                    }
                    Console.Write(" {0} ", gameBoard[i, j]);
                }
                Console.WriteLine();
            }
        }
        private static void PrintMenu()
        {
            Console.WriteLine("Avaible options: ");
            Console.WriteLine("s - shut down");
            Console.WriteLine("p - print GameBoard");
            Console.WriteLine("1-8 - pick a number");
            // ...
            Console.Write("Choose action: ");
        }

    }
}