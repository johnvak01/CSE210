using System;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        int magic_number = generator.Next(1,100);
        while(true){
            Console.Write("What is the your guess? ");
            int guess = int.Parse(Console.ReadLine());
            if(guess < magic_number){
                Console.WriteLine("Higher");
            }
            else if(guess > magic_number){
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine("You guessed it!");
                break;
            }
        }
    }
}