using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 11);
        int number;

        Console.WriteLine("What is the magic number?");
        Console.WriteLine("What is your guess?");
        number = int.Parse(Console.ReadLine());

        while (number != magic_number)
        {
            Console.WriteLine("That's not it. Try again!?");
            Console.WriteLine("What is your guess?");
            number = int.Parse(Console.ReadLine());
        

        if (number > magic_number)
        {
            Console.WriteLine("Too high! Try again!?");
            Console.WriteLine("What is your guess?");
            number = int.Parse(Console.ReadLine());
        }
        else if (number < magic_number)
        {
            Console.WriteLine("Too low! Try again!?");
            Console.WriteLine("What is your guess?");
            number = int.Parse(Console.ReadLine());
        }
        else
            {
            Console.WriteLine("You got it!");
            }
        }
    }
}