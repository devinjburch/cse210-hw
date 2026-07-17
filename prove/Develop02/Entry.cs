using System;

public class Entry
{

    //store the entries
    public string _date;
    public string _prompt;
    public string _answer;

    //display my stores entries
    public void Display()
    {
        Console.WriteLine($"\nDate: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_answer);
    }
}