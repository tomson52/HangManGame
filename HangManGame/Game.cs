using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HangManGame
{
    public class Game
    {
        public static void NewGame()
        {
            // load data from file, init stopwatch, rand function
            List<string> data = new List<string>(Loader.Load());
            Stopwatch stopwatch = new Stopwatch();
            Random rand = new Random();
            
            // init of input, lifes, guess counter, list for wrong letters and boolean for checking that game is win
            string input;
            int life = 5;
            int guessCount = 0;
            List<char> wrongLetters = new List<char>();
            Boolean win = false;
                        
            //Genereate random number from 0 to Count, split choosen data from list to array - one hold hint second hold guessed capital
            int rng = rand.Next(0, data.Count);
            String[] strdat = data[rng].Split(" | ");
                        
            // split capital into char array, set guess array
            char[] capital = strdat[1].ToCharArray();
            char[] guessWord = new char[capital.Length];
            
            // fill guess array with "_" letter
            for (int i = 0; i < capital.Length; i++)
            {
                guessWord[i] = '_';
            }
            
            // start game - time start
            stopwatch.Start();
            while (true)
            {
                // check that player still alive - stop time if game over
                if (life < 0)
                {
                    stopwatch.Stop();
                    ASCIIArt.HangedPrint();
                    System.Console.WriteLine("\nGame over :(");
                    break;
                }

                //chceck that player guess all hidden letters
                for (int i = 0; i < capital.Length; i++)
                {
                    if (guessWord[i] == capital[i])
                    {
                        win = true;
                    }
                    else
                    {
                        win = false;
                        break;
                    }
                }

                //stop time - game win
                if (win == true)
                {
                    stopwatch.Stop();
                    TimeSpan stopwatchElapsed = stopwatch.Elapsed;
                    int time = Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                    
                    // show stats
                    System.Console.Write("YOU WIN!!!\n");
                    System.Console.Write("YOUR TRY ONLY: {0}\n", guessCount);
                    System.Console.Write("YOUR TIME: {0} seconds\n\n", time);

                    // ask to add sorce to personal file
                    System.Console.Write("Do you wan save your scorce to file? Y/N\n");
                    input = System.Console.ReadLine();
                    if (input == "y" || input == "Y")
                    {
                        string gameDate = Convert.ToString(DateTime.Now);
                        System.Console.Write("Your nick? \n");
                        input = System.Console.ReadLine();
                        string scorce = input + " | " + gameDate + " | " + time + " | " + guessCount + " | " + strdat[1];

                        // to do put scorce to file 
                        PersonalScorce.SaveScorce(input, scorce);
                    }

                    break;
                }

                // print ascii art
                ASCIIArt.ArtPrint(life);

                System.Console.Write("Life left: {0}", life);
                System.Console.Write("\nWrong letters: "); // wrong letters
                foreach (char x in wrongLetters)
                {
                    System.Console.Write("{0}, ", x);
                }

                System.Console.WriteLine();
                if (life == 0)
                {
                    System.Console.WriteLine("Last hope hint: The capital of {0}",
                        strdat[0]);
                }
                
                foreach (char x in guessWord)
                {
                    System.Console.Write(x);
                }

                System.Console.WriteLine("\n\nChoise you want guess single letter (1) or whole word (2)");
                input = System.Console.ReadLine();
                int caseSwitch = Int32.Parse(input);
                Boolean correct = false;

                switch (caseSwitch)
                {
                    case 1: // single letter
                        guessCount++;
                        System.Console.Write("Your letter: ");
                        input = System.Console.ReadLine();
                        char letter = Convert.ToChar(input); // capital have guessed word
                        correct = false;
                        for (int i = 0; i < capital.Length; i++)
                        {
                            if (Char.ToLower(letter) == Char.ToLower(capital[i]))
                            {
                                correct = true;
                                if (i == 0)
                                {
                                    guessWord[i] = Char.ToUpper(letter);
                                }
                                else
                                {
                                    guessWord[i] = Char.ToLower(letter);
                                }
                            }
                        }

                        if (correct == false)
                        {
                            life--;
                            wrongLetters.Add(letter);
                        }

                        break;
                    
                    case 2: // guess whole word
                        guessCount++;
                        System.Console.Write("Your word: ");
                        input = System.Console.ReadLine();
                        string word = Convert.ToString(input);
                        char[] wrd = word.ToCharArray();
                        Boolean wrong = false;
                        for (int i = 0; i < capital.Length; i++)
                        {
                            if (Char.ToLower(wrd[i]) == Char.ToLower(capital[i]))
                            {
                                if (i == 0)
                                {
                                    guessWord[i] = Char.ToUpper(wrd[i]);
                                }else
                                {
                                    guessWord[i] = Char.ToLower(wrd[i]);
                                }
                            }else
                            {
                                wrong = true;
                            }
                        }

                        if (wrong == true)
                        {
                            life = life - 2;
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid option. Please enter 1 or 2.");
                        break;
                }
            }
        }
    }
}