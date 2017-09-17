using System.Text;

public class Cat : Animal
{
    public Cat(string name, string favouriteFood)
        : base(name, favouriteFood)
    { }

    public override string ExplainMyself()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"I am {base.Name} and my fovourite food is {base.FavouriteFood}");
        sb.Append("MEEOW");

        return sb.ToString();
    }
}
