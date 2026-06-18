public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int bonus, int target) : base(name, description, points)
    {
        _amountCompleted = 0;
        _bonus = bonus;
        _target = target;
    }
    public ChecklistGoal(string name, string description, int points, int bonus, int completed, int target) : base(name, description,points)
    {
        _bonus = bonus;
        _amountCompleted = completed;
        _target = target;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }
        _amountCompleted++;
        if (IsComplete())
        {
            return GetPoints() + _bonus;
        }
        else
        {
            return GetPoints();
        }
    }
    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] - {GetName()} - {GetDescription()} - Finished: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] - {GetName()} - {GetDescription()} - Currently Completed: {_amountCompleted}/{_target}";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_amountCompleted}|{_target}";
    }
}