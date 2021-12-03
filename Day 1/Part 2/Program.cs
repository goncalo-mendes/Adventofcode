using System;
using System.IO;

class Program
{
    public static void Main()
    {
        string[] lines = File.ReadAllLines(@"/home/goncalo/Documents/adventToCode/input");
        Int64? count = 0;
        for (int i = 0; i < lines.Length; i++)
        {
            Int64 word1;
            Int64 word2;
            Int64 word3;
            Int64 word4;
            Int64 word5;
            Int64 word6;
            try {
                word1 = Convert.ToInt64(lines[i]);
                word2 = Convert.ToInt64(lines[i + 1]);
                word3 = Convert.ToInt64(lines[i + 2]);
            }
            catch(IndexOutOfRangeException ex)
            {
                break; 
            }
            try {
                word4 = Convert.ToInt64(lines[i + 1]);
                word5 = Convert.ToInt64(lines[i + 2]);
                word6 = Convert.ToInt64(lines[i + 3]);
            }
            catch(IndexOutOfRangeException ex)
            {
                break; 
            }  

            Int64 linha1 = word1 + word2 + word3;
            Int64 linha2 = word4 + word5 + word6;
            if (linha1 < linha2)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}