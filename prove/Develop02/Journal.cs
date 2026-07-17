using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    //Store Journal entries
    public List<Entry> _entries = new List<Entry>();

    //This is my list of questions for the journal.
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "What did you learn today?",
        "Who did you talk to today?",
        "What made you happy today?",
        "What would you change about today?"
    };

    //Make a new journal entry function
    public void Write()
    {
        Random random = new Random(); //pick a prompt at random and show it
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine(prompt);
        Console.Write("> ");

        Entry entry = new Entry(); //save the entry along with info
        entry._date = DateTime.Now.ToShortDateString();
        entry._prompt = prompt;
        entry._answer = Console.ReadLine();

        _entries.Add(entry);
    }

    // display each journal entry
    public void Display()
    {
        foreach (Entry entry in _entries) //go through each one and display them one by one
            entry.Display();
    }

    //save function
    public void Save(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
                writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._answer}");
        }

        Console.WriteLine("Journal saved.");//inform the user the entry saved   
    }

    //load funtion
    public void Load(string file)
    {
        _entries.Clear();

        foreach (string line in File.ReadAllLines(file))
        {
            string[] data = line.Split("|");

            Entry entry = new Entry();
            entry._date = data[0];
            entry._prompt = data[1];
            entry._answer = data[2];

            _entries.Add(entry);
        }

        Console.WriteLine("Journal loaded."); //inform the user the entry loaded
    }
}