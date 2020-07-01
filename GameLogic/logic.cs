using System;

namespace GameLogic
{

    public class board
    {

        public board()
        {

        }

        public static int[,] boardGeneration(int[,] dashboard)
        {
            Random rnd = new Random();
            int[,] gameBoard = dashboard;


            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    gameBoard[i, j] = j;
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
                    if (gameBoard[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                    }


                    Console.Write(" {0} ", gameBoard[i, j]);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }


    }
    public class move
    {


        public move()
        {

        }

        public int myPoints { get; private set; }
        private int newNumber { get; set; }
        private int oldNumber { get; set; }

        public int MyMove(int oldNumber, int newNumber, string myDirection)
        {
            if (myDirection == "h")
            {

                int action2 = int.Parse(Console.ReadLine());
                switch (action2)
                {

                    case 1:

                        myPoints = 5;
                        Console.WriteLine("1");
                        return 0;
                    default:
                        return 0;
                }



            }
            else
            {
                return 0;
            }


        }




    }





}



