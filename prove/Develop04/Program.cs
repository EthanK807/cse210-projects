using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Program.Animation(10);
    }
    static void Animation(int duration)
    {
        string animationString = "...";
        int sleepTime = 500;
        int index = 1000 / sleepTime * duration;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        
        while(DateTime.Now < endTime)
        {
            Console.Write(animationString.Substring(index-- % animationString.Length));
            Thread.Sleep(sleepTime);
            ClearCurrentConsoleLine();
        }
    }
    public static void ClearCurrentConsoleLine()
    {
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, currentLineCursor);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, currentLineCursor);
    }
}