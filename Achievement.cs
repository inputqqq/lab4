using System;

public class Achievement
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Criteria { get; set; }
    public int RewardPoints { get; set; }

    public Achievement() { }

    public Achievement(string id, string name, string criteria, int rewardPoints)
    {
        Id = id;
        Name = name;
        Criteria = criteria;
        RewardPoints = rewardPoints;
    }

    public static Achievement CreateAchievement(string id, string name, string criteria, int rewardPoints)
    {
        return new Achievement(id, name, criteria, rewardPoints);
    }

    public bool CheckEligibility(string user)
    {
        return true; // UML stub
    }

    public void ShowAchievementInfo()
    {
        Console.WriteLine($"{Name} — {Criteria}, reward {RewardPoints} pts");
    }
}
