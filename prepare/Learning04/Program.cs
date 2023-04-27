using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1;

        while (number != 0)
        {     
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0)
               { numbers.Add(number);
               }
        }

        int total = 0;
        float average = 0;
        int maxNumber = 0;

        for (int i = 0; i < numbers.Count; i++)
            {
                total += numbers[i];
            }

        average = total / numbers.Count;
        maxNumber = numbers.Max();

        Console.WriteLine($"The total is: {total} ");
        Console.WriteLine($"The average is: {average} ");
        Console.WriteLine($"The Max number is: {maxNumber} ");
        


    }
}