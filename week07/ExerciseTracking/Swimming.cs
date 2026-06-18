public class Swimming : Activity
{
    private readonly double _laps;
    public Swimming(DateTime date, double minutes, double laps) : base(date, minutes)
    {
        _laps = laps;
    }
    public override double Distance()
    {
        return _laps * 50 / 1000;
    }
    public override double Speed()
    {
        return (Distance() / Minutes) * 60;
    }
    public override double Pace()
    {
        return Minutes / Speed();
    }
}