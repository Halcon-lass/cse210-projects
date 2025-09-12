using System;
using System.Security.Cryptography.X509Certificates;


public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} {_company} {_startYear} {_endYear}");
    }


}


public class Resume
{
    public string _name;

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
        
    }

}
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Apple";
        job1._startYear = 2018;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Supervisor";
        job2._company = "Nestle";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Resume resume = new Resume();
        resume._name = "Luis Salazar";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();

    }
}