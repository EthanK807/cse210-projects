using System;

class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                GoalManager manager = new GoalManager();
                manager.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"CRITICAL ERROR: {ex.Message}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }