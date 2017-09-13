using System.Text;

public class EarthBender : Bender
{
    private double groundSaturation;

    public EarthBender(string name, int power, double groundSaturation) 
        : base(name, power)
    {
        this.groundSaturation = groundSaturation;
    }

    public override double GetTotalPower()
    {
        return this.Power * this.groundSaturation;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"###Earth Bender: {this.Name}, Power: {this.Power}, Ground Saturation: {this.groundSaturation:f2}");
        return sb.ToString();
    }
}
