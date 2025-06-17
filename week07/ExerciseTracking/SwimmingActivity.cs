public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, int time, int laps) : base(date, time)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (GetTime() / 60.0);
    }

    public override double GetPace()
    {
        return GetTime() / GetDistance();
    }
}