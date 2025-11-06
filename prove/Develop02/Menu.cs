class Menu
{
    public string[] _menuStrings =
    {
        "Welcome to the Count",
        "1 = Create Journal Entry",
        "2 - Display Journal",
        "3 - Save Journal to file",
        "4 - Read Journal from file",
        "5 - Quit"
    };

    public int ProcessMenu()
    {
        int userSelection = 0;
        do
        {
            foreach (string menuItem in _menuStrings)
            {
                Console.WriteLine(menuItem);
            }
            userSelection = int.Parse(Console.ReadLine());
        } while (userSelection > 0 || userSelection < 5);
        return userSelection;
        
    }
}