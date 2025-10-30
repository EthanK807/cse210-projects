using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your percentage grade here: ");
        String letterGrade = "";
        String writtenPercentage = Console.ReadLine();
        int percentage = int.Parse(writtenPercentage.Trim());
        if (percentage >= 90)
        {
            letterGrade = "A";
        }
        else if (percentage >= 80)
        {
            letterGrade = "B";
        }
        else if (percentage >= 70)
        {
            letterGrade = "C";
        }
        else if (percentage >= 60)
        {
            letterGrade = "D";
        }
        else if (percentage < 60)
        {
            letterGrade = "F";
        }
        Console.WriteLine("You got a " + letterGrade + " in the class");
        if (percentage > 70)
        {
            Console.WriteLine("You passed the class congradulations!");
        } else
        {
            Console.WriteLine("You did not pass the class, good luck next time!");
        }
    }
}