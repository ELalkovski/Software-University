using System;

public class WeeklyEntry : IComparable<WeeklyEntry>
{
    private WeekDay weekDay;

    public WeeklyEntry(string weekDay, string notes)
    {
        Enum.TryParse(weekDay, out this.weekDay);
        this.Notes = notes;
    }

    public string Notes { get; private set; }

    public WeekDay WeekDay => this.weekDay;

    public override string ToString()
    {
        return $"{this.weekDay} - {this.Notes}";
    }

    public int CompareTo(WeeklyEntry other)
    {
        if (ReferenceEquals(this, other))
        {
            return 0;
        }
        if (ReferenceEquals(null, other))
        {
            return 1;
        }

        var weekComparison = this.weekDay.CompareTo(other.weekDay);

        if (weekComparison != 0)
        {
            return weekComparison;
        }

        return string.Compare(this.Notes, other.Notes, StringComparison.Ordinal);
    }
}
