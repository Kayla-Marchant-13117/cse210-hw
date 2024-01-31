using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number between 1-5 to choose what you'd like to do. Enter 5 when ready to quit.");
        
        Console.WriteLine ("1. Write 2. Display 3. Save 4. Load 5. Quit");
        int userNumber = -1;
        int userNumber2 = -1;

        while (userNumber != 5)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            
            if (userNumber == 1)
            {
                Console.WriteLine ("6. Recieve prompt 7. No prompt 8. Menu");
                
                while (userNumber2 != 8)
                {
                    Console.Write("Enter second number: ");
                    string userInput2 = Console.ReadLine();
                    userNumber2 = int.Parse(userInput2);

                    if (userNumber2 == 6)
                    {
                        //select prompt
                    }
                    
                    else if (userNumber2 == 7)
                    {
                       Console.WriteLine("Begin writing"); 
                    }
                }

               

            }

            else if (userNumber == 2)
            {
                Console.WriteLine("Display journal entries");
                
            }

            else if (userNumber == 3)
            {
                Console.WriteLine("Save journal to file");
                
            }

            else if (userNumber == 4)
            {
                Console.WriteLine("Load journal to file");
                
            }

            
        }
    }
}