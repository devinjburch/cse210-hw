using System;

// Child class for the breathing activity.
public class BreathingActivity : Activity 
{
    //constructor for the breathing activity
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly."
        )
    {
    }



    //method that activates the breathing exercize
    public void Run()
    {
        DisplayStartingMessage();  //use the methos thats shared from parent class (Activity)

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());  //create a time for the activity to end

        //the real brething activity
        while (DateTime.Now < endTime)
        {
            //Breathe in for 4 seconds
            Console.Write("Breathe in... ");
            ShowCountdown(4); 
            Console.WriteLine();

            //Breathe out for 4 seconds
            Console.Write("Breathe out... ");
            ShowCountdown(4);
            Console.WriteLine();
        }

        //Use the display message method drom Activity (parent) class
        DisplayEndingMessage();
    }
}