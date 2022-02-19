using System;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        WriteLine("Hi!");
        const int Ten = 10;
        WriteLine($"Our const is {Ten}");
    Start:
        WriteLine("If you want to exit the program, please, enter a random char");
        string userEnter = ReadLine();
        if (userEnter.Length > 1 || userEnter == " ")
        {
            WriteLine("You must enter one char!");
            goto Start;
        }
    }
}