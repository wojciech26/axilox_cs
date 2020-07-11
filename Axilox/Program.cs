using System;
using System.Collections.Generic;
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

            mymove.OldNumber = 1;
            mymove.MyPoints = 0;

            computermove.CompChoice = 1;
            computermove.OldNumber = 1;
            computermove.CompPoints = 0;

            bool keepChecking = true;
            
            
            
            while (true)
            {


                while (keepChecking)
                {
                    try
                    {
                        PrintMenu();

                        int action1 = int.Parse(Console.ReadLine());


                        if (action1 < 0 || action1 > 1)
                        {
                            throw new ArgumentException();
                        }
                        else
                        {

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
                                        keepChecking = false;
                                        board.boardGeneration(gameBoard);
                                        break;
                                    }
                                    else if (myDirection == "h")
                                    {
                                        compDirection = "v";
                                        keepChecking = false;
                                        board.boardGeneration(gameBoard);
                                    }
                                    else
                                    {
                                        throw new ArgumentException();

                                    }


                                    break;



                            }
                        }
                    }

                    catch (Exception)
                    {
                        Console.WriteLine("error. use number 0 or 1 and then use letter h or v");
                        continue;
                    }
                }

                //game

                do
                {
                    if (computermove.Endcheck1(compDirection, gameBoard) == 0 || mymove.Endcheck1(myDirection, gameBoard) == 0)
                    {
                        Console.WriteLine("end of the game. your points: {0}, computer points: {1}", mymove.MyPoints, computermove.CompPoints);

                        if (mymove.MyPoints > computermove.CompPoints)
                        {
                            Console.WriteLine("you won!");
                            


                        }
                        else
                        {
                            Console.WriteLine("2nd place");

                        }


                        break;
                    }


                    if (round % 2 == 1)
                    {
                        Console.Clear();

                        board.ShowBoard(gameBoard);
                        Console.WriteLine("your points: {0}, computer points: {1}", mymove.MyPoints, computermove.CompPoints);
                        Console.WriteLine("computer chosed: {0}", computermove.OldNumber);
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
                        Console.WriteLine("your points: {0}, computer points: {1}", mymove.MyPoints, computermove.CompPoints);
                        Console.Write("computer chooses: ");
                        System.Threading.Thread.Sleep(1000);

                        computermove.CompMove(compDirection, gameBoard);

                        Console.WriteLine("{0}", computermove.OldNumber);
                        mymove.OldNumber = computermove.OldNumber;
                        round++;
                        System.Threading.Thread.Sleep(3000);
                    }
                }
                while (true);
            }
        }


        //MENU

       
        private static void PrintMenu()
        {
            Console.WriteLine("Rules:");            
            Console.WriteLine("Pick a direction");
            Console.WriteLine("then pick number of column or row which you want till no options are available in the round");
            Console.WriteLine("if you choose coordinates already taken you will get 0 points.");
            Console.WriteLine("computer is not stupid. he will not do that");
            Console.WriteLine("Good Luck");
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
