namespace _04.Work_Force
{
    using System;
    using _04.Work_Force.Models;

    public class JobEventArgs : EventArgs
    {
        public JobEventArgs(Job job)
        {
            this.Job = job;
        }

        public Job Job { get; set; }
    }
}
