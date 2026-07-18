using System;
using System.Collections.Generic;

// Child class for the listing activity.
public class ListingActivity : Activity
{
    private List<string> _prompts;
    private Random _random;






    public ListingActivity()
        : base(
            "Listing Activity",
            "This Activity Will Help You Reflect."
        )
    {
        _random = new Random();

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are some of your personal strengths?",
            "Who are people that you helped this week?",
            "What are some things that made you smile recently?"
        };
    }




    // method to run the listing program
    public void Run()
    {
        DisplayStartingMessage();  //Method from Activity parent class

        Console.WriteLine(
            "List as many responses as you can to this prompt:\n"
        );

        Console.WriteLine(
            $"===> {GetRandomPrompt()} <==="
        );

        Console.Write("\nYou may begin in: "); //start activity after 3 seconds
        ShowCountdown(3);

        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration()); //Calculate ending time

        int count = 0;  //variable for counting written items

        while (DateTime.Now < endTime)  //do this while the activity is still in the time window
        {
            Console.Write("=> ");
            Console.ReadLine();   //read the users response

            count++;  // add one to i
        }

        //tell the user how many items they listed
        Console.WriteLine(
            $"You listed {count} items!"
        );

        //display ending message from activity parent class
        DisplayEndingMessage();
    }





    //Get a random prompt to share to the user.
    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);

        return _prompts[index];
    }
}