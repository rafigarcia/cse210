public class Swimming : Activity
{
    private double _laps;

    public Swimming (int minutes, DateOnly date, double laps) : base(minutes, date)
    {
        _laps = laps;
        SetActivityType("Swimming");
    }

    public override double GetSpeed()
    {
        return _laps * 50 / 1000;
    }

}