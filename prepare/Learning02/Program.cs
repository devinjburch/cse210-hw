using System;

class Program
{
    static void Main()
    {
        Job firstJob = new Job();

        firstJob._jobTitle = "Software Developer";
        firstJob._company = "Google";
        firstJob._startYear = 2020;
        firstJob._endYear = 2022;

        Job secondJob = new Job();

        secondJob._jobTitle = "Project Manager";
        secondJob._company = "Amazon";
        secondJob._startYear = 2022;
        secondJob._endYear = 2024;

        Resume resume = new Resume();

        resume._name = "Jordan Smith";
        resume._jobs.Add(firstJob);
        resume._jobs.Add(secondJob);

        resume.Display();
    }
}