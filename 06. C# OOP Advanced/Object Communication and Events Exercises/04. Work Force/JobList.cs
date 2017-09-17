namespace _04.Work_Force
{
    using System.Collections.Generic;
    using _04.Work_Force.Models;

    public class JobList : List<Job>
    {
        public void OnJobDone(object sender, JobEventArgs args)
        {
            this.Remove(args.Job);
        }
    }
}
