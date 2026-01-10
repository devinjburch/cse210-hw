using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade;
        Console.Write("What is your grade? ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);
        Console.WriteLine();

        

        if (grade >= 90)
        {
            Console.WriteLine($"Your grade of {userGrade} is an A");
            Console.WriteLine("You passed congratulations!");
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            Console.WriteLine($"Your grade of {userGrade} is a B");
            Console.WriteLine("You passed congratulations!");
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            Console.WriteLine($"Your grade of {userGrade} is a C");
            Console.WriteLine("You passed congratulations!");
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            Console.WriteLine($"Your grade of {userGrade} is a D");
            Console.WriteLine("You did not pass, better luck next time!");
            letterGrade = "D";
        }
        else
        {
            Console.WriteLine($"Your grade of {userGrade} is an F");
            Console.WriteLine("You did not pass, better luck next time!");
            letterGrade = "F";
        }

        Console.WriteLine();
        Console.WriteLine($"Your stored grade is {letterGrade}. ");
        Console.WriteLine();
    }
}