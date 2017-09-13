using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Date_Modifier
{
    public class DateModifier
    {
        private string firstDate;
        private string secondDate;

        public DateModifier(string firstDate, string secondDate)
        {
            this.firstDate = firstDate;
            this.secondDate = secondDate;
        }

        public double CalculateDays()
        {
            var dateOne = DateTime.ParseExact(this.firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            var dateTwo = DateTime.ParseExact(this.secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);

            return Math.Abs((dateOne - dateTwo).TotalDays);
        }
    }
}
