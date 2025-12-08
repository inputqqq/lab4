using System;
using System.Collections.Generic;

public class Challenge
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    private int durationDays;
    public int DurationDays
    {
        get { return durationDays; }
        set
        {
            if (value <= 0) throw new ArgumentException("Duration must be positive.");
            durationDays = value;
        }
    }

    public List<string> Participants { get; set; }

    public Challenge()
    {
        Participants = new List<string>();
    }

    public Challenge(string id, string title, string description, int durationDays)
    {
        Id = id;
        Title = title;
        Description = description;
        DurationDays = durationDays;
        Participants = new List<string>();
    }

    public static Challenge CreateChallenge(string id, string title, string description, int durationDays)
    {
        return new Challenge(id, title, description, durationDays);
    }

    public void Join(string userId)
    {
        try
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentException("User ID cannot be empty.");

            Participants.Add(userId);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error joining challenge: {ex.Message}");
        }
    }

    public double GetProgress(string userId)
    {
        if (!Participants.Contains(userId))
            return 0;

        return 50.0; // Заглушка
    }

    public void ShowChallengeInfo()
    {
        Console.WriteLine($"{Title}\n{Description}\nDuration: {DurationDays} days");
        Console.WriteLine($"Participants: {Participants.Count}");
    }
}
