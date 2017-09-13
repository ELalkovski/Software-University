namespace Firm_TEST2
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int hoursForProject = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());

            double hoursAfterTraining = (workingDays - (workingDays * 0.1)) * 8 ;
            double afterHours = employees * (2 * workingDays);
            double allHours = Math.Floor(hoursAfterTraining + afterHours);

            if (allHours >= hoursForProject)
            {
                Console.WriteLine("Yes!{0} hours left.", (allHours - hoursForProject));
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", (hoursForProject - allHours));
            }
        }
    }
}
