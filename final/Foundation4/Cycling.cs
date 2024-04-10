public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int durationMinutes, double speed)
        : base(date, durationMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * (durationMinutes / 60);
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {speed} kph, Distance: {GetDistance()} km, Pace: {GetPace()} min per km";
    }
}

// Derived Swimming class

