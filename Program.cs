using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Fitness App Demo (C# Version) ===\n");

        // --- CommunityProfile ---
        CommunityProfile user = CommunityProfile.CreateProfile("001", "Alex", "2025-01-15");
        user.AddFriend("Friend_002");
        user.AwardBadge("Early Bird");

        Console.WriteLine("Community Profile:");
        user.ShowProfileInfo();
        Console.WriteLine();

        // --- HydrationTracker ---
        HydrationTracker ht = HydrationTracker.CreateHydrationTracker("001", 2000);
        ht.AddDrink(500);
        ht.AddDrink(700);

        Console.WriteLine("Hydration Progress:");
        Console.WriteLine($"Progress today: {ht.ProgressToday()}%\n");

        // --- SleepTracker ---
        SleepTracker[] sleepArray = new SleepTracker[2];
        sleepArray[0] = SleepTracker.CreateSleepTracker("001");
        sleepArray[1] = SleepTracker.CreateSleepTracker("002");

        sleepArray[0].LogSleep(7);
        sleepArray[0].LogSleep(8);
        sleepArray[1].LogSleep(6);
        sleepArray[1].LogSleep(7);

        Console.WriteLine("Sleep Stats:");
        Console.WriteLine($"User1 avg sleep: {sleepArray[0].AverageSleep(2)} hours");
        Console.WriteLine($"User2 avg sleep: {sleepArray[1].AverageSleep(2)} hours\n");

        // --- Challenges ---
        List<Challenge> activeChallenges = new List<Challenge>();
        activeChallenges.Add(Challenge.CreateChallenge("CH1", "30-Day Plank", "Do plank daily", 30));
        activeChallenges.Add(Challenge.CreateChallenge("CH2", "Run Week", "Run 5 days a week", 7));

        activeChallenges[0].Join("001");

        Console.WriteLine("Challenges:");
        foreach (var c in activeChallenges)
            c.ShowChallengeInfo();
        Console.WriteLine();

        // --- Leaderboard ---
        Leaderboard lb = Leaderboard.CreateLeaderboard("LB1", "Month");
        lb.AddScore("001", 150);
        lb.AddScore("002", 130);
        lb.AddScore("003", 170);

        Console.WriteLine("Leaderboard:");
        lb.ShowLeaderboard();
        Leaderboard.ShowTotalPoints();
        Console.WriteLine();

        // --- RecoverySession ---
        RecoverySession session = RecoverySession.CreateSession("R1", "2025-03-01", "Yoga", 45, "Nice relaxation");
        Console.WriteLine("Recovery Session:");
        session.ShowSessionInfo();
        session.GetBenefits();

        Console.WriteLine("\n=== END OF DEMO ===");
    }
}
