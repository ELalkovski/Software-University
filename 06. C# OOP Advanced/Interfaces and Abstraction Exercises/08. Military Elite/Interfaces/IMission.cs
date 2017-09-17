namespace _08.Military_Elite.Interfaces
{
    public interface IMission
    {
        string CodeName { get; }

        string MissionState { get; }

        void CompleteMission();
    }
}
