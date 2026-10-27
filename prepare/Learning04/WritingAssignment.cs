public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(
        string studentName, 
        string topic, 
        string title
    ): base(studentName, topic)
    {
        title = _title;
    }

    public string GetWritingInformation ()
    {
        return $"{_title} by {GetStudentName()}";
    }
}