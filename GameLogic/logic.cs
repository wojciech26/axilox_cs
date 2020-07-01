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

        public int MyPoints { get; private set; }
        public int CompPoints { get; private set; }

        private int NewNumber { get; set; }
        private int OldNumber { get; set; }
        public int CompChoice { get; set; }
        public string MyDirection { get; set; }

        public int MyMove(int oldNumber, string myDirection, int[,] board)
        {
            int myChoice = int.Parse(Console.ReadLine());

            if (myDirection == "h")
            {
                MyPoints += board[myChoice, OldNumber];
                board[myChoice, OldNumber] = 0;
                OldNumber = myChoice;

                return MyPoints;
            }
            else
            {
                MyPoints += board[OldNumber, myChoice];
                board[OldNumber, myChoice] = 0;
                OldNumber = myChoice;

                return MyPoints;

            }


        }

        public int CompMove(int OldNumber, string CompDirection, int[,] board, int CompChoice)
        {


            if (CompDirection == "h")
            {
                for (int i = 1; i <= 8; i++)
                {



                    //for (int j = 1; j <= 8; j++)
                    //{

                    //    if (board[i, OldNumber] - board[i, j] > CompChoice)
                    //        CompChoice = board[i, OldNumber];
                    //}
                }

                CompPoints = CompPoints + board[CompChoice, OldNumber];
                board[CompChoice, OldNumber] = 0;
                OldNumber = CompChoice;

                Console.WriteLine(CompChoice);
                Console.WriteLine(CompPoints);
                return OldNumber;
            }
            else
            {
                for (int j = 1; j <= 8; j++)
                {
                    for (int i = 1; i <= 8; i++)
                    {

                        if (board[OldNumber, j] - board[i, j] > CompChoice)
                            CompChoice = board[OldNumber, j];
                    }
                }

                CompPoints += board[CompChoice, OldNumber];
                board[CompChoice, OldNumber] = 0;
                OldNumber = CompChoice;

                Console.WriteLine(CompChoice);
                return OldNumber;
            }



        }





    }
}




