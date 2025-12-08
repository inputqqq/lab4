using System;

public class RecoverySession
{
    public string Id { get; set; }
    public string Date { get; set; }
    public string Type { get; set; }
    private int durationMin;

    public int DurationMin
    {
        get { return durationMin; }
        set
        {
            if (value <= 0) throw new ArgumentException("Duration must be positive.");
            durationMin = value;
        }
    }

    public string Notes { get; set; }

    public RecoverySession() { }

    public RecoverySession(string id, string date, string type, int durationMin, string notes)
    {
        Id = id;
        Date = date;
        Type = type;
        DurationMin = durationMin;
        Notes = notes;
    }

    public static RecoverySession CreateSession(string id, string date, string type, int durationMin, string notes)
    {
        return new RecoverySession(id, date, type, durationMin, notes);
    }

    public void LogCompletion()
    {
        Console.WriteLine("Session completed!");
    }

    public void GetBenefits()
    {
        Console.WriteLine($"Benefits of {Type}: relaxation + recovery");
    }

    public void ShowSessionInfo()
    {
        Console.WriteLine($"{Type} session on {Date}, {DurationMin} min\nNotes: {Notes}");
    }
}
