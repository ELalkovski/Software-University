using System.Text;

public class WaterMonument : Monument
{
    private int waterAffinity;

    public WaterMonument(string name, int waterAffinity) 
        : base(name)
    {
        this.waterAffinity = waterAffinity;
    }

    public override int GetMonumentPower()
    {
        return this.waterAffinity;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"###Water Monument: {this.Name}, Water Affinity: {this.waterAffinity}");
        return sb.ToString();
    }
}
