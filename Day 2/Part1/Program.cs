using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    public static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:/Users/goncalo.mendes/RiderProjects/Adventofcode/Day 2/Part1/input.txt");
        int count = 0;
        int horizontal = 0;
        int depth = 0;
        
        foreach (var text in lines)
        {
            string number = string.Empty;
            string linha = Convert.ToString(text);
            foreach (var t in linha)
            {
                if (Char.IsDigit(t))
                    number += t;
            }

            if (linha.Contains("forward"))
            {
                horizontal += int.Parse(number);
            }
            else if (linha.Contains("up"))
            {
                depth -= int.Parse(number);
            }
            else if (linha.Contains("down"))
            {
                depth += int.Parse(number);
            }
        }

        count = horizontal * depth;
        Console.WriteLine(count);
    }
}