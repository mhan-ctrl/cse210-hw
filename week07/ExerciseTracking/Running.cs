public class Running : Activity
{
    private readonly double _distance;
    public Running(DateTime date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }
    public override double Distance()
    {
        return _distance;
    }
    public override double Speed()
    {
        return _distance / Minutes * 60;
    }
    public override double Pace()
    {
        return Minutes / _distance;
    }
}