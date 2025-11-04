using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        while (true)
        {
            int sum = 0;
            double average = 0;
            int largestNumber = int.MinValue;
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            while (true)
            {
                int value = int.Parse(Console.ReadLine());
                if (value == 0)
                {
                    foreach (int i in list)
                    {
                        sum += i;
                        if (i > largestNumber)
                        {
                            largestNumber = i;
                        }
                    }
                    average = sum / list.Count;
                    Console.WriteLine($"The sum is: {sum}\nThe average is: {average}\nThe largest number is: {largestNumber}");
                    break;
                }
                else
                {
                    list.Add(value);
                }
            }
        }
    }
}