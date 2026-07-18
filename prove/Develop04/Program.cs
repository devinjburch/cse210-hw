using System;

//CREATIVITY:
// To show creativity I made it so the Reflecting Activity will not repeat a prompt
// I also replaced the spinner animation with a face going from stressed to relieved/happy


class Program
{
    static void Main(string[] args)
    {
        string choice = ""; //initialize the user's choice variable

        while (choice != "4") //Display the menu until the user quits
        {

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Breathing Activity");
            Console.WriteLine("  2. Reflection Activity");
            Console.WriteLine("  3. Listing Activity");
            Console.WriteLine("  4. Quit Menu");
            Console.Write("Select A Choice: ");

            choice = Console.ReadLine();

            if (choice == "1")//Run the breathing activity
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2") //run the reflection activity
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }
            else if (choice == "3") // run the listening activity
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (choice != "4")
            {
                Console.WriteLine("Please choose a number from 1 to 4."); //ask for a menu selection and store it
                Console.ReadLine();
            }
        }
    }
}