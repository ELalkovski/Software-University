using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm_TEST2
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursForProject = int.Parse(Console.ReadLine());
            var workingDays = int.Parse(Console.ReadLine());
            var employees = int.Parse(Console.ReadLine());

            double HoursAfterTraining = (workingDays - (workingDays * 0.1)) * 8 ;
            double AfterHours = employees * (2 * workingDays);
            double AllHours = Math.Floor(HoursAfterTraining + AfterHours);

            if (AllHours >= hoursForProject)
            {
                Console.WriteLine("Yes!{0} hours left.", (AllHours - hoursForProject));
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", (hoursForProject - AllHours));
            }

            
        }
    }
}
