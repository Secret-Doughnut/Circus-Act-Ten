using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        DisplayWelcome();
        string Name = PromptUserName();
        int Number = PromptUserNumber();
        int Square = SquareNumber(Number);
        DisplayResult(Name, Square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string Name = Console.ReadLine();

        return Name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter a number: ");
        int Number = int.Parse(Console.ReadLine());

        return Number;
    }

    static int SquareNumber(int number)
    {
        int Answer = number * number;
        return Answer;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square root of your number is: {square}!");
    }
}