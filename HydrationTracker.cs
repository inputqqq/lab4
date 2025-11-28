using System;
using System.Collections.Generic;

public class HydrationTracker
{
    public string UserId { get; set; }
    public int DailyGoalMl { get; set; }
    public List<int> Logs { get; set; }

    public HydrationTracker()
    {
        DailyGoalMl = 2000;
        Logs = new List<int>();
    }

    public HydrationTracker(string uid, int goal)
    {
        UserId = uid;
        DailyGoalMl = goal;
        Logs = new List<int>();
    }

    public static HydrationTracker CreateHydrationTracker(string uid, int goal)
    {
        return new HydrationTracker(uid, goal);
    }

    public void AddDrink(int amount)
    {
        Logs.Add(amount);
    }

    public double ProgressToday()
    {
        int sum = 0;
        foreach (var ml in Logs)
            sum += ml;

        return sum == 0 ? 0.0 : (sum * 100.0) / DailyGoalMl;
    }
}
