//https://paiza.jp/works/mondai/drankfast/d5_underline
using System;

class Program
{
    static void Main()
    {
        var line = Console.ReadLine();
        Console.WriteLine(line);
        var n = line.Length;
        for(int i = 0; i < n; i++)
        {
            Console.Write("^");
        }
    }
}