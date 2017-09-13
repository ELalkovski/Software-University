namespace _05.Mordor_s_Cruelty_Plan
{
    public class Mood
    {
        private int points;
        private string mood; 
        
        public Mood(int points)
        {
            this.points = points;
            this.SetMood();
        }

        public string GetMood
        {
            get { return this.mood; }

        }

        private void SetMood()
        {
            if (this.points < -5)
            {
                this.mood = "Angry";
            }
            else if (this.points >= -5 && this.points <= 0)
            {
                this.mood = "Sad";
            }
            else if (this.points > 0 && this.points <= 15)
            {
                this.mood = "Happy";
            }
            else if (this.points > 15)
            {
                this.mood = "JavaScript";
            }
        }
    }
}
