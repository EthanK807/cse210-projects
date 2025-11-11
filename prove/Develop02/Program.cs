using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Menu journalMenu = new Menu();

        Journal journal = new Journal();

        int userSelection;

        bool done = false;

        while (!done)
        {

            userSelection = journalMenu.ProcessMenu();

            switch (userSelection)
            
            {
                case 1:
                    journal.AddEntry();
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    journal.WriteToFile();
                    break;
                case 4:
                    journal.ReadFromFile();
                    break;
                case 5:
                    done = true;
                    break;
            }
        }

    }
}