public class Spinning : Activity
{
    private double _speed;

    public Spinning(int minutes, DateOnly date, double speed) : base(minutes, date)
    {
        _speed = speed;
        SetActivityType("Spinning");
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}