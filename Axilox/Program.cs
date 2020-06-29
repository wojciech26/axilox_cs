using System;

namespace Axilox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] gameBoard = new int[8, 8];
            boardGeneration(gameBoard);
            ShowBoard(gameBoard);
        }




        public static int[,] boardGeneration(int[,] board)
        {
            Random rnd = new Random();
            int[,] gameBoard = board;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {          
                    gameBoard[i, j] = rnd.Next(1, 9);
                    Console.Write(" {0} ", gameBoard[i, j]);
                }
                Console.WriteLine();
            }

            return gameBoard;
        }

        public static void ShowBoard(int[,] board)
        {
            int[,] gameBoard = board;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(" {0} ", gameBoard[i, j]);
                }
                Console.WriteLine();
            }
        }


    }
}