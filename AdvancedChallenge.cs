public interface IResettable
{
    void Reset();
}


public class AdvancedChallenge : Challenge, IResettable
{
    public int Difficulty { get; set; }


    public AdvancedChallenge(string id, string title, string desc, int diff)
    : base(id, title, desc) // ВЫЗОВ БАЗОВОГО КОНСТРУКТОРА
    {
        Difficulty = diff;
    }


    public override void ShowChallengeInfo()
    {
        base.ShowChallengeInfo(); // вызов базовой версии
        Console.WriteLine($"Difficulty: {Difficulty}");
    }


    public override double GetProgress(string userId) // перегрузка без вызова base
    {
        return 80.0;
    }


    public void Reset()
    {
        Participants.Clear();
        Console.WriteLine("Challenge Reset!");
    }
}