using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private int warsCount = 1;

    private Nation fireNation;
    private Nation waterNation;
    private Nation airNation;
    private Nation earthNation;
    private List<string> initiatedWars;

    public NationsBuilder()
    {
        this.fireNation = new Nation();
        this.waterNation = new Nation();
        this.airNation = new Nation();
        this.earthNation = new Nation();
        this.initiatedWars = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        var type = benderArgs[1];
        var name = benderArgs[2];
        var power = int.Parse(benderArgs[3]);
        var secondaryParameter = double.Parse(benderArgs[4]);
        Bender bender;

        if (type.Equals("Air"))
        {
           bender = new AirBender(name, power, secondaryParameter);
           this.airNation.AddBender(bender);
        }
        else if (type.Equals("Water"))
        {
            bender = new WaterBender(name, power, secondaryParameter);
            this.waterNation.AddBender(bender);
        }
        else if (type.Equals("Fire"))
        {
            bender = new FireBender(name, power, secondaryParameter);
            this.fireNation.AddBender(bender);
        }
        else
        {
            bender = new EarthBender(name, power, secondaryParameter);
            this.earthNation.AddBender(bender);
        }
    }
    public void AssignMonument(List<string> monumentArgs)
    {
        var type = monumentArgs[1];
        var name = monumentArgs[2];
        var affinity = int.Parse(monumentArgs[3]);

        Monument monument;

        if (type.Equals("Air"))
        {
            monument = new AirMonument(name, affinity);
            this.airNation.AddMonument(monument);
        }
        else if (type.Equals("Water"))
        {
            monument = new WaterMonument(name, affinity);
            this.waterNation.AddMonument(monument);
        }
        else if (type.Equals("Fire"))
        {
            monument = new FireMonument(name, affinity);
            this.fireNation.AddMonument(monument);
        }
        else
        {
            monument = new EarthMonument(name, affinity);
            this.earthNation.AddMonument(monument);
        }
    }
    public string GetStatus(string nationsType)
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{nationsType} Nation");

        if (nationsType.Equals("Air"))
        {
            sb.Append(this.airNation.ToString());
        }
        else if (nationsType.Equals("Water"))
        {
            sb.Append(this.waterNation.ToString());
        }
        else if (nationsType.Equals("Fire"))
        {
            sb.Append(this.fireNation.ToString());
        }
        else
        {
            sb.Append(this.earthNation.ToString());
        }

        return sb.ToString();
    }

    public void IssueWar(string nationsType)
    {
        this.initiatedWars.Add($"War {this.warsCount} issued by {nationsType}");
        this.warsCount++;

        var nations = new List<Nation>();
        nations.Add(fireNation);
        nations.Add(waterNation);
        nations.Add(airNation);
        nations.Add(earthNation);

        foreach (var nation in nations.OrderByDescending(n => n.GetTotalPower()).Skip(1))
        {
            nation.Benders.Clear();
            nation.Monuments.Clear();
        }
    }
    public string GetWarsRecord()
    {
        var sb = new StringBuilder();

        foreach (var war in this.initiatedWars)
        {
            sb.AppendLine(war);
        }

        return sb.ToString().Trim();
    }

}
