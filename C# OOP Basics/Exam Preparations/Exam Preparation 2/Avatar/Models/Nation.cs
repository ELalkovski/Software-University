using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    private List<Bender> benders;
    private List<Monument> monuments;

    public Nation()
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }

    public List<Bender> Benders
    {
        get { return this.benders; }
    }

    public List<Monument> Monuments
    {
        get { return this.monuments; }
    }

    public void AddBender(Bender bender)
    {
        this.benders.Add(bender);
    }

    public void AddMonument(Monument monument)
    {
        this.monuments.Add(monument);
    }

    public double GetTotalPower()
    {
        var increaseFactor = (this.GetBendersPower() / 100) * this.GetMonumentsPower();
        return this.GetBendersPower() + increaseFactor;
    }

    private double GetBendersPower()
    {
        return this.benders.Sum(b => b.GetTotalPower());
    }

    private int GetMonumentsPower()
    {
        return this.monuments.Sum(m => m.GetMonumentPower());
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"Benders:");
        if (this.benders.Count > 0)
        {
            sb.Append("\n");
            foreach (var bender in this.benders)
            {
                sb.AppendLine(bender.ToString());
            }
            
        }
        else
        {
            sb.Append($" None");
            sb.Append("\n");
        }

        sb.Append($"Monuments:");
        if (this.monuments.Count > 0)
        {
            sb.Append("\n");
            foreach (var monument in this.monuments)
            {
                sb.AppendLine(monument.ToString());
            }
        }
        else
        {
            sb.Append($" None");
            sb.Append("\n");
        }
        return sb.ToString().Trim();
    }
}
