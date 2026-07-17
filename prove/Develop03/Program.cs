using System;

class Program
{

        //Create a scripture reference with constructor for verse range
        static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("Proverbs", 3, 5, 6);





        // Store the entire scripture text to a string
        string scriptureText =
            "Trust in the Lord with all thine heart and lean not unto " +
            "thine own understanding. In all thy ways acknowledge him, " +
            "and he shall direct thy paths.";

        //Scripture Object - Gets both reference and the scripture's text
        Scripture scripture = new Scripture(scriptureReference, scriptureText);




        //store the user's answer      
        string choice = "";




        //a while loop that continues until 2 exit reasons
        //!. user enters quit
        //2. user hides all the words of the scripture
        while (choice != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();//clear my console before showing scripture again
            Console.WriteLine(scripture.GetDisplayText()); //show scripture with current words
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type quit.");

           //read the user's response
           choice = Console.ReadLine();

            //Hide words until user says to stop
            if (choice != "quit")
            {
                scripture.HideWords();
            }
        }

    Console.WriteLine("Alma 37:35 \n...learn in thy youth to keep the commandments of God");
    }
    
}