public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance() => _speed * (Duration / 60.0);

    public override double GetSpeed() => _speed;

    public override double GetPace() => Duration / GetDistance();

    public override string GetSummary()
    {
        return base.GetSummary() +
               $"Distance: {GetDistance():F1} miles, Speed: {GetSpeed()} mph, Pace: {GetPace():F1} min per mile";
    }
}
