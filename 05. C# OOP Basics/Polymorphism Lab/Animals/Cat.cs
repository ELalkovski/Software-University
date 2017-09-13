using System.Text;

public class Cat : Animal
{
    public Cat(string name, string favouriteFood)
        : base(name, favouriteFood)
    { }

    public override string ExplainMyself()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ExplainMyself());
        sb.Append("MEEOW");
        return sb.ToString();
    }
}
