using System;
using System.IO;

namespace HangManGame
{
    public class PersonalScorce
    {
        public static void SaveScorce(string input, string scorce)
        {
            string path = input + ".txt";
            
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(scorce);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(scorce);
                }
            }
            
            System.Console.Write( "Your scorce {0} was added to file {1}\n", scorce, path);
            
        }
    }
}