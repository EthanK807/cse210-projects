using System;
using System.Formats.Asn1;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        while (true)
        {
        int randomValue = random.Next(0, 100);
            do
            {
                Console.Write("What is your guess?");
                int answer = int.Parse(Console.ReadLine());
                if (answer == randomValue)
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
                else if (answer < randomValue)
                {
                    Console.WriteLine("Higher");
                }
                else if (answer > randomValue)
                {
                    Console.WriteLine("Lower");
                }
            } while (true);
            Console.WriteLine("Would you like to play again?");
            if (Console.ReadLine().ToUpper().Equals("YES"))
            {
                continue;
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }
        }
    }
}