namespace _07.Food_Shortage
{
    public interface IIdentificationable
    {
        string Id { get; }

        bool IsIdFake(string lastDigits);
    }
}
