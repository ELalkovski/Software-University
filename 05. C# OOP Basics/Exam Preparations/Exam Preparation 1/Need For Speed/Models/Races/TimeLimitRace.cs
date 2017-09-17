using System.Text;

public class TimeLimitRace : Race
{
    private int goldTime;

    public TimeLimitRace(int length, string route, int prizePool, int goldTime)
        : base(length, route, prizePool)
    {
        this.goldTime = goldTime;
    }

    public override void AddParticipant(Car car)
    {
        if (this.Participants.Count == 0)
        {
            base.AddParticipant(car);
        }
    }

    public override string GetWinners()
    {
        Car winner = this.Participants[0];
        int time = this.Length * winner.GetTimeOverall();
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"{this.Route} - {this.Length}");
        sb.AppendLine($"{winner.Brand} {winner.Model} - {time} s.");

        if (time <= this.goldTime)
        {
            sb.Append($"Gold Time, ${this.PrizePool}.");
        }
        else if (time <= this.goldTime + 15)
        {
            sb.Append($"Silver Time, ${(this.PrizePool * 50) / 100}.");
        }
        else
        {
            sb.Append($"Bronze Time, ${(this.PrizePool * 30) / 100}.");
        }

        return sb.ToString();
    }
}