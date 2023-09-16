using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your username? ");
        string username = Console.ReadLine();

        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string userResponse = Console.ReadLine();
        int number = int.Parse(userResponse);

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        
        return square;
    }

    static void DisplayResult(string username, int square)
    {
        Console.WriteLine($"{username}, the square of your number is {square}");
    }
    
}