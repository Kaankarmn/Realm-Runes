using System;
using System.Collections.Generic;

public class Challenge
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public bool IsCompleted { get; set; }
    public int RewardGems { get; set; }
}

public class DailyChallengeSystem
{
    private List<Challenge> challenges = new List<Challenge>();

    public void LoadChallenges()
    {
        GenerateNewChallenges();
    }

    public void CheckAndResetDailyChallenges()
    {
        foreach (var challenge in challenges)
        {
            if (challenge.IsCompleted)
            {
                challenge.CurrentCount = 0;
                challenge.IsCompleted = false;
            }
        }
    }

    public void GenerateNewChallenges()
    {
        challenges.Clear();
        challenges.Add(new Challenge { Title = "Puzzle Master", Description = "Solve 5 puzzles", TargetCount = 5, RewardGems = 50 });
        challenges.Add(new Challenge { Title = "Creature Collector", Description = "Collect 3 creatures", TargetCount = 3, RewardGems = 75 });
        challenges.Add(new Challenge { Title = "Rune Gatherer", Description = "Collect 10 runes", TargetCount = 10, RewardGems = 100 });
        challenges.Add(new Challenge { Title = "Combat Champion", Description = "Win 3 battles", TargetCount = 3, RewardGems = 60 });
    }

    public void UpdateChallengeProgress(string title)
    {
        var challenge = challenges.Find(c => c.Title == title);
        if (challenge != null && !challenge.IsCompleted)
        {
            challenge.CurrentCount++;
            if (challenge.CurrentCount >= challenge.TargetCount)
            {
                challenge.IsCompleted = true;
                Console.WriteLine($"You've completed '{challenge.Title}' and earned {challenge.RewardGems} gems!");
            }
        }
    }

    public List<Challenge> GetDailyChallenges()
    {
        return challenges;
    }

    public int GetCompletedChallengesCount()
    {
        return challenges.FindAll(c => c.IsCompleted).Count;
    }
}