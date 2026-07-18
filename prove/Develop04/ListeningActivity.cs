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
            "This activity will help you reflect on the good things in your life."
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

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine(
            "List as many responses as you can to this prompt:\n"
        );

        Console.WriteLine(
            $"--- {GetRandomPrompt()} ---"
        );

        Console.Write("\nYou may begin in: ");
        ShowCountdown(5);

        Console.WriteLine();

        DateTime endTime =
            DateTime.Now.AddSeconds(GetDuration());

        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();

            count++;
        }

        Console.WriteLine(
            $"You listed {count} items!"
        );

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);

        return _prompts[index];
    }
}