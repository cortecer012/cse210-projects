using System;

class Program
{
    static void Main(string[] args)
    {

        
        int guess = 0;

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        
        while (number != guess)
        {     
        Console.Write("What is your guess? ");
        string userInput2 = Console.ReadLine();
        guess = int.Parse(userInput2);    

        if (number > guess)
        {
        Console.WriteLine("Higher");
        }
        if (number < guess)
        {
        Console.WriteLine("Lower");
        }
        if (number == guess)
        {
        Console.WriteLine("You guessed it!");
        }
        }
        

        

        
    }
}