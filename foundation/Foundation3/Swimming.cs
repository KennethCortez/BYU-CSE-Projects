public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * 0.05;

    public override double GetSpeed() => (GetDistance() / Duration) * 60;

    public override double GetPace() => Duration / GetDistance();

    public override string GetSummary()
    {
        return base.GetSummary() +
               $"Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} km/h, Pace: {GetPace():F1} min per km";
    }
}
