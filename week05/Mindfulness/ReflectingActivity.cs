
public class ReflectingActivity:Activity{
    
    private List<string> _promptsMaster;
    private List<string> _promptsUnused;
    private List<string> _questionsMaster;
    private List<string> _questionsUnused;
    public ReflectingActivity():base("Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."){
        _promptsMaster = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."];
        _promptsUnused = _promptsMaster;
        _questionsMaster = ["Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"];
        _questionsUnused = _questionsMaster;
    }
    public void Reflecting(){
        DateTime now = DateTime.Now;
        DateTime end = now.AddSeconds(_duration);
        double timeDifference = (end-now).TotalSeconds;
        
        Console.Write(PickPrompt());
        this.RunAnimation(4);
        while(now < end){
            Console.WriteLine();
            Console.Write(PickQuestion());
            if (timeDifference >= 4){
                this.RunAnimation(4);
            }
            else{
                int final = (int)timeDifference;
                if (final <= 0){
                    break;
                }else{
                    this.RunAnimation(final);
                }
            }
            now = DateTime.Now;
            timeDifference = (end-now).TotalSeconds;
        }
        Console.WriteLine();
    }
    private string PickQuestion(){
        if(_questionsUnused.Count == 0){
            _questionsUnused = _questionsMaster;
        }
        Random generator = new Random();
        int index = generator.Next(0,_questionsUnused.Count-1);
        string holder  = _questionsUnused[index];
        _questionsUnused.RemoveAt(index);
        return holder;
    }
       private string PickPrompt(){
        if(_promptsUnused.Count == 0){
            _promptsUnused = _promptsMaster;
        }
        Random generator = new Random();
        int index = generator.Next(0,_promptsUnused.Count-1);
        string holder  = _promptsUnused[index];
        _promptsUnused.RemoveAt(index);
        return holder;
    }

}