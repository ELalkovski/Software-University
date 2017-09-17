namespace _07.Food_Shortage
{
    public interface IBuyer : IAgeble, IBirthable
    {
        int Food { get; set; }

        void BuyFood();
    }
}
