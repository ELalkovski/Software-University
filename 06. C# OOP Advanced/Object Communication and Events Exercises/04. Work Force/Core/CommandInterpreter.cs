namespace _04.Work_Force.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _04.Work_Force.Contracts;
    using _04.Work_Force.Models;
    using _04.Work_Force.Models.Employees;

    public delegate void JobDoneEventHandler(object sender, JobEventArgs args);

    public class CommandInterpreter
    {
        private JobList jobs;
        private List<Employee> employees;

        public CommandInterpreter()
        {
            this.jobs = new JobList();
            this.employees = new List<Employee>();
        }

        public void Run()
        {
            var input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input.Split();

                switch (tokens[0])
                {
                    case "Job":
                        Job currentJob = new Job(tokens[1], int.Parse(tokens[2]),
                            this.employees.FirstOrDefault(e => e.Name.Equals(tokens[3])));
                        currentJob.JobDone += currentJob.OnJobDone;
                        this.AddJob(currentJob);
                        break;
                    case "StandartEmployee":
                        this.AddEmployee(new StandartEmployee(tokens[1]));
                        break;
                    case "PartTimeEmployee":
                        this.AddEmployee(new PartTimeEmployee(tokens[1]));
                        break;
                    case "Status":
                        foreach (var job in this.jobs)
                        {
                            if (!job.IsDone)
                            {
                                Console.WriteLine(job.ToString());
                            }
                        }
                        break;
                    case "Pass":
                        foreach (var job in this.jobs)
                        {
                            job.Update();
                        }
                        break;
                }

                input = Console.ReadLine();
            }
        }

        private void AddJob(Job job)
        {
            this.jobs.Add(job);
        }

        private void AddEmployee(Employee employee)
        {
            this.employees.Add(employee);
        }
    }
}
