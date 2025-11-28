using System;
using System.Collections.Generic;

public class SleepTracker
{
    public string UserId { get; set; }
    public List<int> SleepRecords { get; set; }

    public SleepTracker()
    {
        SleepRecords = new List<int>();
    }

    public SleepTracker(string userId)
    {
        UserId = userId;
        SleepRecords = new List<int>();
    }

    public static SleepTracker CreateSleepTracker(string userId)
    {
        return new SleepTracker(userId);
    }

    public void LogSleep(int hours)
    {
        SleepRecords.Add(hours);
    }

    public double AverageSleep(int days)
    {
        if (SleepRecords.Count == 0) return 0;

        int sum = 0;
        int count = Math.Min(days, SleepRecords.Count);

        for (int i = SleepRecords.Count - count; i < SleepRecords.Count; i++)
            sum += SleepRecords[i];

        return (double)sum / count;
    }
}
