using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment testAssignment = new Assignment("Austin","Science");
        Console.WriteLine("\n" + testAssignment.GetSummary());

        MathAssignment testMath = new MathAssignment("Austin","Math","7.2","3-5");
        Console.WriteLine("\n" + testMath.GetSummary());
        Console.WriteLine(testMath.GetHomeworkList());
        
        WritingAssignment testWriting = new WritingAssignment("Austin","Writing","A Tale of the Great White Whale");
        Console.WriteLine("\n"+testWriting.GetSummary());
        Console.WriteLine(testWriting.GetWritingInformation());


    }
}