using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string userInput = Console.ReadLine();
        // int magicNumber = int.Parse(userInput);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string userInput2 = Console.ReadLine();
            guess = int.Parse(userInput2);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You Guessed It!");
            }
        }

    }
}