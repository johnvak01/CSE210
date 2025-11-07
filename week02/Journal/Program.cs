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
            Console.Write("Please select one of the following choices:\n(1) Write\n(2) Display\n(3) Load\n(4) Save\n(5) Quit");
            selection = int.Parse(Console.ReadLine());
            switch(selection){
                case 1:     //Write a new entry
                    JournalEntry newEntry = new JournalEntry();
                    break;
                case 2:     //Display the Journal
                    Console.WriteLine("File Location: ");
                    string file = Console.ReadLine();
                    currentJournal = new Journal(file);
                    break;
                case 3:     //Load a Prior Journal
                    break;
                case 4:     //Save the Current Journal;
                    break;
                case 5:     //Quit the Program
                    return;
            }    
        }
    }
}