/*
Austin Hutchinson
CSE210 - week 03
Extra Credit: made it so the program doesn't hide the same word repeatedly.
*/
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        // create base scripture
        Reference newReference = new Reference("Mosiah", 3, 7);
        Scripture newScripture = new Scripture(newReference,"And lo, he shall suffer temptations, and pain of body, hunger, thirst, and fatigue, even more than man can suffer, except it be unto death; for behold, blood cometh from every pore, so great shall be his anguish for the wickedness and the abominations of his people.");

        // begin core loop
        string input = "";
        do{
            Console.Clear();
            Console.WriteLine(newScripture.Display());
            Console.Write("Press \'Enter\' to continue or type \'quit\' to finish: ");
            input = Console.ReadLine().ToLower();
            newScripture.HideRandomWord();
        }while(input != "quit");
    }
}