/*
Austin Hutchinson
CSE210
Creativity: ensured there would be no duplicate questions or prompts until all have been used.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // print menu
        bool running = true;
        while(running){
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start Breathing Activity");
            Console.WriteLine("\t2. Start Reflecting Activity");
            Console.WriteLine("\t3. Start Listing Activity");
            Console.WriteLine("\t4. QUIT");
            Console.Write("Select a choice from the menu: ");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();
            switch(input){
                case 1:
                    BreathingActivity tester2 = new BreathingActivity();
                    tester2.StartActivity();
                    tester2.Breathing();
                    tester2.EndActivity();
                    break;
                case 2:
                    ReflectingActivity reflector = new ReflectingActivity();
                    reflector.StartActivity();
                    reflector.Reflecting();
                    reflector.EndActivity();
                    break;
                case 3:
                    ListingActivity tester3 = new ListingActivity();
                    tester3.StartActivity();
                    tester3.Listing();
                    tester3.EndActivity();
                    break;
                case 4:
                    running = false;
                    break;

            }

        }


        
    }
}