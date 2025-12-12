public class Challenge
{
    public string Id { get; protected set; }
    public string Title { get; set; }
    public string Description { get; set; }


    // NEW: protected (только дл€ наследников)
    protected List<string> Participants = new();


    public Challenge(string id, string title, string desc)
    {
        Id = id;
        Title = title;
        Description = desc;
    }


    public virtual void ShowChallengeInfo() // виртуальна€
    {
        Console.WriteLine($"Challenge: {Title} Ч {Description}");
    }


    public virtual double GetProgress(string userId)
    {
        return Participants.Contains(userId) ? 30.0 : 0.0;
    }
}