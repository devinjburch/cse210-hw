using System;

class Program
{
    static void Main()
    {
        //Display a quote of the day from Red Rising!
        Quote quote = new Quote();
        quote.DisplayQuote();


        // Create a new journal
        Journal journal = new Journal();

        // Store the user's choice from the menu
        string choice = "";

        //Show the menu until the user chooses 5
        while (choice != "5")
        {
            //Menu that looks just like the demo
            Console.WriteLine("\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
                journal.Write();
            else if (choice == "2")
                journal.Display();
            else if (choice == "3")
            {
                Console.Write("Filename: ");
                journal.Load(Console.ReadLine());
            }
            else if (choice == "4")
            {
                Console.Write("Filename: ");
                journal.Save(Console.ReadLine());
            }
            else if (choice != "5")
                Console.WriteLine("Invalid choice.");
        }
    }
}