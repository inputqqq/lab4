using System;
using System.Collections.Generic;
using System.Linq;

public class SleepTracker
{
    public string UserId { get; set; }
    private List<int> sleepRecords;

    public List<int> SleepRecords
    {
        get { return sleepRecords; }
        set
        {
            if (value == null) throw new ArgumentNullException("Sleep records cannot be null.");
            sleepRecords = value;
        }
    }

    public SleepTracker()
    {
        sleepRecords = new List<int>();
    }

    public SleepTracker(string userId)
    {
        UserId = userId;
        sleepRecords = new List<int>();
    }

    public static SleepTracker CreateSleepTracker(string userId)
    {
        return new SleepTracker(userId);
    }

    public void LogSleep(int hours)
    {
        try
        {
            if (hours <= 0)
                throw new ArgumentException("Sleep hours must be positive.");
            sleepRecords.Add(hours);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error logging sleep: {ex.Message}");
        }
    }

    public double AverageSleep(int days)
    {
        if (sleepRecords.Count == 0) return 0;

        int count = Math.Min(days, sleepRecords.Count);
        return sleepRecords.Skip(sleepRecords.Count - count).Average();
    }
}
