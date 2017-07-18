namespace _05.Mordor_s_Cruelty_Plan
{
    public class FoodFactory
    {
        public Food ProduceFood(string name)
        {
            switch (name)
            {
                case "cram":
                    return new Cram();
                case "lembas":
                    return new Lembas();
                case "apple":
                    return new Apple();
                case "melon":
                    return new Melon();
                case "honeycake":
                    return new HoneyCake();
                case "mushrooms":
                    return new Mushroom();
                default:
                    return new OtherFood();
            }
        }
    }
}
