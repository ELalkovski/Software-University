using System.Collections.Generic;
using System.Text;

public class PerformanceCar : Car
{
    private const int increaseFactor = 50;
    private const int decreaseFactor = 25;

    private List<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability)
    {
        this.HorsePower += (this.HorsePower * increaseFactor) / 100;
        this.Suspension -= (this.Suspension * decreaseFactor) / 100;
        this.addOns = new List<string>();
    }

    public override string ToString()
    {
        var sb = new StringBuilder(base.ToString());

        if (this.addOns.Count == 0)
        {
            sb.Append("Add-ons: None");
        }
        else
        {
            sb.Append($"Add-ons: {string.Join(", ", this.addOns)}");
        }

        return sb.ToString();
    }

    public override void TuneUp(int tuneIndex, string addOn)
    {
        this.addOns.Add(addOn);
    }
}
