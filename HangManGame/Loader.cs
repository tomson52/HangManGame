using System;
using System.Collections.Generic;

namespace HangManGame
{
    public class Loader
    {
        public static List<string> Load() 
        {
            string line;
            List<string> data = new List<string>();
            
            // Read the file and put line in data list  
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader("countries_and_capitals.txt.txt");
                
                while ((line = file.ReadLine()) != null){ data.Add(line); }
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("file not foud :/");
                throw;
            }
            
            return data;
        }

        public static void LoadHighSor()
        {
            // to do load highsorce file
            /*string path =  ".txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(scorce);
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                Console.WriteLine(scorce);
            }*/
        }
    }
}