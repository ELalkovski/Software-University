namespace _09.Traffic_Lights
{
    using System;

    public class TrafficLight
    {
        private Light currentState;

        public TrafficLight(Light currentState)
        {
            this.currentState = currentState;
        }

        public Light CurrentState { get { return this.currentState; }}

        public void ChangeLight()
        {
            this.currentState = (Light) ((int) (this.currentState + 1) % Enum.GetNames(typeof(Light)).Length);
        }

        public override string ToString()
        {
            return this.currentState.ToString();
        }
    }
}
