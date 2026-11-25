using System;

public readonly record struct Clock
{
    private const int MinutesPerDay = 24 * 60;
    private readonly int totalMinutes;

    public Clock(int hours, int minutes)
    {
        int rawMinutes = hours * 60 + minutes;
        totalMinutes = ((rawMinutes % MinutesPerDay) + MinutesPerDay) % MinutesPerDay;
    }

    public Clock Add(int minutesToAdd) => new Clock(0, totalMinutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract) => new Clock(0, totalMinutes - minutesToSubtract);

    public override string ToString()
    {
        int hours = totalMinutes / 60;
        int minutes = totalMinutes % 60;
        return $"{hours:D2}:{minutes:D2}";
    }
}