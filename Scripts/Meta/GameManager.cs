namespace GameLogic;

public partial class GameManager : Node
{
    GameManager()
    {
        Instance = this;
    }

    public static GameManager Instance { get; private set; }

    [Export]
    private Goals goals;

    [Export]
    public PackedScene Menu;
    [Export]
    public Array<PackedScene> Levels { get; set; } = [];

    private Node currentScene;
    [Export]
    public Node CurrentScene { get; private set; }

    public int Level {  get; private set; }

	public override void _Ready()
	{
        Instance = this;

        SetScene(Menu);
    }

    public override void _Process(double delta)
	{
        
	}

    public void SetLevel(int level)
    {
        Level = level;
        SetScene(Levels[level - 1]);
        Goals.Instance.CreateRandomGoal(3);
    }

    public void NextLevel()
        => SetLevel(Level + 1);

    private Node SetScene(PackedScene scene)
    {
        currentScene?.QueueFree();
        currentScene = scene.Instantiate();
        AddChild(currentScene);

        return currentScene;
    }
}
