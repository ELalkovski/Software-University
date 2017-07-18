using System.Text;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsePower;
    private int acceleration;
    private int suspension;
    private int durability;

    protected Car(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability)
    {
        this.brand = brand;
        this.model = model;
        this.yearOfProduction = yearOfProduction;
        this.horsePower = horsePower;
        this.acceleration = acceleration;
        this.suspension = suspension;
        this.durability = durability;
    }

    public string Brand
    {
        get { return this.brand; }
    }

    public string Model
    {
        get { return this.model; }
    }

    public int HorsePower
    {
        get { return this.horsePower; }
        set { this.horsePower = value; }
    }

    public int Suspension
    {
        get { return this.suspension; }
        set { this.suspension = value; }
    }

    public int Durability
    {
        get { return this.durability; }
        set { this.durability = value; }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"{this.brand} {this.model} {this.yearOfProduction}");
        sb.Append("\n");
        sb.Append($"{this.horsePower} HP, 100 m/h in {this.acceleration} s");
        sb.Append("\n");
        sb.Append($"{this.suspension} Suspension force, {this.durability} Durability");
        sb.Append("\n");

        return sb.ToString();
    }

    public int GetCasualOverallPoints()
    {
        return (this.horsePower / this.acceleration) + (this.suspension + this.durability);
    }

    public int GetDragOverallPoints()
    {
        return this.horsePower / this.acceleration;
    }

    public int GetDriftOverallPoints()
    {
        return (this.suspension + this.durability);
    }

    public int GetTimeOverall()
    {
        return (this.horsePower / 100) * this.acceleration;
    }

    public abstract void TuneUp(int tuneIndex, string addOn);
}
