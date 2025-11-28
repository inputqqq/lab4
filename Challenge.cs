using System;
using System.Collections.Generic;

public class Challenge
{
	public string Id { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public int DurationDays { get; set; }
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
		Participants.Add(userId);
	}

	public double GetProgress(string userId)
	{
		if (!Participants.Contains(userId))
			return 0;

		return 50.0; // заглушка как в UML
	}

	public void ShowChallengeInfo()
	{
		Console.WriteLine($"{Title}\n{Description}\nDuration: {DurationDays} days");
		Console.WriteLine($"Participants: {Participants.Count}");
	}
}