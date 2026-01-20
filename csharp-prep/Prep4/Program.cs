using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> numbersList = new List<string>();
        int total = 0;
        int newNumber = 1;
        string userInput;
        int largestNumber = 0;
        int iterations = 0;


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
        
            Console.WriteLine("Enter Number: ");
            userInput = Console.ReadLine();
            numbersList.Add(userInput);
            newNumber = int.Parse(userInput);

            if (newNumber == 0)
            {
                break;
            }


            total += newNumber;
            iterations++;

            if (newNumber>largestNumber)
            {
                largestNumber = newNumber;
            }
        
        }

        float average = (float)total/iterations;

        Console.WriteLine($"The sum of your numbers is {total}.");
        Console.WriteLine($"The largest number is {largestNumber}.");
        Console.WriteLine($"The average number value is {average}.");

    }
}