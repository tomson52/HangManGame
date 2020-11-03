using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace HangManGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangman Game v0.9"); // to do ASCII art

            while(true)
            {
                Console.WriteLine("1. Start new game\n2. Show HighScorce\n0. Quit");
                string input = System.Console.ReadLine();
                int caseSwitch =  Int32.Parse(input);
                switch(caseSwitch)
                {
                    case 1: // new game
                        Game.NewGame();
                        break;
                    case 2: // highscorce
                        //to do load hidh scorce, show best 10, sort etc...
                        Console.WriteLine("Under construction :/ Please come back later :)"); // to do 
                        break;
                    case 0: // quit from game
                        Console.WriteLine("Exiting from game");
                        return;
                    default:
                        Console.WriteLine( "Invalid option. Please enter 1, 2 or 0." );
                        break;
                }
            }
        }
    }
}
