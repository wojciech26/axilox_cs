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
            //int myPoints = 0;
            //int compPoints = 0;
            int round = 1;
            //int oldNumber = 1;
            //int compChoice = 0;
            mymove.OldNumber = 1;
            mymove.MyPoints = 0;

            computermove.CompChoice = 1;
            computermove.OldNumber = 1;
            computermove.CompPoints = 0;


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
                    //move mymove = new move();
                    //move enemymove = new move();
                    break;

            }




            do
            {
                if (round % 2 == 1)
                {
                    Console.Clear();
                    board.ShowBoard(gameBoard);
                    PrintGameMenu(myDirection);

                    

                    mymove.MyMove(myDirection, gameBoard);
                   



                    
                    Console.WriteLine("koniec rundy: ", round);
                    Console.WriteLine("{0}", mymove.OldNumber);
                    round++;
                }
                else
                {
                    Console.Clear();
                    board.ShowBoard(gameBoard);


                    System.Threading.Thread.Sleep(2000);
                    Console.Write("computer chooses: " );

                    computermove.CompMove(compDirection, gameBoard);
                    System.Threading.Thread.Sleep(5000);

                    Console.WriteLine("koniec rundy: ", round);
                    Console.WriteLine("{0}", computermove.OldNumber);
                    round++;
                    System.Threading.Thread.Sleep(3000);
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
