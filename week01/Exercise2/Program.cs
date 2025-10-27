using System;

class Program
{
    static void Main(string[] args)
    {
        // get input
        Console.Write("What is your grade(as a percentage)? ");
        int gradePercent = int.Parse(Console.ReadLine());
        // calculate grade letter
        string gradeLetter = "";
        if(gradePercent>=90){
            gradeLetter = "A";
        } 
        else if(gradePercent >=80){
            gradeLetter = "B";

        }
        else if(gradePercent >=70){
            gradeLetter = "C";

        }
        else if(gradePercent >=60){
            gradeLetter = "D";

        }
        else{
            gradeLetter = "F";
        }
        Console.Write($"Your Grade is: {gradeLetter}\n");

        // calculate pass
        if(gradeLetter!="F"){
            Console.Write("Congratulations! You pass!");
        }else{
            Console.Write("You Fail! Better luck next time!");
        }
    }
}