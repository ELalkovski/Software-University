namespace _11.Inferno_Infinity.Models
{
    using System;
    using Enums;

    public class Gem
    {
        private GemType gemType;
        private GemClarity gemClarity;
        private int strengthBonus;
        private int agilityBonus;
        private int vitalityBonus;

        public Gem(string clarity, string type)
        {
            Enum.TryParse(clarity, out gemClarity);
            Enum.TryParse(type, out gemType);
            this.CreateGemStats();
            this.AddClarityBonus();
        }

        public int StrengthBonus { get { return this.strengthBonus; } }

        public int AgilityBonus { get { return this.agilityBonus; } }

        public int VitalityBonus { get { return this.vitalityBonus; } }

        private void CreateGemStats()
        {
            if ((int)this.gemType == 0)
            {
                this.strengthBonus = 7;
                this.agilityBonus = 2;
                this.vitalityBonus = 5;
            }
            else if ((int)this.gemType == 1)
            {
                this.strengthBonus = 1;
                this.agilityBonus = 4;
                this.vitalityBonus = 9;
            }
            else
            {
                this.strengthBonus = 2;
                this.agilityBonus = 8;
                this.vitalityBonus = 4;
            }
        }

        private void AddClarityBonus()
        {
            this.strengthBonus += (int) this.gemClarity;
            this.agilityBonus += (int)this.gemClarity;
            this.vitalityBonus += (int)this.gemClarity;
        }
    }
}
