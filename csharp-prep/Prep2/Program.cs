using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Enter your grade percentage: ");
        string usersInput = Console.ReadLine();
        int usersGrade = int.Parse(usersInput);

        string letter = "";

        if (usersGrade >= 90)
        {
            letter = "A";
        }
        else if (usersGrade >= 80 && usersGrade < 90)
        {
            letter = "B";
        }
        else if (usersGrade >= 70 && usersGrade < 80)
        {
            letter = "C";
        }
        else if (usersGrade >= 60 && usersGrade < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"This is your grade: {letter}");

        if (usersGrade >= 70)
        {
            Console.WriteLine("Congradulations, you passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass. A tutor will be assigned to you to help.");
        }
    }
}