namespace GameLogic;

public partial class Goals : Node
{
    Goals()
    {
        Instance = this;
    }

    public static Goals Instance { get; private set; }

    [Export]
    private PackedScene PackedGoal;

    [Export]
    private Container GoalsContainer { get; set; }

    private List<GoalData> genericGoals =
    [
        new GoalData() { Description = "Kill Enemies", Needed = 2, Difficulty = GoalData.GoalDifficulty.Easy },
        new GoalData() { Description = "Kill Enemies", Needed = 4, Difficulty = GoalData.GoalDifficulty.Medium },
        new GoalData() { Description = "Kill Enemies", Needed = 6, Difficulty = GoalData.GoalDifficulty.Hard },
        new GoalData() { Description = "Don't Kill", Needed = 1, Difficulty = GoalData.GoalDifficulty.Medium },
        new GoalData() { Description = "Not Detected", Needed = 1, Difficulty = GoalData.GoalDifficulty.Medium},
        new GoalData() { Description = "Not Detected", Needed = 2, Difficulty = GoalData.GoalDifficulty.Hard},
    ];

    public override void _Process(double delta)
	{
		
	}

    public void CreateGoal(GoalData goalData)
    {
        Goal goal = (Goal)PackedGoal.Instantiate();
        goal.Data = goalData;
        goal.Update();
        GoalsContainer.AddChild(goal);
    }

    public void CreateRandomGoal(int num)
    {
        RandomNumberGenerator rand = new();
        for (int i = 0; i < num; i++)
        {
            int goalIndex = rand.RandiRange(0, genericGoals.Count - 1);
            GD.Print(goalIndex);
            CreateGoal(genericGoals[rand.RandiRange(0, goalIndex)]);
        }
    }
}