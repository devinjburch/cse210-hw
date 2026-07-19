//Make an Eternal Goal class that inherits form Goal Parent Class
public class EternalGoal : Goal
{

    // Constructor for EternalGoals Class
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }



    //Record Event specific to SimpleGoal
    public override int RecordEvent()
    {
        return _points;  //Points are given with any event recorded
    }



    //Make the Text for the specific goal
    public override string GetDetailsString()
    {
        return $"[ ] {_name} ({_description})";
    }




    //Turn the goal into one line of text that autofills the variables
    public override string GetSaveString()
    {
        return $"Eternal|{_name}|{_description}|{_points}";
    }
}