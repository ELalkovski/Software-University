using System.Text;

public class EarthMonument : Monument
{
    private int earthAffinity;

    public EarthMonument(string name, int earthAffinity) 
        : base(name)
    {
        this.earthAffinity = earthAffinity;
    }

    public override int GetMonumentPower()
    {
        return this.earthAffinity;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"###Earth Monument: {this.Name}, Earth Affinity: {this.earthAffinity}");
        return sb.ToString();
    }
}
