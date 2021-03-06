﻿using System;
using System.Collections.Generic;


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
                }
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


        public int MyPoints { get; set; }
        public int CompPoints { get; set; }

        public int OldNumber { get; set; }
        public int CompChoice { get; set; }

        public bool check { get; set; }

        public void MyMove(string myDirection, int[,] board)
        {
            check = true;
            while (check)
            {
                try
                {
                    int myChoice = int.Parse(Console.ReadLine());
                    if (myChoice < 1 || myChoice > 8)
                    {                       
                        throw new ArgumentException();                       
                    }
                    else
                    {
                        if (myDirection == "h")
                        {
                            MyPoints += board[myChoice, OldNumber];
                            board[myChoice, OldNumber] = 0;
                            OldNumber = myChoice;
                            check = false;                            
                        }
                        else
                        {
                            MyPoints += board[OldNumber, myChoice];
                            board[OldNumber, myChoice] = 0;
                            OldNumber = myChoice;
                            check = false;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("error, use a number between 1 and 8");
                }
            }
        }

        public int CompMove(string CompDirection, int[,] board)
        {
            int pointChoice = 0;
            CompChoice = 0;

            if (CompDirection == "h")
            {
                
                for (int i = 1; i <= 8; i++)
                {

                    for (int j = 1; j <= 8; j++)
                    {
                        if (board[i, OldNumber] != 0) {
                        
                            if (board[i, OldNumber] - board[i, j] > pointChoice)
                            {
                                pointChoice = board[i, OldNumber];
                                CompChoice = i;
                            }
                        }
                    }
                }

                CompPoints = CompPoints + board[CompChoice, OldNumber];
                board[CompChoice, OldNumber] = 0;
                OldNumber = CompChoice;

                return OldNumber;
            }
            else
            {
                for (int j = 1; j <= 8; j++)
                {
                    for (int i = 1; i <= 8; i++)
                    {
                        if (board[OldNumber, j] != 0) { 
              
                            if (board[OldNumber, j] - board[i, j] > CompChoice)
                            {
                                pointChoice = board[OldNumber, j];
                                CompChoice = j;
                            }
                        }
                    }
                }
                CompPoints += board[OldNumber, CompChoice];
                board[OldNumber, CompChoice] = 0;
                OldNumber = CompChoice;

                Console.WriteLine(CompChoice);
                return OldNumber;
            }
        }


        public int Endcheck1(string Direction, int[,] board)
        {
            int flag = 0;

            if (Direction == "h")
            {
                for (int i = 1; i <= 8; i++)
                {

                    if (board[i, OldNumber] != 0)
                    {
                        flag = 1;
                    }
                    else
                    {

                    }
                }
                return flag;
            }
            else
            {
                for (int j = 1; j <= 8; j++)
                {
                    if (board[OldNumber, j] != 0)
                    {
                        flag = 1;
                    }
                    else
                    {
                        
                    }
                }
                return flag;
            }
        }
    }
}







