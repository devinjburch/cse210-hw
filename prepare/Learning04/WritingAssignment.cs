public class WritingAssignment : Assignment //Child class for assignment
{
    private string _title; //store the title of the assignment
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation() //method to wirte assignment info
    {
        string name = GetStudentName();
        return _title + " by " + name;
    }
}