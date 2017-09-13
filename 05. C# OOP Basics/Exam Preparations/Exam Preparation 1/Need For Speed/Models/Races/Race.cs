using System.Collections.Generic;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private List<Car> participants;

    protected Race(int length, string route, int prizePool)
    {
        this.length = length;
        this.route = route;
        this.prizePool = prizePool;
        this.participants = new List<Car>();
    }

    public List<Car> Participants
    {
        get { return this.participants; }
    }

    public int Length
    {
        get { return this.length; }
    }

    public int PrizePool
    {
        get { return this.prizePool; }
    }

    public string Route
    {
        get { return this.route; }
    }

    public virtual void AddParticipant(Car car)
    {
        this.participants.Add(car);
    }

    public abstract string GetWinners();
}
