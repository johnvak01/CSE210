/*
Journal Class
*/
using System.Collections.Generic;
public class JournalEntry{
    // attributes   ------------------------
    public  string  _content;
    public  string  _dateCreated;
    private List<string> _prompts;
    private Random _randomNumGen;
    // Methods      ------------------------
    public JournalEntry(){      
        _prompts = [
            "What are you currently stressing over?",
            "What decisions did you make today that will come back to haunt you?",
            "What did you make/craft today?",
            "WHat did you pray about today?",
            "Write a short message to someone you haven;t tallked to in a while.",
            "What upcoming events are you planning for?",
            "What brought you Joy today",
            "What are you doing to hit your weekly goals?",
            "What are you doing to hit your monthly goals?",
            "What are you doing to hit your seasonal goals?",
            "What are you doing to hit your yearly goals?"
        ]; 
        _randomNumGen = new Random();
        _content = "";
    }
    public void Write(){
        _dateCreated = DateTime.Now.ToString("yyyy/MM/dd");
        _content += $"Date: {_dateCreated} - Prompt: {Prompt()}\n";
        Console.Write(_content);
        Console.Write("\t> ");
        _content += Console.ReadLine(); 
        return;
    }   
    private string Prompt(){
        int prompt_number = _randomNumGen.Next(0, _prompts.Count);
        return _prompts[prompt_number];
    }  
    private string Date(){
        string today = DateTime.Now.ToString("yyyy/MM/dd"); 
        return today;
    } 
}