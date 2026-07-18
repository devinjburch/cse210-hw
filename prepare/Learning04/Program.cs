using System;

class Program
{
    static void Main(string[] args)
    {
        //Assignment class - make a new assignment object
        Assignment firstAssignment = new Assignment("Darrow Andromedus", "Multiplication");

        Console.WriteLine(firstAssignment.GetSummary());




         //MathAssignment child class
        MathAssignment mathHomework = new MathAssignment(
            "Sevro au Barca",
            "Fractions",
            "7.3",
            "8-19"
        );

        //Print choices to console
        Console.WriteLine(mathHomework.GetSummary());
        Console.WriteLine(mathHomework.GetHomeworkList());




         //WritingAssignment child class
        WritingAssignment historyPaper = new WritingAssignment(
            "Mary Waters",
            "European History",
            "The Causes of World War II"
        );

        //Print choices to console
        Console.WriteLine(historyPaper.GetSummary());
        Console.WriteLine(historyPaper.GetWritingInformation());
    }
}