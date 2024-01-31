public class Assignment
{
    public string _studentName;
    public string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    // We will provide Getters for our private member variables so they can be accessed
    // later both outside the class as well is in derived classes.
    public string getStudentName()
    {
        return _studentName;
    }
    public string getTopic()
    {
        return _topic;
    }
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}