public class MathAssignment : Assignment //Math child class
{
    private string _section;  //initialize variables and make them private
    private string _problems;

    //constructor with its need info
    public MathAssignment(string studentName, string topic, string section, string problems) : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    //make the text for the math assignment and autofill variables
    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
    }
}