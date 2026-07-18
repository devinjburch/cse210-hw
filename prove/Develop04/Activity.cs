using System;
using System.Threading;


public class Activity //Activity is my parent class for the three other activites
{
    private string _name;              //make variables private
    private string _description;
    private int _duration;





    //constructor for Activity class (gets the name and description of the activity)
    public Activity(string name, string description) 
    {
        _name = name;
        _description = description;
    }





    //Method to welcome the user to whichever avtivity
    public void DisplayStartingMessage() 
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_name}.\n");  //autofill name
        Console.WriteLine(_description);

        Console.Write(
            "\nHow long, in seconds, would you like for your session? "
        );

        _duration = int.Parse(Console.ReadLine()); //ask for a session length and store it

        Console.Clear();
        Console.WriteLine("Get ready...");

        ShowSpinner(2);  //Display the spinner animation for 3 seconds
        Console.WriteLine();
    }




    //Method to inform the user the activity is over and leaves a summary
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood job!");
        ShowSpinner(2);  

        Console.WriteLine(
            $"\nYou completed {_duration} seconds of the {_name}."  //Autofill duration and name of activity
        );

        ShowSpinner(2);
        Console.WriteLine();
    }






    //simple method to get the duration value
    public int GetDuration()
    {
        return _duration;
    }




    //My method for showing the loading screen anuimation
    public void ShowSpinner(int seconds)
    {
        string[] symbols =
        {
            "[>_<]",
            "[o_o]",
            "[-_-]",
            "[-.-]",
            "[^_^]"
        };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        int oldLength = 0;

        while (DateTime.Now < endTime)
        {
            // Return to the beginning of the current line.
            Console.Write("\r");

            // Erase the previous animation frame.
            Console.Write(new string(' ', oldLength));

            // Return to the beginning again.
            Console.Write("\r");

            // Display the new frame.
            Console.Write(symbols[i]);

            oldLength = symbols[i].Length;

            Thread.Sleep(400);

            i++;

            if (i == symbols.Length)
            {
                i = 0;
            }
        }
    }






    //show a countdown that the user determines
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);  //show the second

            Thread.Sleep(1000); //wait a FULL SECOND to count down

            Console.Write("\b \b");  //erase and backspace
        }
    }
}