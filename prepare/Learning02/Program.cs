using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Instrumentation Technician";
        job1._company = "Petron Bataan Refinery";
        job1._startYear = 2017;
        job1._endYear = 2019;
        // job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Database Management";
        job2._company = "Cyberbacker";
        job2._startYear = 2021;
        job2._endYear = 2023;
        // job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Joshue Sam Olivario";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}