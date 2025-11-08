/*
Journal Class
*/
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.IO;
public class Journal{
    // Attributes   ------------------------
    public  List<JournalEntry>  _journalEntries;
    public  string  _fileLocation;
    public DateTime _dateLastWritten;
    public  int     _streak;
    
    // Methods      ------------------------
    public Journal(){        
        Console.WriteLine("Empty Journal Created");
        _journalEntries = new List<JournalEntry>();
        _dateLastWritten = DateTime.Now;
        _streak = 0;
    }
    public void Write(JournalEntry newEntry){
        Console.WriteLine("Adding Entry to Journal");
        _journalEntries.Add(newEntry);
        // update streak
        if (_streak == 0 ){
            _streak = 1;
        }
        else{
            int dateDifference = DateTime.Now.Day-_dateLastWritten.Day;
            if(dateDifference == 1){
                _streak++;
            }
            else if(dateDifference > 1){
                _streak = 1;
            }
        }
        Console.WriteLine($"New Streak:\t{_streak}");
        _dateLastWritten = DateTime.Now;
        
        return;
    }   
    public void Display(){
        Console.WriteLine("Displaying Journal");
        Console.WriteLine($"Current Streak: {_streak}");
        foreach(JournalEntry entry in _journalEntries){
            Console.WriteLine($"{entry._content}");
        }
        return;
    }   
    public void Save(string fileLocation){
        Console.WriteLine("Saving to File");
        using (StreamWriter outputfile = new StreamWriter(fileLocation)){
            outputfile.WriteLine(_streak);
            outputfile.WriteLine(_dateLastWritten);
            foreach(JournalEntry entry in _journalEntries){
                outputfile.WriteLine(entry._content);
            }
        }
        return;
    }   
    public void Load(string fileLocation){
        Console.WriteLine("Loading from File");
        _journalEntries = new List<JournalEntry>();

        string[] lines = System.IO.File.ReadAllLines(fileLocation);
        _streak = int.Parse(lines[0]);
        _dateLastWritten = DateTime.Parse(lines[1]);
        for(int index = 2; index < lines.Count(); index += 2 ){
            JournalEntry newEntry = new JournalEntry();
            newEntry._content = $"{lines[index]}\n{lines[index+1]}";
            _journalEntries.Add(newEntry);
        }
    }

}