/*
Journal Class
*/
using System.Collections.Generic;
public class Journal{
    // Attributes   ------------------------
    public  List<string>  _journalEntries;
    public  string  _fileLocation;
        public  int     _dateSaved;
    public  int     _dateCreated;
    public  int     _streak;
    
    // Methods      ------------------------
    public Journal(string fileLocation){        
        Console.WriteLine("Loading from File");
    }
    public Journal(){        
        Console.WriteLine("Empty Journal Created");
    }
    public void Write(){
        Console.WriteLine("Adding Entry to Journal");
        return;
    }   
    public void Save(string fileLocation){
        Console.WriteLine("Saving to File");
        return;
    }   
    public void Display(){
        Console.WriteLine("Displaying Journal");
        return;
    }   

}