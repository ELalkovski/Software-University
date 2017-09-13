namespace _05.Mordor_s_Cruelty_Plan
{
    public abstract class Food
    {
        private int points;

        public Food(int points)
        {
            this.points = points;
        }

        public virtual int PointsOfHappiness
        {
            get
            {
                return this.points;
            }
        }
    }
}
