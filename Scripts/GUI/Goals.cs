namespace GameLogic;

public partial class Goals : Node
{
    [Export]
    private PackedScene PackedGoal;

    [Export]
    private Container GoalsContainer { get; set; }

	public override void _Process(double delta)
	{
		
	}

    public void CreateGoal(GoalData goalData)
    {
        Goal goal = (Goal)PackedGoal.Instantiate();
        goal.Data = goalData;
        GoalsContainer.AddChild(goal);
    }
}