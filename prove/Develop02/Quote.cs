using System;

public class Quote
{
    string[] _quotes =
    {
        "Per aspera ad astra. Through hardship to the stars.",
        "Live for more.",
        "Strength grows through struggle.",
        "A person becomes what they choose to be.",
    };

    public void DisplayQuote()
    {
        Random random = new Random();
        int number = random.Next(_quotes.Length);

        Console.WriteLine("Red Rising Quote of the Day:");
        Console.WriteLine(_quotes[number]);
        Console.WriteLine();
    }
}