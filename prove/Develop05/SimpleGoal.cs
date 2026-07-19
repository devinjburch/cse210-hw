
//Child class of Goal for Simple Goals
public class SimpleGoal : Goal
{
    private bool _complete;  // Simple variable yes/no if goal is complete



    //constructor for SimpleGoal
    //all goals start as false (not complete)
    public SimpleGoal(string name,string description,int points,bool complete = false)
        : base(name, description, points) //send these to parent class
    {
        _complete = complete;
    }




    //Record Event custom to SimpleGoal
    public override int RecordEvent()
    {
        if (_complete)   //If the goal is complete dont give points
        {
            return 0;
        }

        _complete = true;  //Mark the goal complete and reward points
        return _points;
    }




    //Make the Text for the specific goal
    public override string GetDetailsString()
    {
        string checkBox = "[ ]"; //Empty check box

        if (_complete)
        {
            checkBox = "[X]";  //Filled checkbox if completed
        }

        return $"{checkBox} {_name} ({_description})";  //return these
    }




    //Turn the goal into one line of text that autofills the variables
    public override string GetSaveString()
    {
        return $"Simple|{_name}|{_description}|{_points}|{_complete}";
    }
}