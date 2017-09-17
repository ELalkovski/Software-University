namespace _04.Work_Force.Models
{
    using System;
    using _04.Work_Force.Core;
    using _04.Work_Force.Models.Employees;

    public class Job
    {
        private string name;
        private int workHoursRequired;
        private Employee employee;
        private bool isDone;
        public event JobDoneEventHandler JobDone;

        public Job(string name, int workHoursRequired, Employee employee)
        {
            this.name = name;
            this.workHoursRequired = workHoursRequired;
            this.employee = employee;
            this.isDone = false;
        }

        public bool IsDone { get { return this.isDone; } }    

        public void Update()
        {
            this.workHoursRequired -= this.employee.WorkHours;

            if (this.workHoursRequired <= 0 && !this.isDone)
            {
                if (JobDone != null)
                {
                    JobDone(this, new JobEventArgs(this));
                }
            }
        }

        public void OnJobDone(object source, JobEventArgs args)
        {
            if (JobDone != null)
            {
                Console.WriteLine($"Job {this.name} done!");
                this.isDone = true;
            }
        }

        public override string ToString()
        {
            return $"Job: {this.name} Hours Remaining: {this.workHoursRequired}";
        }
    }
}
