using System.Net;

class Journal
{
    private List<Entry> entries;
    private List<string> journalPrompts;
    public Journal()
    {
        entries = new List<Entry>();
        journalPrompts = new List<string>
        {
            // Self-Reflection & Understanding
            "What is something you're proud of, but don't get to talk about often?",
            "When do you feel most like your authentic self? Describe that time or place.",
            "What is a belief you hold that has changed significantly over the past five years?",
            "List 10 things that make you happy.",
            "What does your \"perfect day\" look like? Describe it from morning to night.",
            "What is one thing you are currently resisting? Why?",
            "How are you different today than you were one year ago?",

            // The Future & Goals
            "Describe your ideal life in 5 or 10 years. Be as detailed as possible.",
            "What is one small step you can take this week to move closer to a big goal?",
            "What is a skill you've always wanted to learn? What's stopping you from starting?",
            "What are you looking forward to in the next month?",
            "Write a letter to your future self, to be opened one year from today.",
            "What is a fear you have about the future? Write it down, and then write down a rational counter-argument to that fear.",

            // Gratitude & Positivity
            "List 5 small, simple pleasures you enjoyed today (e.g., the smell of coffee, a good song).",
            "Write about a person who has had a positive impact on your life. What did they teach you?",
            "Describe a challenge you'm grateful you went through. What did you learn from it?",
            "What is something beautiful you saw recently?",
            "What is one thing about your body that you are grateful for?",
            "Who is someone in your life you could thank? Write down what you would say to them.",

            // Emotional Check-In
            "What emotion are you feeling most strongly right now? Where do you feel it in your body?",
            "What's on your mind today? (This is often called a \"brain dump\"—just write whatever comes to mind for 10 minutes, without stopping or editing.)",
            "What drains your energy? What replenishes it?",
            "Describe a time this week you felt happy, angry, or sad. What triggered that feeling?",
            "What do you need to let go of?",
            "What is something you need to say \"no\" to right now? What do you need to say \"yes\" to?",

            // The Past & Memories
            "Write about a core memory from your childhood. Why do you think it has stuck with you?",
            "What is a piece of advice you would give to your 16-year-old self?",
            "Describe a time you failed at something. What did you learn from the experience?",
            "Write about a person who is no longer in your life, but taught you an important lesson.",
            "What is a moment you wish you could relive? What made it so special?",

            // Creative & "What If..."
            "If you woke up tomorrow with no fear, what would be the first thing you would do?",
            "Describe your current world from the perspective of an animal (like your pet or a bird outside).",
            "Invent a new holiday. What does it celebrate, and what are its traditions?",
            "Write a story that starts with the line, \"The key fit the lock, but the door wouldn't open...\"",
            "What if you had a superpower for 24 hours? What would it be, and what would you do?",

            // Quick Daily Prompts
            "One word to describe my day:",
            "Today, I'm grateful for:",
            "My biggest win today was:",
            "My biggest challenge today was:",
            "Something that made me smile today:"
        };
    }
    public void AddEntry()
    {
        Random rnd = new Random();
        string date = DateTime.Now.ToShortDateString();
        string prompt = journalPrompts[rnd.Next(1, journalPrompts.Count + 1)];
        Console.WriteLine($"Your prompt is {prompt}. What is your answer?");
        string response = Console.ReadLine();
        Entry entry = new Entry(date, prompt, response);
        entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }
    public void ReadFromFile()
    {
        string filename = "journalEntries.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Console.WriteLine($"{date} {prompt} {response}");
        }
    }

    public void WriteToFile()
    {
        string filename = "journalEntries.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }


}