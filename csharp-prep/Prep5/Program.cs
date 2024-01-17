using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userNumberSquare = SquareNumber(userNumber);
        DisplayResult(userName, userNumberSquare);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string theNumber = Console.ReadLine();
        int number = int.Parse(theNumber);
        return number;
    }
    static int SquareNumber(int userNumber)
    {
        int numberSquare = userNumber * userNumber;
        return numberSquare;
    }
    static void DisplayResult(string userName, int userNumberSquare)
    {
        Console.Write($"{userName}, the square of your number is {userNumberSquare}");
    }
}