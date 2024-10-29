public abstract class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal (string name, string description, int points, int target, int bonus)
    : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"{ShortName} registrado. ¡Ganaste {Points} puntos!");

            // Verify if the person reached out enough points
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"¡Congrats! You completed {ShortName} and earned a bonus of {_bonus} points.");
            }
        }
        else
        {
            Console.WriteLine($"{ShortName} has been completed the required number of times.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"{(_amountCompleted >= _target ? "[X]" : "[ ]")} {ShortName} - {Description} (Completed {_amountCompleted}/{_target} times)";
    }

    public override string GetDetailString()
    {
        return $"{ShortName}: {Description} - Puntos: {Points}, Bono: {_bonus} - Completado {_amountCompleted}/{_target} veces";
    }

}