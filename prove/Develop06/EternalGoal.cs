
using System.ComponentModel.DataAnnotations;

public abstract class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"{ShortName} registered. You won {Points} points!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"[∞] {ShortName} - {Description}";
    }

}
