using System;

public class Achievement
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Criteria { get; set; }

    private int rewardPoints;
    public int RewardPoints
    {
        get { return rewardPoints; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Reward points cannot be negative.");
            rewardPoints = value;
        }
    }

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
        return true;
    }

    public void ShowAchievementInfo()
    {
        Console.WriteLine($"{Name} — {Criteria}, reward {RewardPoints} pts");
    }
}
