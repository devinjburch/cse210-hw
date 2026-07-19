//Make a parent class for for the different goal types
public abstract class Goal
{
    protected string _name; //The goals include these three variable
    protected string _description;
    protected int _points;



    //Constructor for the goal class, each child class calls this constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }




    //This method returns the name of the goal
    //GoalKeeper uses this to display the list of goals
    public string GetName()
    {
        return _name;
    }



    //Use the methods from each child class 
    public abstract int RecordEvent(); //record progress and return points

    public abstract string GetDetailsString(); //Return goal's text

    public abstract string GetSaveString(); //Return info for saving file
}