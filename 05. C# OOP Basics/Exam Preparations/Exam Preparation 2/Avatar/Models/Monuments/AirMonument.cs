using System.Text;

public class AirMonument : Monument
{
    private int airAffinity;

    public AirMonument(string name, int airAffinity)
        : base(name)
    {
        this.airAffinity = airAffinity;
    }

    public override int GetMonumentPower()
    {
        return this.airAffinity;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"###Air Monument: {this.Name}, Air Affinity: {this.airAffinity}");
        return sb.ToString();
    }
}
