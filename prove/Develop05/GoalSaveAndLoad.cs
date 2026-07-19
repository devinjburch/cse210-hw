using System.IO;

//Class for saving and loading files
public class GoalFile
{
    //Method to save scores and goals to a file
    public void Save(string filename, int score, List<Goal> goals)
    {
        //StreamWriter creates or replaces the file
        using (StreamWriter file = new StreamWriter(filename))
        {
            file.WriteLine(score); //save the players score on line 1

            foreach (Goal goal in goals) //Go through each goal
            {
                //Use the GetSaveString file from each goal class
                //Save the nicely formated goals
                //POLYMORPHISMSSSSS
                file.WriteLine(goal.GetSaveString()); 
            }
        }
    }






    //Method to load the score and goals from files
    public int Load(string filename, List<Goal> goals)
    {
        
        //Read ever line from the selected file
        string[] lines = File.ReadAllLines(filename);


        //The score is saved on line 1
        int score = int.Parse(lines[0]);


        //Remove all prevous goals before loading new ones
        goals.Clear();


        //Start after the score and go through the lines
        for (int i = 1; i < lines.Length; i++)
        {
            //split the line whereever there is a '|' to save different variables
            string[] parts = lines[i].Split('|');

            //Save the variables
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);






            //Create a simple goal if type is 'Simple'
            if (type == "Simple")
            {
                bool complete = bool.Parse(parts[4]);

                goals.Add(new SimpleGoal(name, description, points, complete));
            }



            //Create an Eternal Goal if type is 'Eternal'
            else if (type == "Eternal")
            {
                goals.Add(new EternalGoal(name, description, points));
        
            }


            //Create a checklist goal if the type is 'Checklist'
            else if (type == "Checklist")
            {
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int completed = int.Parse(parts[6]);

                goals.Add(new ChecklistGoal(name, description, points, target, bonus, completed));
            }
        }

        //Return the saved score to GoalKeeper
        return score;
    }
}