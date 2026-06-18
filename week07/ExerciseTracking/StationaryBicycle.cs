public class StationaryBicycle : Activity
{
    private readonly double _speed;
    public StationaryBicycle(DateTime date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }
    public override double Distance()
    {
        return Minutes * _speed/60.0;
    }
    public override double Speed()
    {
        return _speed;
    }
    public override double Pace()
    {
        return Minutes / Distance();
    }
}