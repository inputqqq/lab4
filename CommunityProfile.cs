using System;
using System.Collections.Generic;

public class CommunityProfile
{
    public string Id { get; set; }
    public string Nickname { get; set; }
    public string JoinedDate { get; set; }

    public List<string> Friends { get; set; }
    public List<string> Badges { get; set; }

    public CommunityProfile()
    {
        Friends = new List<string>();
        Badges = new List<string>();
    }

    public CommunityProfile(string id, string nickname, string date)
    {
        Id = id;
        Nickname = nickname;
        JoinedDate = date;
        Friends = new List<string>();
        Badges = new List<string>();
    }

    public static CommunityProfile CreateProfile(string id, string nickname, string date)
    {
        return new CommunityProfile(id, nickname, date);
    }

    public void AddFriend(string friendId)
    {
        try
        {
            if (string.IsNullOrEmpty(friendId))
                throw new ArgumentException("Friend ID cannot be empty.");
            Friends.Add(friendId);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error adding friend: {ex.Message}");
        }
    }

    public void AwardBadge(string badge)
    {
        if (!string.IsNullOrEmpty(badge))
            Badges.Add(badge);
    }

    public void ShowProfileInfo()
    {
        Console.WriteLine($"{Id} — {Nickname}, joined {JoinedDate}");
    }
}
