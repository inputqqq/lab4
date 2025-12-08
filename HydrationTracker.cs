using System;
using System.Collections.Generic;
using System.Linq;

public class HydrationTracker
{
    public string UserId { get; set; }

    private int dailyGoalMl;
    public int DailyGoalMl
    {
        get { return dailyGoalMl; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Daily goal must be positive.");
            dailyGoalMl = value;
        }
    }

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
        try
        {
            if (amount <= 0)
                throw new ArgumentException("Drink amount must be positive.");
            Logs.Add(amount);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error adding drink: {ex.Message}");
        }
    }

    public double ProgressToday()
    {
        int sum = Logs.Sum();
        return sum == 0 ? 0.0 : (sum * 100.0) / DailyGoalMl;
    }
}
