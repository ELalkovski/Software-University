using System;
using System.Collections.Generic;
using System.Linq;
namespace _08.Military_Elite.Entities
{
    using _08.Military_Elite.Interfaces;

    public class Mission : IMission
    {
        private string codeName;
        private string missionState;

        public Mission(string codeName, string missionState)
        {
            this.codeName = codeName;
            this.MissionState = missionState;
        }

        public string CodeName
        {
            get { return codeName; }
            private set { this.codeName = value; }
        }

        public string MissionState
        {
            get { return missionState; }
            private set
            {
                this.missionState = value;

            }
        }

        public void CompleteMission()
        {
            this.missionState = "Fnished";
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.missionState}";
        }
    }
}
