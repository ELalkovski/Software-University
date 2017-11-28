using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        WeeklyCalendar calendar = new WeeklyCalendar();

        calendar.AddEntry("Monday", "Internal meeting");
        calendar.AddEntry("Tuesday", "Create presentation");
        calendar.AddEntry("Tuesday", "Create lab and exercise");
        calendar.AddEntry("Thursday", "Enum Lecture");
        calendar.AddEntry("Monday", "Second internal meeting");

        List<WeeklyEntry> ordered = calendar.WeeklySchedule.OrderBy(n => n).ToList();

        foreach (var weeklyEntry in ordered)
        {
            Console.WriteLine(weeklyEntry);
        }
    }
}
