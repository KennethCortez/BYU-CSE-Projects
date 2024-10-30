
public abstract class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal (string name, string description, int points) : base (name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"{ShortName} complete. You won {Points} points!");
        }
        else 
        {
            Console.WriteLine($"{ShortName} is already completed.");
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return _isComplete ? "[X] " : "[ ] " + $"{ShortName} - {Description}";
    }

}