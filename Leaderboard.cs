using System;
using System.Collections.Generic;
using System.Linq;

public class Leaderboard
{
    // Статическое поле для подсчета очков всех пользователей
    public static int TotalPoints = 0;

    public string Id { get; set; }
    public string Period { get; set; }
    public List<(string UserId, int Points)> Scores { get; set; }

    public Leaderboard()
    {
        Scores = new List<(string, int)>();
    }

    public Leaderboard(string id, string period)
    {
        Id = id;
        Period = period;
        Scores = new List<(string, int)>();
    }

    public static Leaderboard CreateLeaderboard(string id, string period)
    {
        return new Leaderboard(id, period);
    }

    public void AddScore(string userId, int points)
    {
        try
        {
            if (points < 0) throw new ArgumentException("Points cannot be negative.");

            Scores.Add((userId, points));
            TotalPoints += points;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error adding score: {ex.Message}");
        }
    }

    public List<(string UserId, int Points)> Top(int n)
    {
        return Scores.OrderByDescending(s => s.Points).Take(n).ToList();
    }

    public void ShowLeaderboard()
    {
        Console.WriteLine($"Leaderboard ({Period})");
        int place = 1;

        foreach (var s in Top(Scores.Count))
        {
            Console.WriteLine($"{place}. {s.UserId} — {s.Points} pts");
            place++;
        }
    }

    // Статический метод для вывода общего числа очков
    public static void ShowTotalPoints()
    {
        Console.WriteLine($"Total points across all leaderboards: {TotalPoints}");
    }
}
