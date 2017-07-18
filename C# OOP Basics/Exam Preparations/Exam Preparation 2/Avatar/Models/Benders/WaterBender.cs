using System.Text;

public class WaterBender : Bender
{
    private double waterClarity;

    public WaterBender(string name, int power, double waterClarity) 
        : base(name, power)
    {
        this.waterClarity = waterClarity;
    }

    public override double GetTotalPower()
    {
        return this.Power * this.waterClarity;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"###Water Bender: {this.Name}, Power: {this.Power}, Water Clarity: {this.waterClarity:f2}");
        return sb.ToString();
    }
}
