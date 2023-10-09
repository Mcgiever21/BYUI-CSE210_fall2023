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
                
                do{
                    c22.numControlYear = 2;
                    Console.WriteLine("insert final year of work: ");
                    job._endYear = Console.ReadLine();
                   try 
                    {
                        c22.ExceptionYear(job._endYear);
                    } 
                    catch (FormatException e) 
                    {
                        Console.WriteLine(e.Message);
                    }
                }while (c22.numControlYear == 2);
                
                do{
                    c22.numControlYear = 2;
                    Console.WriteLine("insert initial year of work: ");
                    job._startYear = Console.ReadLine();
                    
                   try 
                    {
                        c22.ExceptionYear(job._startYear);
                        c22.YearAdapt(job._endYear,job._startYear);
                    } 
                    catch (FormatException e) 
                    {
                        Console.WriteLine(e.Message);
                    }
                    /*try{
                        c22.YearAdapt(Steve,Phill);
                    }
                    catch (ArgumentException e){
                        Console.WriteLine(e.Message);
                    }*/

                }while (c22.numControlYear == 2);

                resume.jobs.Add(job);
                runs = ++runs;

                do{
                    Console.WriteLine("There are {0} jobs entered",runs);
                    Console.WriteLine("Do you wish to enter a new job experience?");
                    Patrick = Console.ReadLine();
                    try{ 
                        c22.ExceptionInput(Patrick);
                    }
                    catch (ArgumentException e) 
                    {
                        Console.WriteLine(e.Message);
                    }
                    
                }while (c22.ErrorControl == 2);
            

            } while (Patrick == "yes");
            int sand = 0;

            do{
                
                string listAnswer;
                int countJobs = resume.jobs.Count();

                do{
                    Console.WriteLine("type zero for list all jobs, or type a number for a specific job");
                    listAnswer = Console.ReadLine();
                    try{
                        c22.numCheck(listAnswer);
                    }
                    catch (FormatException e){
                        Console.WriteLine(e.Message);
                    }
                }while (c22.numC > 0);
                
                int Answer = int.Parse(listAnswer);

                if (Answer == 0){
        
                    for(int i = 0; i < countJobs ; i ++)
                    {
                        job2.Display(resume.jobs[i]);
                    }
                    sand = 1;
                    
                }
                else if (Answer > 0)
                {
                    Job selectedJob = resume.jobs[Answer - 1];
                    Console.WriteLine($"title: {selectedJob._jobTitle}\nCompany: {selectedJob._company}\nstarting year: {selectedJob._startYear}\nEnd Year: {selectedJob._endYear}");
                    Console.Write(selectedJob);
                    Console.WriteLine("Would you like to list another job?");
                    string Request = Console.ReadLine();
                    if (Request =="no") { sand = 1; }
                }
                else{
                    if (Answer > countJobs) { Console.WriteLine("invalid entry");}
                }
        
            } while ( sand == 0 ); 

            Console.WriteLine("Do you wish to add further work experience to the resume?");
            FinalAnswer = Console.ReadLine();
        }while ( FinalAnswer == "yes");

        
    }
}