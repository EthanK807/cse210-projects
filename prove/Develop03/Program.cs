using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("James", "4", "6");
        Scripture scripture1 = new Scripture(reference1, "But he giveth more grace. Wherefore he saith, God resisteth the proud, but giveth grace unto the humble.");

        while (true)
        {
            Console.Clear();
            scripture1.DisplayScripture();
            Console.WriteLine("Press enter to continue or type \"quit\" to end.");
            string answer = Console.ReadLine();
            if (scripture1.GetHiddenCount() == scripture1.GetWords().Count)
            {
                break;
            }
            else if (answer.Equals("\n"))
            {
                scripture1.HideWords();
                continue;
            }
            else if (answer.Equals("quit"))
            {
                break;
            }
            else
            {
                Console.WriteLine("Please type either quit or enter");
            }
        }
    }
}