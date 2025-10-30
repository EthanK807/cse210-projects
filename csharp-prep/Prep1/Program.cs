using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        string firstName;
        string lastName;

        Console.Write("Please enter you first name: ");
        firstName = Console.ReadLine();

        Console.WriteLine("Please enter your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine("Your name is : " + firstName + " " + lastName);
    }
}