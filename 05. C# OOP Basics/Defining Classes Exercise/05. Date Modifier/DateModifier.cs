namespace _05.Date_Modifier
{
    using System;
    using System.Globalization;

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
            DateTime dateOne = DateTime.ParseExact(this.firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime dateTwo = DateTime.ParseExact(this.secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);

            return Math.Abs((dateOne - dateTwo).TotalDays);
        }
    }
}
