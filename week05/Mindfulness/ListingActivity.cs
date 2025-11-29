
public class ListingActivity:Activity{
    private List<string> _promptsMaster;
    private List<string> _promptsUnused;
    public ListingActivity():base("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."){
        _promptsMaster = [
            "Who are people that you appreciate?","What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
            ];
            _promptsUnused = _promptsMaster;
    }
    public void Listing(){
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"\t--- {PickPrompt()} ---\t");
        Console.Write("\n Beginning in:  ");
        this.Countdown(5);
        Console.WriteLine(); 
        List<string> entries = [];
        DateTime now = DateTime.Now;
        DateTime end = now.AddSeconds(_duration);
        while(now < end){
            Console.Write(">\t");
            entries.Add(Console.ReadLine());


            now = DateTime.Now;
        }
        Console.WriteLine($"Well done. You listed {entries.Count} items!");
        
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