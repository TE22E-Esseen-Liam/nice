// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        int sum = 0;

        sum = sum + 5;
        sum += 5;
        sum++;

        sum *= 2;

        Console.WriteLine($"Summan är {sum}!");

        Console.ReadLine();
    }
}
