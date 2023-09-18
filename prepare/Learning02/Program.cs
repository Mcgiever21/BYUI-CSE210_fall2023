using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello Learning02 World!");

        Catch22 c22 = new Catch22();
        Resume resume = new Resume();
        Console.WriteLine("enter name");
        resume.name = Console.ReadLine();
        int runs = 0;
        Job job2 = new Job();
        string FinalAnswer;

        do{
            
            string Patrick;
            do{
                
                Job job = new Job();
                Console.WriteLine("insert job title: ");
                job._jobTitle = Console.ReadLine();
                Console.WriteLine("insert company name: ");
                job._company = Console.ReadLine();
                Console.WriteLine("insert final year of work: ");
                job._endYear = Console.ReadLine();
                Console.WriteLine("insert initial year of work: ");
                job._startYear = Console.ReadLine();
                resume.jobs.Add(job);
                runs = ++runs;
                do{
                Console.WriteLine("Do you wish to enter a new job experience?");
                Patrick = Console.ReadLine();
                try{ 
                    ExceptionInput(Patrick);
                }
                catch (ArgumentException e) 
                {
                    Console.WriteLine(e.Message);
                }
                }while (c22.ErrorControl == 2);
            

            } while (Patrick == "yes");
            int sand = 0;

            do{
                
                Console.WriteLine("type zero for list all jobs, or type a number for a specific job");

                int countJobs = resume.jobs.Count();
                int listAnswer = int.Parse(Console.ReadLine());

                if (listAnswer == 0){
        
                    for(int i = 0; i < countJobs ; i ++)
                    {
                        job2.Display(resume.jobs[i]);
                    }
                    sand = 1;
                    
                }
                else if (listAnswer > 0)
                {
                    Job selectedJob = resume.jobs[listAnswer - 1];
                    Console.WriteLine($"title: {selectedJob._jobTitle}\nCompany: {selectedJob._company}\nstarting year: {selectedJob._startYear}\nEnd Year: {selectedJob._endYear}");
                    Console.Write(selectedJob);
                    Console.WriteLine("Would you like to list another job?");
                    string Request = Console.ReadLine();
                    if (Request =="no") { sand = 1; }
                }
                else{
                    if (listAnswer > countJobs) { Console.WriteLine("invalid entry");}
                }
        
            } while ( sand == 0 ); 

            Console.WriteLine("Do you wish to add further work experience to the resume?");
            FinalAnswer = Console.ReadLine();
        }while ( FinalAnswer == "yes");

        string ExceptionInput( string i)
        {
            if (i == "yes"){c22.ErrorControl = 1; return ""; }
            else if (i == "no"){ c22.ErrorControl = 1; return ""; }
            else {c22.ErrorControl = 2; throw new ArgumentException( string.Format("answer was out of bounds, please type 'yes' or 'no'.")); }
        }
    }
    
}