using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Mechanic Engineer";
        job1._company = "Hanes Brands Inc";
        job1._startYear = 2002;
        job1._endYear = 2010;

        Job job2 = new Job();
        job2._jobTitle = "Auditor";
        job2._company = "FamilySearch";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Kenneth Cortez";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}