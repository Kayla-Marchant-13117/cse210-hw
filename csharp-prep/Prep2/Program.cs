using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Enter your grade percentage: ");
        string usersInput = Console.ReadLine();
        int usersGrade = int.Parse(usersInput);

        if (usersGrade >= 90)
        {
            Console.WriteLine("You have an A in the class.");
        }
        else if (usersGrade >= 80 && usersGrade < 90)
        {
            Console.WriteLine("You have a B in the class.");
        }
        else if (usersGrade >= 70 && usersGrade < 80)
        {
            Console.WriteLine("You have a C in the class.");
        }
        else if (usersGrade >= 60 && usersGrade < 70)
        {
            Console.WriteLine("You have a D in the class.");
        }
        else
        {
            Console.WriteLine("You have an F in the class, and therefore fail.");
        }
    }
}