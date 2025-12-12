public interface IDeepCloneable<T>
{
    T DeepClone(); // глубокое клонирование
}


public class Achievement : ICloneable, IDeepCloneable<Achievement>
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Criteria { get; set; }


    private int rewardPoints;
    public int RewardPoints
    {
        get => rewardPoints;
        set
        {
            if (value < 0) throw new ArgumentException("Reward cannot be negative.");
            rewardPoints = value;
        }
    }


    public Achievement(string id, string name, string criteria, int reward)
    {
        Id = id;
        Name = name;
        Criteria = criteria;
        RewardPoints = reward;
    }


    public object Clone() => MemberwiseClone(); // поверхностное


    public Achievement DeepClone() => new Achievement(Id, Name, Criteria, RewardPoints); // глубокое


    public virtual void ShowAchievementInfo() // станет виртуальной
    {
        Console.WriteLine($"Achievement: {Name} ({Criteria}) — {RewardPoints} pts");
    }
}