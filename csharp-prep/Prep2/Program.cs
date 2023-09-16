using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for their grade percentage
        Console.Write("What is your grade percentage? ");
        string inputFromUser = Console.ReadLine();

        // Convert to integer
        int x = int.Parse(inputFromUser);

        string letter = "";

        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (x >= 70)
        {
            Console.WriteLine("Congratulations!  You have passed the course!");
        }
        else
        {
            Console.WriteLine("You did not pass; good luck next go round!");
        }

    }
}