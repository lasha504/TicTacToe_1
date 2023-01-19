﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_1
{
    internal class GameResults
    {
        //public static int[] intArray = new int[3];

        public static void GetScore()
        {            
            int step = CheckWinner();
            switch (step)
            {
                case 1:
                    Console.WriteLine("You WON!");
                    break;
                    
                case 0:
                    Console.WriteLine("Draw");
                    break;
                default:
                    Console.WriteLine("Something goes wrong");
                    break;
            }
            
            //Console.WriteLine(" \t\t\t  _______      _______     ________");
            //Console.WriteLine(" \t\t\t |       |    |       |   |        |");
            //Console.WriteLine(" \t\t\t |   {0}   |    |   {1}   |   |    {2}   |", intArray[0], intArray[1], intArray[2]);
            //Console.WriteLine(" \t\t\t |_______|    |_______|   |________|");

            //Console.Write("\t\t\t  {0} (X)\t", Intro.GetPlayerName());
            //Console.Write(" TIE\t");
            //Console.Write(" COMPUTER (0) \n\n\n");
        }

        public static int CheckWinner()
        {
            if (TicTacToe.fieldArray[0] == TicTacToe.fieldArray[1] && TicTacToe.fieldArray[1] == TicTacToe.fieldArray[2])
            {
                return 1;
            }
            else if (TicTacToe.fieldArray[3] == TicTacToe.fieldArray[4] && TicTacToe.fieldArray[4] == TicTacToe.fieldArray[5])
            {
                return 1;
            }
            else if (TicTacToe.fieldArray[6] == TicTacToe.fieldArray[7] && TicTacToe.fieldArray[7] == TicTacToe.fieldArray[8])
            {
                return 1;
            }
            else if (TicTacToe.fieldArray[0] == TicTacToe.fieldArray[4] && TicTacToe.fieldArray[4] == TicTacToe.fieldArray[8])
            {
                return 1;
            }
            else if (TicTacToe.fieldArray[6] == TicTacToe.fieldArray[4] && TicTacToe.fieldArray[4] == TicTacToe.fieldArray[2])
            {
                return 1;
            }
            else if (TicTacToe.fieldArray[0] == TicTacToe.fieldArray[3] && TicTacToe.fieldArray[3] == TicTacToe.fieldArray[6])
            {
                return 1;
            }
            else if (TicTacToe.fieldArray[1] == TicTacToe.fieldArray[4] && TicTacToe.fieldArray[4] == TicTacToe.fieldArray[7])
            {
                return 1;
            }
            else if (TicTacToe.fieldArray[2] == TicTacToe.fieldArray[5] && TicTacToe.fieldArray[5] == TicTacToe.fieldArray[8])
            {
                return 1;
            }           
            else
            {
                return 0;
            }

        }
        
        
          
    }
}
