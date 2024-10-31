public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, nt duration, double _distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;
    public override double GetSpeed() => (_distance/_duration) * 60;
    public override double GetPace() => Duration / _distance;
    public override string GetSummary()
    {
        return base.GetSummary() +
        $"Distance: {GetDistance()} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}