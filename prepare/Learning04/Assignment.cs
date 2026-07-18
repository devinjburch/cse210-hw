//Parent Class for my other the specific assignment classes
public class Assignment
{
    //shared by every kind of assignment.
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //use this to get the private name.
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetSummary()
    {
        //Make a string containing the student's name
        string summary = _studentName + " - " + _topic;
        return summary;
    }
}