using System;
using System.ComponentModel.Design;

//Make a class for the Main Menus, Goals, and Score
public class GoalKeeper
{
    //Store every goal (Eternal, Simple or Checlist) 
    private List<Goal> _goals = new List<Goal>();
    
    //Store the goal setter's score
    private int _score = 0;

    //Create a file for saving and loading 
    private GoalFile _goalFile = new GoalFile();


    //Method for Leveling up
    private int GetLevel()
{
    return (_score / 500) + 1;  //Every 500 points is 1 level
}

    //Method for the Main Menu
    public void Start()
    {
        string choice = "";  //The choice is empty to start

        while (choice != "6") //Write the menu as long as they dont quit
        {
            //Menu displayed like the assignment demo
            Console.WriteLine($"\nYou have {_score} points.\n");//Show the current score
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice: ");

            choice = Console.ReadLine();//read the user's choice

            //Run the method that coincides with the users choice
            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoals();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
        }
    }


    //Goal creating method
    private void CreateGoal()
    {
        //Menu tells the user's thier options
        Console.WriteLine("\nPlease Choose A Goal Type");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("What Type of Goal Would You Like to Create? (Answer With Number Only): ");

        string type = Console.ReadLine(); //save the users response

        Console.Write("Name Your Goal: "); //Prompt user to name thier goal
        string name = Console.ReadLine();//save name

        Console.Write("Describe Your Goal: "); //Prompt user to describe their goal
        string description = Console.ReadLine();//save description

        Console.Write("How Many Points Is This Goal Worth?: "); //Prompt user for points value
        int points = int.Parse(Console.ReadLine()); //save points value

        //if/else to inititiate the goal the user wants
        if (type == "1")
        {
            Console.Write("Thanks For Choosing A Simple Goal! ");
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            Console.Write("Thanks For Choosing An Eternal Goal! ");
            _goals.Add(new EternalGoal(name, description, points));
        }

        //Checklist goal needs more information
        else if (type == "3")
        {
            Console.Write("Thanks For Choosing A Checklist Goal! ");
            Console.Write("How many times must it be completed?: "); //Prompt user for target amount

            int target = int.Parse(Console.ReadLine()); //save the response

            Console.Write("What is the completion bonus?: "); //Prompt the user for points bonus amount
            int bonus = int.Parse(Console.ReadLine()); //save the response

            _goals.Add(new ChecklistGoal(name,description,points,target,bonus));
        }
    }






    //Method for displaying each goal and the description
    private void ListGoals()
    {
        Console.WriteLine("\nYour Goals: ");

        //GetDetailsString calls the correct method for the goal type
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }






    //Method to record the user's progress
    private void RecordEvent()
    {
        Console.WriteLine("\nYour goals: "); //Display just the names of the goals numbered

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine(
                $"{i + 1}. {_goals[i].GetName()}"
            );
        }


        Console.Write("Which Goal Did You Work On?: "); //Prompt User For Goal number

        int number = int.Parse(Console.ReadLine()) - 1; //Save users number choice -1 because of engineers

        //Using POLYMORPHISM run RecordEvent depending on the goal type
        int pointsEarned = _goals[number].RecordEvent(); 

        _score += pointsEarned; //Add the users new points to the grand total

        //Tell the user their new score total
        Console.WriteLine($"Good Job, You Earned {pointsEarned} Points!");
        Console.WriteLine($"Your New Total: {_score} Points.");
        Console.WriteLine($"You Are Level {GetLevel()}.");
    }




    //Method for saving goals into a user's given file name
    private void SaveGoals()
    {
        Console.Write("What Would You Like To Name Your File?: "); //Prompt the user for file name
        string filename = Console.ReadLine();  //save the file name

        _goalFile.Save(filename, _score, _goals); //call the save method inside save class

        Console.WriteLine("Your Goals Have Been Saved, Thanks!");
    }







    //Method for loading the goals saved in the user's file
    private void LoadGoals()
    {
        Console.Write("What's The Name Of Your File? (Please Type Exactly!): ");//Prompt user for file name
        string filename = Console.ReadLine(); //Save the file name

        _score = _goalFile.Load(filename, _goals); //Load the goals

        Console.WriteLine("Goals Succesfully Loaded. ");
    }
}