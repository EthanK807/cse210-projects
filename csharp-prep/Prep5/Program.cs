using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favorite = PromptUserNumber();
        int birthYear;
        PromptUserBirthYear(out birthYear);
        DisplayResult(name, SquareNumber(favorite), birthYear);


    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    static void PromptUserBirthYear(out int year)
    {
        Console.WriteLine("Please enter your birth year");
        year = int.Parse(Console.ReadLine());
    }
    static double SquareNumber(int x)
    {
        return Math.Pow(x, 2);
    }
    static void DisplayResult(string name, double SquareNumber, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {SquareNumber}\n{name}, you will turn " + (2025 - birthYear) + " this year.");
    }
}