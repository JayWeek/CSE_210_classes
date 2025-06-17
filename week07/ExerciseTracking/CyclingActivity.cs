public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, int time, double speed) : base(date, time)
    {
        _speed = speed;
    }

    public override double GetSpeed() => _speed;

    public override double GetDistance()
    {
        return _speed * (GetTime() / 60.0);
    }


    public override double GetPace()
    {
        return GetTime() / GetDistance();
    }
}