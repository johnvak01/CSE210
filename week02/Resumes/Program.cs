using System;

class Program
{
    static void Main(string[] args)
    {
    Job job1 = new Job();
    Job job2 = new Job();
    
    job1._jobTitle = "Vampire";
    job1._company = "Scholomance";
    job1._startYear = 1925;
    job1._endYear = 2025;
    
    job2._jobTitle = "Ghoul";
    job2._company = "Scholomance";
    job2._startYear = 1915;
    job2._endYear = 2015;

    Resume myResume = new Resume();
    myResume._name = "Austin";
    myResume._jobs.Add(job1);
    myResume._jobs.Add(job2);
    myResume.DisplayResume();
        }
}