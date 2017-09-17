using System.Text;

public class FireBender : Bender
{
    private double heatAggression;

    public FireBender(string name, int power, double heatAggression) 
        : base(name, power)
    {
        this.heatAggression = heatAggression;
    }

    public override double GetTotalPower()
    {
        return this.Power * this.heatAggression;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"###Fire Bender: {this.Name}, Power: {this.Power}, Heat Aggression: {this.heatAggression:f2}");

        return sb.ToString();
    }
}
