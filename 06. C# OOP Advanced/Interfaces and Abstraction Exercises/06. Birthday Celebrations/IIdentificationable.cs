namespace _06.Birthday_Celebrations
{
    public interface IIdentificationable
    {
        string Id { get; }

        bool IsIdFake(string lastDigits);
    }
}
