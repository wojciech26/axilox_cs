using System;
using GameLogic;

namespace Axilox
{
    class Program
    {
        static void Main(string[] args)
        {
            //myMove move = new myMove();
            int[,] gameBoard = new int[9, 9];
            string myDirection = "h";
            string compDirection = "v";
            //board.boardGeneration(gameBoard);

            PrintMenu();
            int action1 = int.Parse(Console.ReadLine());

           // if (action != 0 && action != 1) {
             //   Console.WriteLine("incorrect numbers destroyed world");      
            //}

            switch (action1)
            {
                case 0:
                    Console.WriteLine("Shutting down ...");
                    Environment.Exit(0);
                    break;
                case 1:

                    Console.WriteLine("choose your direction: v-vertical, h-horizontal");
                    myDirection = Console.ReadLine();

                    if (myDirection == "v")
                    {
                        compDirection = "h";
                    }
                    else
                    {
                        myDirection = "h";
                        compDirection = "v";
                    }

                board.boardGeneration(gameBoard);
                break;

            }


            int myPoints = 0;
            int compPoints = 0;
            int round = 1;
            int oldNumber = 0;
            int newNumber = 0;

            do
            {
                if (round % 2 == 1)
                {

                    board.ShowBoard(gameBoard);
                    PrintGameMenu(myDirection);

                    move mymove = new move();


                    mymove.MyMove(oldNumber, newNumber, myDirection);


                    //int action2 = int.Parse(Console.ReadLine());
                    //switch (action2)
                    //{
                    //    case 0:
                    //        Console.WriteLine("Shutting down ...");
                    //        Environment.Exit(0);
                    //        break;
                    //    case 1:
                    //    case 2:
                    //    case 3:
                    //    case 4:
                    //    case 5:
                    //    case 6:
                    //    case 7:
                    //    case 8:



                    //        Console.WriteLine("1");
                    //        break;

                    //}

                    round++;
                    Console.WriteLine("koniec rundy: ", round);

                }
                else
                {

                }
            } 
            while (true);
            


        }




        //public static int[,] boardGeneration(int[,] board)
        //{
        //    Random rnd = new Random();
        //    int[,] gameBoard = board;


        //    for (int i = 0; i < 1; i++)
        //    {
        //        for (int j = 0; j < 9; j++)
        //        {
        //            gameBoard[i, j] = j;
        //        }
        //    }

        //    for (int j = 0; j < 1; j++)
        //    {
        //        for (int i = 0; i < 9; i++)
        //        {
        //            gameBoard[i, j] = i;
        //        }
        //    }


        //    for (int i = 1; i < 9; i++)
        //    {
        //        for (int j = 1; j < 9; j++)
        //        {
        //            gameBoard[i, j] = rnd.Next(1, 9);
        //            //Console.Write(" {0} ", gameBoard[i, j]);
        //        }
        //        //Console.WriteLine();
        //    }

        //    return gameBoard;
        //}

        //public static void ShowBoard(int[,] board)
        //{
        //    int[,] gameBoard = board;

        //    for (int i = 0; i < 9; i++)
        //    {
        //        for (int j = 0; j < 9; j++)
        //        {
        //            if (i == 0 || j == 0) { Console.ForegroundColor = ConsoleColor.Green; }
        //            else
        //            {
        //                Console.ResetColor();
        //            }
        //            if(gameBoard[i,j] == 0)
        //            {
        //                Console.ForegroundColor = ConsoleColor.Black;
        //            }
        //            else
        //            {
        //                Console.ResetColor();
        //            }

        //            Console.Write(" {0} ", gameBoard[i, j]);
        //        }
        //        Console.WriteLine();
        //    }
        //}
        private static void PrintMenu()
        {
            Console.WriteLine("Avaible options: ");
            Console.WriteLine("0 - shut down");
            Console.WriteLine("1 - start game");
            // ...
            Console.Write("Choose action: ");
        }

        private static void PrintGameMenu(string direction)
        {
            Console.WriteLine("Avaible options: ");
            if (direction == "h")
            {
                Console.WriteLine("1-8 - choose number from row: ");
            }
            else
            {
                Console.WriteLine("1-8 - choose number from column: ");
            }
            // ...
            Console.Write("Choose: ");
        }

    }
}
