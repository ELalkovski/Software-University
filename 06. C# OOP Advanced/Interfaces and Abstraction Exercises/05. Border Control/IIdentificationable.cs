namespace _05.Border_Control
{
    public interface IIdentificationable
    {
        string Id { get; }

        bool IsIdFake(string lastDigits);
    }
}
