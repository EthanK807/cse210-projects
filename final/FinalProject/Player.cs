using System.Runtime.CompilerServices;

class Player
{
    private int _score;
    private string _name;
    private List<Club> Bag;
    private const int _maxClubs = 14;
    private Ball ball;
    public Player(string name)
    {
        _name = name;
        _score = 0;
        List<Club> shopInventory = GenerateClubList();


        // getting which clubs the user wants is written by Gemini, but I inputted all the values for the individual clubs

        Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("           PRO SHOP SELECTION           ");
            Console.WriteLine("========================================");
            Console.WriteLine($"Rules: Choose up to {_maxClubs} clubs.");
            Console.WriteLine("Type the number of the club to add it.");
            Console.WriteLine("Type '0' when you are finished.\n");

            bool selecting = true;

            while (selecting)
            {
                // 1. Display Status
                Console.WriteLine($"\n--- Current Bag ({Bag.Count}/{_maxClubs}) ---");
                if (Bag.Count == 0) Console.WriteLine("(Empty)");
                else Console.WriteLine(string.Join(", ", Bag.Select(c => c.getName())));

                if (Bag.Count >= _maxClubs)
                {
                    Console.WriteLine("\nYour bag is full!");
                    selecting = false;
                    break;
                }

                // 2. Display Available Clubs
                Console.WriteLine("\n--- Available Inventory ---");
                for (int i = 0; i < shopInventory.Count; i++)
                {
                    string itemDisplay;
                    if (Bag.Contains(shopInventory[i]))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        itemDisplay = $"[OWNED] {shopInventory[i].getName()}";
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        itemDisplay = $"[{i + 1,2}]    {shopInventory[i].getName()}";
                    }
                    
                    // Print in 3 columns for readability
                    Console.Write($"{itemDisplay,-25}");
                    if ((i + 1) % 3 == 0) Console.WriteLine();
                }
                Console.ResetColor();

                // 3. Get Input
                Console.Write("\n\nSelect Club # (0 to Finish): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice))
                {
                    if (choice == 0)
                    {
                        if (Bag.Count == 0) Console.WriteLine("You need at least one club to play!");
                        else selecting = false;
                    }
                    else if (choice > 0 && choice <= shopInventory.Count)
                    {
                        Club selected = shopInventory[choice - 1];
                        if (!Bag.Contains(selected))
                        {
                            Bag.Add(selected);
                            Console.WriteLine($">> Added {selected.getName()}");
                        }
                        else
                        {
                            Console.WriteLine(">> You already have that club.");
                        }
                    }
                    else
                    {
                        Console.WriteLine(">> Invalid selection number.");
                    }
                }
                else
                {
                    Console.WriteLine(">> Please enter a number.");
                }
            }
            Console.WriteLine("\nBag finalized! Heading to the first tee...");
    }
    private List<Club> GenerateClubList()
    {
        var list = new List<Club>();

        // 1-5 Woods (Low loft, high power)
        for (int i = 1; i <= 5; i++) 
            list.Add(new Club($"{i} Wood", 8f + (i*2), 1.0f - (i*0.03f)));

        // 1-5 Hybrids (Easier than irons)
        for (int i = 1; i <= 5; i++) 
            list.Add(new Club($"{i} Hybrid", 14f + (i*2), 0.85f - (i*0.03f)));

        // 1-9 Irons (Standard progression)
        for (int i = 1; i <= 9; i++) 
            list.Add(new Club($"{i} Iron", 16f + (i*3), 0.80f - (i*0.05f)));

        // Wedges & Putter
        list.Add(new Club("Pitching Wedge", 46f, 0.45f));
        list.Add(new Club("Gap Wedge", 50f, 0.40f));
        list.Add(new Club("Sand Wedge", 56f, 0.35f));
        list.Add(new Club("Lob Wedge", 60f, 0.30f));
        list.Add(new Club("Putter", 3f, 0.15f));

        return list;
    }
    public void MakeShot()
    {
        Console.WriteLine("Which club would you like to use")
    }
}

