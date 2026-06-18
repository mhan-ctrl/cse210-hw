public abstract class Activity
{
    private readonly DateTime _date;
    private readonly double _minutes;

    protected Activity(DateTime date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public DateTime Date => _date;
    public double Minutes => _minutes;
    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({Minutes} min)\nDistance {Distance():0.0} km,\nSpeed {Speed():0.0} kph,\nPace: {Pace():0.0} min per km";
    }
}