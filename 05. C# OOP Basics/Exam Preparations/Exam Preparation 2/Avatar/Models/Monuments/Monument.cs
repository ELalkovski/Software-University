public abstract class Monument
{
    private string name;

    public Monument(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return this.name; }
    }

    public abstract int GetMonumentPower();

    public override string ToString()
    {
        return "";
    }
}
