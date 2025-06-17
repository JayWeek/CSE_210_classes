public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, int time, double distance) : base(date, time)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetTime()) * 60.0;
    }

    public override double GetPace()
    {
        return GetTime() / _distance;
    }
}