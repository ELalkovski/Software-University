using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DriftRace : Race
{
    public DriftRace(int length, string route, int prizePool) 
        : base(length, route, prizePool)
    {
    }

    public override string GetWinners()
    {
        List<Car> winners = this.Participants
            .OrderByDescending(p => p.GetDriftOverallPoints())
            .Take(3)
            .ToList();

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Route} - {this.Length}");
        int counter = 1;

        foreach (var winner in winners)
        {
            sb.Append(
                $"{counter}. {winner.Brand} {winner.Model} {winner.GetDriftOverallPoints()}PP - $");

            if (counter == 1)
            {
                sb.Append(this.PrizePool * 50 / 100);
            }
            else if (counter == 2)
            {
                sb.Append(this.PrizePool * 30 / 100);
            }
            else
            {
                sb.Append(this.PrizePool * 20 / 100);
            }

            sb.Append(Environment.NewLine);
            counter++;
        }

        return sb.ToString().Trim();
    }
}
