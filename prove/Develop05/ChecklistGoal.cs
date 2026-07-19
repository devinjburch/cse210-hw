//Make a class that inherits form Goal
//This is for a goal that requires a checklist
public class ChecklistGoal : Goal
{
    private int _target;//how many time a goal need to be comleted 
    private int _bonus;  //Extra points for full completion
    private int _completed; //Keeps track of number of completions

    //constructor for checlist, all goals start at 0 completions
    public ChecklistGoal(string name,string description,int points,int target,int bonus,int completed = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _completed = completed;
    }





    //Record Event specific to SimpleGoal
    public override int RecordEvent()
    {
        if (_completed >= _target) //If the checklist is complete: No Points
        {
            return 0;
        }

        _completed++; //Add to completed number

        if (_completed == _target)
        {
            return _points + _bonus;  //increase bonus if checklist is getting completed
        }

        return _points; //return normal points
    }




    //Make the Text for the checklist goal
    public override string GetDetailsString()
    {
        string checkBox = "[ ]";

        if (_completed >= _target)
        {
            checkBox = "[X]";
        }

        return $"{checkBox} {_name} ({_description})"
            + $" -- Completed {_completed}/{_target}";
    }






    //Turn the goal into one line of text that autofills the variables and formats it nice
    public override string GetSaveString()
    {
        return $"Checklist|{_name}|{_description}|{_points}|" + $"{_target}|{_bonus}|{_completed}";
    }
}