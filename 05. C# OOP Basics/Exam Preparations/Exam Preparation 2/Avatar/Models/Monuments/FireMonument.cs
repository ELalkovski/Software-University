using System.Text;

public class FireMonument : Monument
{
    private int fireAffinity;

    public FireMonument(string name, int fireAffinity) 
        : base(name)
    {
        this.fireAffinity = fireAffinity;
    }

    public override int GetMonumentPower()
    {
        return this.fireAffinity;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"###Fire Monument: {this.Name}, Fire Affinity: {this.fireAffinity}");

        return sb.ToString();
    }
}
