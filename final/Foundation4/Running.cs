using System;

public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / base.minutes) * 60;
    }

    public override double GetPace()
    {
        return base.minutes / distance;
    }

    public override string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} Running ({minutes} min) - Distance: {distance:F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}
