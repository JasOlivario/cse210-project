public class Assignment
{
    private string _student;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _student = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _student;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"{_student} - {_topic}";
    }
}