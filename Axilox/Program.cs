using System;
using GameLogic;

namespace Axilox
{
    class Program
    {
        static void Main(string[] args)
        {

            move mymove = new move();
            move computermove = new move();
            
            int[,] gameBoard = new int[9, 9];
            string myDirection = "h";
            string compDirection = "v";
            
            int round = 1;
            //int oldNumber = 1;

            mymove.OldNumber = 1;
            mymove.MyPoints = 0;

            computermove.CompChoice = 1;
            computermove.OldNumber = 1;
            computermove.CompPoints = 0;

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

            //game

            do
            {
                if (computermove.Endcheck1(compDirection, gameBoard) == 0||mymove.Endcheck1(myDirection,gameBoard)==0)
                {
                    if (mymove.MyPoints > computermove.CompPoints)
                    {
                        Console.WriteLine("you won");
                    }
                    else
                    {
                        Console.WriteLine("2nd place");
                    }

                    Console.WriteLine("end of the game. your points: {0}, computer points: {1}", mymove.MyPoints, computermove.CompPoints);
                    break;
                }                


                if (round % 2 == 1)
                {
                    Console.Clear();
                    
                    board.ShowBoard(gameBoard);
                    Console.WriteLine("computer chosed:{0}", computermove.OldNumber);
                    PrintGameMenu(myDirection, mymove.OldNumber);



                    mymove.MyMove(myDirection, gameBoard);
                   

                    Console.WriteLine("koniec rundy: {0}", round);
                    Console.WriteLine("{0}", mymove.OldNumber);
                    computermove.OldNumber = mymove.OldNumber;
                    
                    round++;
                }
                else
                {
                    Console.Clear();
                    board.ShowBoard(gameBoard);
                    
                    Console.Write("computer chooses: " );
                    System.Threading.Thread.Sleep(2000);

                    computermove.CompMove(compDirection, gameBoard);

                    Console.WriteLine("{0}", computermove.OldNumber);
                    mymove.OldNumber = computermove.OldNumber;
                    round++;
                    System.Threading.Thread.Sleep(5000);
                }
            } 
            while (true);
        }


        //MENU

       
        private static void PrintMenu()
        {
            Console.WriteLine("Avaible options: ");
            Console.WriteLine("0 - shut down");
            Console.WriteLine("1 - start game");
            // ...
            Console.Write("Choose action: ");
        }

        private static void PrintGameMenu(string direction, int oldNumber)
        {
            
            if (direction == "h")
            {
                Console.WriteLine("1-8 - choose row from column: {0}", oldNumber);//
            }
            else
            {
                Console.WriteLine("1-8 - choose column from row: {0}", oldNumber);//
            }
            // ...
            Console.Write("Choose: ");
        }

    }
}
