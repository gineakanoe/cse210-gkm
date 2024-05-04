using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();

        int userNumber = -1;

        while (userNumber != 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userNumber = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (userNumber == 1)
            {
                Console.WriteLine("This is your prompt.");
                Console.Write("Entry: ");
                Console.ReadLine();
            }
            else if (userNumber == 2)
            {
                Console.WriteLine("Your entries displayed here.");
            }
            else if (userNumber == 3)
            {
                Console.WriteLine("Loading....");
            }
            else if (userNumber == 4)
            {
                Console.WriteLine("Save your file here.");
            }
            else if (userNumber == 5)
            {
                Console.WriteLine("Thank you.  Goodbye.");
            }
            else 
            {
                Console.WriteLine("That is not a valid entry, please try again.");
            }
        }

           
        
        
    }
}