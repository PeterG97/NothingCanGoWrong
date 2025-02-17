namespace GameLogic;

public partial class GameManager : Node
{
    public GuiManager GuiManager;

    [Export]
    public PackedScene[] Levels;

    private Node currentLevel;
    [Export]
    public Node CurrentLevel { get => currentLevel; set => SetLevel(value); }

	public override void _Ready()
	{
        GuiManager = this.FindChild<GuiManager>();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

    public void SetLevel(Node level)
    {
        currentLevel?.QueueFree();

        currentLevel = level;
        currentLevel.SetProcess(true);
        currentLevel.Reparent(this);
    }
}
