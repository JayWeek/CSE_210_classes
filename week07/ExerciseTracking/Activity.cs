public abstract class Activity
{
    private string _date = "";
    private int _time;

    // constructor
    public Activity(string date, int time)
    {
        _date = date;
        _time = time;
    }

    // methods
    public int GetTime() => _time;
    public string GetDate() => _date;
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{GetDate()} {GetType().Name} ({GetTime()} min): " +
            $"Distance: {GetDistance():0.0} km, " +
            $"Speed: {GetSpeed():0.0} kph, " +
            $"Pace: {GetPace():0.00} min per km";
    }

}