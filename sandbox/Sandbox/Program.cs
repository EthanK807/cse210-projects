using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string animationString = "\\|/-";
        int sleepTime = 250;
        int duration = 10;
        int index = 0;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        // while(DateTime.Now < endTime)
        // {
        //     Console.Write(animationString[index++ % animationString.Length]);
        //     Console.Write("\b");
        //     Thread.Sleep(sleepTime);
        // }

        
        while(DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Console.Write("\b");
            Thread.Sleep(sleepTime);
        }

    
    
    }
    
}