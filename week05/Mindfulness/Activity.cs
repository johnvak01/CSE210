using System.Collections.Generic;
using System.Runtime.InteropServices;
public class Activity{
    private string _title;
    private string _description;
    protected int _duration;
    public Activity(string title = "Generic Activity", string description = "This is a generic activity.", int duration = 0){
        _title = title;
        _description = description;
        _duration = duration;
    }
    public void StartActivity(){
        Console.Write($"Welcome to the {_title}\n{_description}\n\n");
        while (true){
            Console.Write("Enter Session Length(in seconds): ");
            string input = Console.ReadLine();
            try{
                _duration = int.Parse(input);
                break;
            }
            catch{
                Console.WriteLine("Invalid Entry");
            }
        }
        Console.Clear();
    }
    public void EndActivity(){
        Console.Write("Well Done!");
        this.RunAnimation(5);
        Console.WriteLine("\n");
        Console.Write($"This session of {_title} lasted {_duration} seconds!");
        this.RunAnimation(5);


    }
    public void RunAnimation(int time = 0){
        
        List<char> frames = ['|','/','-','\\'];
        DateTime now = DateTime.Now;
        DateTime end = DateTime.Now;
        if(time != 0){
            end = end.AddSeconds(time);
        }else{
            end = end.AddSeconds(_duration);
        }
        int index = 0;
        Console.Write($" {frames[index%3]}");
        while(now < end){
            Console.Write($"\b{frames[index%3]}");
            Thread.Sleep(200);
            now = DateTime.Now;
            index++;      
        }
        Console.Write("\b\b  "); 
    }
    public void Countdown(int time = 0){
        int totalTime = time;
        if(totalTime == 0){
            totalTime = _duration;
        }
        for(int x = totalTime; x > 0; x--){
            // write number then wait prerequisite time
            Console.Write($"{x} ");
            Thread.Sleep(1000);
            //clear number
            int y = x;
            Console.Write("\b\b ");
            while(y>0){
                Console.Write("\b");
                y = y / 10;
            }
            
        }
    }
}