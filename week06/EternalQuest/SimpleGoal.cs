public class SimpleGoal : Goal
{
    // Attributes
    private bool _isComplete;

    // constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    // methods
    // setter
    private void SetIsComplete(bool iscomplete) {
        _isComplete = iscomplete;
    }
    public override void recordEvent()
    {
        if (!IsComplete())
        {
            _isComplete = true;
            _lastEarnedPoints = GetPoint();
            Console.WriteLine($"Congrats! You have completed the goal and earned {_lastEarnedPoints} points!");
        }
        else
        {
            _lastEarnedPoints = 0;
            Console.WriteLine("This goal has already been completed!");
        }
    }



    public override bool IsComplete()
    {
        return _isComplete;
    }

    // serialization
    public override string GetStringRepresentation()
    {
        string _shortName = GetName();
        string _description = GetDescription();
        int _points = GetPoint();
        return $"SimpleGoal: {_shortName} | {_description} | {_points} | {_isComplete}";
    }

    // deserialization
    public static SimpleGoal Deserialize(string line)
    {
        if (!line.StartsWith("SimpleGoal:")) return null;
        string[] parts = line.Substring(11).Trim().Split('|');
        if (parts.Length != 4) return null;
        string name = parts[0].Trim();
        string description = parts[1].Trim();
        if (!int.TryParse(parts[2].Trim(), out int points)) return null;

        bool isComplete;
        if (!bool.TryParse(parts[3].Trim(), out isComplete))
        {
            isComplete = false;
        }
        SimpleGoal simpleGoal1 = new SimpleGoal(name, description, points);
        simpleGoal1.SetIsComplete(isComplete);
        return simpleGoal1;
    }   
}