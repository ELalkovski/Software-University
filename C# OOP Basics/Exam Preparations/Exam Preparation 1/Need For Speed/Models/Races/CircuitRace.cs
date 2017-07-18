using System.Linq;
using System.Text;

public class CircuitRace : Race
{
    private int laps;

    public CircuitRace(int length, string route, int prizePool, int laps) 
        : base(length, route, prizePool)
    {
        this.laps = laps;
    }

    public override string GetWinners()
    {
        var decreaseDurabilityFactor = this.Length * this.Length;

        for (int i = 0; i < this.laps; i++)
        {
            foreach (var participant in this.Participants)
            {
                participant.Durability -= decreaseDurabilityFactor;
            }
        }

        var winners = this.Participants
            .OrderByDescending(p => p.GetCasualOverallPoints())
            .Take(4)
            .ToList();

        var sb = new StringBuilder();
        sb.AppendLine($"{this.Route} - {this.Length * laps}");
        var counter = 1;

        foreach (var winner in winners)
        {
            sb.Append($"{counter}. {winner.Brand} {winner.Model} {winner.GetCasualOverallPoints()}PP - $");
            if (counter == 1)
            {
                sb.Append(this.PrizePool * 40 / 100);
            }
            else if (counter == 2)
            {
                sb.Append(this.PrizePool * 30 / 100);
            }
            else if (counter == 3)
            {
                sb.Append(this.PrizePool * 20 / 100);
            }
            else
            {
                sb.Append(this.PrizePool * 10 / 100);
            }
            sb.Append("\n");
            counter++;
        }

        return sb.ToString().Trim();
    }
}
