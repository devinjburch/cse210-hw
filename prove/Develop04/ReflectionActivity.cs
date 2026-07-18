using System;
using System.Collections.Generic;

// Child class for the reflection activity.
public class ReflectionActivity : Activity  
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random;



    //Constructor for the reflection activity
    public ReflectionActivity()
        : base("Reflection Activity","This activity will help you reflect on times when you showed strength and resilience.")
    {
        _random = new Random(); //Create a random object

        //my list of prompts
        _prompts = new List<string> 
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something selfless."
        };

        //my list of questions
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did you feel when it was complete?",
            "What did you learn about yourself?",
            "How can this experience help you in the future?"
        };
    }





    //Method to start the Refelction Activity 
    public void Run()
    {
        //Start activity with display from parent class
        DisplayStartingMessage();


        // Show the random prompt formatting neatly
        Console.WriteLine(
            "Think About This Prompt:\n"
        );

        Console.WriteLine(
            $"--- {GetRandomPrompt()} ---"
        );

        Console.WriteLine(
            "\nPress Enter When You Have Something In Mind."
        );

        //wait for the user to press enter
        Console.ReadLine();

        Console.WriteLine(
            "Now Think About Each Question."
        );

        Console.Write("You May Begin In: ");
        ShowCountdown(5); //show the countdown of 5 seconds

        Console.Clear();

        //calculate how long this should take
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime) //show questions until the time is up
        {
            Console.Write(
                $"> {GetRandomQuestion()} "
            );

            ShowSpinner(5); //loading screen spinner for 5 seconds

            Console.WriteLine();
        }

        //Show ending message from parernt class
        DisplayEndingMessage();
    }




    //method to choose a prompt at random
    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);

        return _prompts[index];
    }




    //method to choose a question at random
    private string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);

        return _questions[index];
    }
}