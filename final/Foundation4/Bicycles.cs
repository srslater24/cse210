using System;

class Bicycles : Activity
{
    private double _speed;
    private int _length;

    public Bicycles(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
        _length = length;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        return (_speed * _length) / 60;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
}