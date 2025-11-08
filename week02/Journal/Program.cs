/*
Austin Hutchinson
CSE210
Extra Credit: added a Streak Counter, resetting if you miss a day and displaying as part of the program.
*/
using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Journal currentJournal = new Journal();
        int selection = 0;

        while(true){
            Console.WriteLine("Please select one of the following choices:\n(1) Write\n(2) Display\n(3) Load\n(4) Save\n(5) Quit");
            Console.Write("What would you like to do? ");
            try{
            selection = int.Parse(Console.ReadLine());
            }
            catch{
                Console.WriteLine("\nInvalid Selection\n");
                continue;
            }
            switch(selection){
                case 1:     //Write a new entry
                    JournalEntry newEntry = new JournalEntry();
                    newEntry.Write();
                    currentJournal.Write(newEntry);
                    break;
                case 2:     //Display the Journal
                    currentJournal.Display();
                    break;
                case 3:     //Load a Prior Journal
                    Console.Write("File Location: ");
                    string loadFile = Console.ReadLine();
                    currentJournal.Load(loadFile);
                    break;
                case 4:     //Save the Current Journal;
                    Console.Write("File Location: ");
                    string saveFile = Console.ReadLine();
                    currentJournal.Save(saveFile);
                    break;
                case 5:     //Quit the Program
                    return;
                default:
                    Console.WriteLine("\nInvalid Selection\n");
                    break;
            }    
        }
    }
}