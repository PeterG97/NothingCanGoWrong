namespace GameLogic;

public partial class Idle : State
{
    [Export] private CharacterBody2D enemyNode;
    
    [Export] private int moveSpeed = 10;
    private Vector2 MoveDirection;
    private double WanderTime;

    private readonly Random random = new Random();
    private Player player;

    private void RandomizeWander()
    {
        MoveDirection = new Vector2(random.Next(-1,1),random.Next(-1,1));
        WanderTime = random.Next(1,3);
    }

    public override void Enter()
    {
        RandomizeWander();
        player = GetTree().GetFirstNodeInGroup("Player") as Player;
    }
    
    public override void Update(double delta)
    {
        if (WanderTime > 0)
        {
            WanderTime -= delta;
        }
        else
        {
            RandomizeWander();
        }
    }
    public override void PhysicsUpdate(double delta)
    {
        if (enemyNode is not null)
        {
            enemyNode.Velocity = MoveDirection * moveSpeed;
        }
        
        var direction = player.GlobalPosition - enemyNode.GlobalPosition;
        
        if (direction.Length() < 150)
        {
            EmitSignal(SignalName.Changed, this, "Chase");
        }
    }
}