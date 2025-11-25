public class MathAssignment : Assignment{
    protected string _textbookSection;
    protected string _problems;
    public MathAssignment(string name, string topic, string section, string problems): base(name, topic){
        _textbookSection = section;
        _problems = problems;
    }
    public string GetHomeworkList(){
        return $"Section {_textbookSection}\tProblems {_problems}";
    }
}