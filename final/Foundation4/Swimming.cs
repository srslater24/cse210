using System;

class Swimming : Activity
{
    private int _lapCount;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _lapCount = laps;
    }

    public override double GetDistance()
    {
        return _lapCount * 50 / 1000 * 0.62;
    }
}