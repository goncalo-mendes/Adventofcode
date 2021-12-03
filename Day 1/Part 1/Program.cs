using System;
using System.IO;

class Program
{
    public static void Main()
    {
        string[] lines = File.ReadAllLines(@"/home/goncalo/Documents/adventToCode/input");
        Int64? count = 0;
        for (int i = 1; i < lines.Length; i++)
        {
            Int64 linha1 = Convert.ToInt64(lines[i - 1]);
            Int64 linha2 = Convert.ToInt64(lines[i]);
            if (linha1 < linha2)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
