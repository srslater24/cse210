using System;

abstract class Activity
{
    private DateTime _date;
    private int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();
    public virtual double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }
    public virtual double GetPace()
    {
        return (_length / GetDistance());
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_length} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile");
    }
}