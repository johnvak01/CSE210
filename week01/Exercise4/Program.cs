using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        while(true){
            Console.Write("Enter number: ");
            int new_number = int.Parse(Console.ReadLine());
            if(new_number == 0){
                break;
            }else{
                numbers.Add(new_number);
            }
        }

        int sum = 0;
        double avg = 0;
        int largest = numbers[0];

        foreach(int number in numbers){
            sum += number;
            if(number > largest){
                largest = number;
            }    
        }
        avg = (double)sum / (double)numbers.Count();
        Console.WriteLine($"The sum is: {sum}"); 
        Console.WriteLine($"The average is: {avg}"); 
        Console.WriteLine($"The largest number is: {largest}"); 
    }
}