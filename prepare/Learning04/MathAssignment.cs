using System;
using System.Dynamic;

public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problem = "";

    public string GetTextbookSection()
    {
        return _textbookSection;
    }

    public void SetTextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }

    public string GetProblem()
    {
        return _problem;
    }

    public void SetProblem(string problem)
    {
        _problem = problem;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problem {_problem}";
    }
}