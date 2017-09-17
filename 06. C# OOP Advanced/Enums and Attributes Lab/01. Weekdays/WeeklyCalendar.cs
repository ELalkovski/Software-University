using System.Collections.Generic;

public class WeeklyCalendar
{
    private List<WeeklyEntry> weeklySchedule;

    public WeeklyCalendar()
    {
        this.weeklySchedule = new List<WeeklyEntry>();
    }

    public List<WeeklyEntry> WeeklySchedule { get { return this.weeklySchedule; } }

    public void AddEntry(string weekDay, string notes)
    {
        this.weeklySchedule.Add(new WeeklyEntry(weekDay, notes));
    }

}
