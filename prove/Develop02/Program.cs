using System;

class Program
{
    static void Main(string[] args)
    {
        Menu journalMenu = new Menu();

        int userSelection;

        bool done = false;

        while (!done)
        {

            userSelection = journalMenu.ProcessMenu();

            switch (userSelection)
            {
                case 1:
                    // Create a new Entry object
                    // Call create on that object
                    // Add the entry to the journal
                    break;
                case 2:
                    // Call journal.Display()
                    break;
                case 3:
                    // Save to a file
                    break;
                case 4:
                    // Read from a file
                    break;
                case 5:
                    done = true;
                    break;
            }
        }

    }
}