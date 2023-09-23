using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();

        Console.WriteLine("Welcome to the Journal Program!");

        int choice = -1;

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quite");
            Console.Write("What would you like to do? ");
            string userInputChoice = Console.ReadLine();

            choice = int.Parse(userInputChoice);

            if (choice == 1)
            {
                Console.WriteLine("You have chosen to write an entry.");
            }

            else if (choice == 2)
            {
                Console.WriteLine("You have chosen to display entries.");
            }

            else if (choice == 3)
            {
                Console.WriteLine("You have chosen to load file.");
            }

            else if (choice == 4)
            {
                Console.WriteLine("You have chosen to save your file.");
            }

            else if (choice == 5)
            {
                Console.WriteLine("Thank you for using the Journal Program!");
            }

            else
            {
                Console.WriteLine("You have not choice a valid option.  Please try again.");
            }
        }
    }
}