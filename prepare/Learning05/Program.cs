using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        PromptUserNumber();
        int number = 43;
        int squaredNumber = number * number;
        string userName = PromptUserName();
        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

    static string PromptUserName()
        {
            Console.Write("Please enter your userName: ");
            string userName = Console.ReadLine();
            return userName;
        }

    static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            return number;
        }

    static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is: {squaredNumber}");
        }

        
          


        

    
}