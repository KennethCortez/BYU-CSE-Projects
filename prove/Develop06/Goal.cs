public abstract class Goal
{
    private string _shortname;
    private string _description;
    private int _points;

    public Goal (string name, string description, int points)
    {
        _shortname = name;
        _description = description;
        _points = points;

    }

    public string ShortName => _shortname;
    public string Description => _description;
    public int Points => _points;

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailString();
    public abstract string GetStringRepresentation();
    
}