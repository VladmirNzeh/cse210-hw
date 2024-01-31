public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
    // Notice the syntax here that the MathAssignment constructor has 4 parameters and then
    // it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.
    public MathAssignment(string _studentName, string _topic, string _textbookSection, string _problems)
    : base(_studentName, _topic)
    {
        // Here we set the MathAssignment specific variables
        _textbookSection = _textbookSection;
        _problems = _problems;
    }
    public string getHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}